using Members.Core.Commands;
using Members.Core.Patterns;
using Members.Models.Commands;
using Members.Models.Domain;
using MembersApp.Commands;
using MembersApp.Extensions;
using System.Xml.Linq;

namespace MembersApp
{
    public partial class MainForm : Form
    {
        private ICommandManager CommandManager { get; } = new CommandManager();

        public MainForm()
        {
            InitializeComponent();

            peopleTreeView.AfterSelect += (s, a) =>
                joinButton.Enabled = peopleTreeView.SelectedNode != null &&
                                     groupsTreeView.SelectedNode?.GetSemantic<Group>() != null;

            groupsTreeView.AfterSelect += (s, a) =>
                joinButton.Enabled = peopleTreeView.HasNodeSelected() &&
                                     groupsTreeView.IsNodeSelected<Group>();

            groupsTreeView.AfterSelect += (s, a) =>
                leaveButton.Enabled = groupsTreeView.SelectedNode?.GetSemantic<Person>() != null;

            CommandManager.Notify += (s, a) => undoToolStripButton.Enabled = CommandManager.HasUndo;
            CommandManager.Notify += (s, a) => redoToolStripButton.Enabled = CommandManager.HasRedo;

            CommandManager.Notify += (s, a) => undoToolStripMenuItem.Enabled = CommandManager.HasUndo;
            CommandManager.Notify += (s, a) => redoToolStripMenuItem.Enabled = CommandManager.HasRedo;
        }

        private void Execute(ICommand command)
        {
            CommandManager.Execute(command);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnUndo(object sender, EventArgs e)
        {
            CommandManager.Undo();
        }

        private void OnRedo(object sender, EventArgs e)
        {
            CommandManager.Redo();
        }

        private void OnEdit(object sender, EventArgs e)
        {
            var person = peopleTreeView.SelectedNode?.GetSemantic<Person>();
            if (person == null) return;

            var dialog = new PromptForm
            {
                Title = "Change Name",
                Label = "Name:",
                Value = person.Name
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var command = new RenameMemberCommand(person, dialog.Value);
                CommandManager.Execute(command);
            }
        }

        private void OnAddPerson(object sender, EventArgs e)
        {
            var dialog = new PromptForm();
            dialog.Title = "Create Person";
            dialog.Label = "Name:";
            dialog.Value = string.Empty;

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var person = new Person() { Name = dialog.Value };
                Execute(new CreateTreeNodeCommand(peopleTreeView.Nodes, person));
            }
        }

        private void OnAddGroup(object sender, EventArgs e)
        {
            var dialog = new PromptForm();
            dialog.Title = "Create Group";
            dialog.Label = "Name:";
            dialog.Value = string.Empty;

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var group = new Group() { Name = dialog.Value };
                Execute(new CreateTreeNodeCommand(groupsTreeView.Nodes, group));
            }
        }

        private void OnJoinGroup(object sender, EventArgs e)
        {
            var group = groupsTreeView.SelectedNode?.GetSemantic<Group>();
            if (group == null) return;

            var person = peopleTreeView.SelectedNode?.GetSemantic<Person>();
            if (person == null) return;

            group.Members.Add(person);

            Execute(new CreateTreeNodeCommand(groupsTreeView.SelectedNode.Nodes, person));

        }

        private void OnLeaveGroup(object sender, EventArgs e)
        {
            var person = peopleTreeView.SelectedNode?.GetSemantic<Person>();
            if (person == null) return;

            var group = groupsTreeView.SelectedNode?.Parent?.GetSemantic<Group>();
            if (group == null) return;

            var node = groupsTreeView.SelectedNode;

            group.Members.Remove(person);

            var observer = groupsTreeView.SelectedNode?.Tag as Observer;
            observer?.Unsubscribe();

            Execute(new RemoveTreeNodeCommand(node.Parent.Nodes, node));
        }
    }
}