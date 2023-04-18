using Members.Core.Commands;
using Members.Core.Patterns;
using Members.Models.Commands;
using Members.Models.Domain;
using MembersApp.Commands;
using MembersApp.Extensions;

namespace MembersApp
{
    public partial class MainForm : Form
    {
        private ICommandManager CommandManager { get; } = new CommandManager();

        public MainForm()
        {
            InitializeComponent();

            peopleTreeView.AfterSelect += (s, a) =>
                joinButton.Enabled = peopleTreeView.HasSelectedNode() &&
                                     groupsTreeView.HasSelectedNodeOfType<Group>();

            groupsTreeView.AfterSelect += (s, a) =>
                joinButton.Enabled = peopleTreeView.HasSelectedNode() &&
                                     groupsTreeView.HasSelectedNodeOfType<Group>();

            groupsTreeView.AfterSelect += (s, a) =>
                leaveButton.Enabled = groupsTreeView.HasSelectedNodeOfType<Person>();

            CommandManager.Notify += (s, a) =>
                undoToolStripButton.Enabled = CommandManager.HasUndo;

            CommandManager.Notify += (s, a) =>
                redoToolStripButton.Enabled = CommandManager.HasRedo;

        }

        private void AddMemberNode(TreeNodeCollection nodes, Member member)
        {
            var node = nodes.Add(member.Name);
            node.ImageKey = node.SelectedImageKey = member.GetType().Name;

            node.Subscribe(member, (s, a) => node.Text = member.Name);
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
                //person.Name = dialog.Value;
                CommandManager.Execute(new RenameCommand(person, dialog.Value));
            }
        }

        private void OnAddPerson(object sender, EventArgs e)
        {
            var dialog = new PromptForm
            {
                Title = "Create Person",
                Label = "Name:",
                Value = string.Empty
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var person = new Person() { Name = dialog.Value };
                AddMemberNode(peopleTreeView.Nodes, person);
            }
        }

        private void OnAddGroup(object sender, EventArgs e)
        {
            var dialog = new PromptForm
            {
                Title = "Create Group",
                Label = "Name:",
                Value = string.Empty
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var group = new Group() { Name = dialog.Value };
                AddMemberNode(groupsTreeView.Nodes, group);
            }
        }

        private void OnJoinGroup(object sender, EventArgs e)
        {
            var group = groupsTreeView.SelectedNode?.GetSemantic<Group>();
            if (group == null) return;

            var person = peopleTreeView.SelectedNode?.GetSemantic<Person>();
            if (person == null) return;

            if (group.Members.Contains(person)) return;

            CommandManager.Execute(
                new MacroCommand(
                    new JoinCommand(group, person),
                    new AddTreeNodeCommand(
                        groupsTreeView.SelectedNode.Nodes, person)));

            //group.Members.Add(person);
            //AddMemberNode(groupsTreeView.SelectedNode.Nodes, person);
        }

        private void OnLeaveGroup(object sender, EventArgs e)
        {
            var person = groupsTreeView.SelectedNode?.GetSemantic<Person>();
            if (person == null) return;

            var group = groupsTreeView.SelectedNode?.Parent?.GetSemantic<Group>();
            if (group == null) return;

            CommandManager.Execute(
                new MacroCommand(
                    new LeaveCommand(group, person),
                    new SelectTreeNode(groupsTreeView.SelectedNode.Parent),
                    new RemoveTreeNodeCommand(groupsTreeView.SelectedNode)));

            //group.Members.Remove(person);

            //groupsTreeView.SelectedNode?.Unsubscribe();
            //groupsTreeView.SelectedNode?.Remove();
        }
    }
}