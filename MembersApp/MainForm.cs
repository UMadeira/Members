using Members.Core.Commands;
using Members.Core.Repositories;
using Members.Models.Commands;
using Members.Models.Domain;
using MembersApp.Commands;
using MembersApp.Extensions;

namespace MembersApp
{
    public partial class MainForm : Form
    {
        private IUnitOfWork UnitOfWork { get; set; }

        private ICommandManager CommandManager { get; } = new CommandManager();

        public MainForm( IUnitOfWork unitOfWork )
        {
            InitializeComponent();

            UnitOfWork = unitOfWork;

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

            LoadModel();
        }

        private void LoadModel()
        {
            foreach (var person in UnitOfWork.GetRepository<Person>().GetAll())
            {
                AddMemberNode(peopleTreeView.Nodes, person);
            }

            foreach (var group in UnitOfWork.GetRepository<Group>().GetAll())
            {
                var node = AddMemberNode(groupsTreeView.Nodes, group);
                foreach (var person in group.Members)
                {
                    AddMemberNode(node.Nodes, person);
                }
            }
        }

        private TreeNode AddMemberNode(TreeNodeCollection nodes, Member member)
        {
            var node = nodes.Add(member.Name);
            node.ImageKey = node.SelectedImageKey = member.GetType().Name;

            node.Subscribe(member, (s, a) => node.Text = member.Name);

            return node;
        }

        private void OnSave(object sender, EventArgs e)
        {
            var repository = UnitOfWork.GetRepository<Person>();
            foreach (var member in repository.GetAll())
            {
                if (!member.Zombie) continue;
                repository.Delete(member);
            }

            UnitOfWork?.SaveChanges();
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
                var person = UnitOfWork.GetRepository<Person>().Create();
                person.Name = dialog.Value;
                UnitOfWork.GetRepository<Person>().Insert(person);

                CommandManager.Execute(
                    new MacroCommand(
                        new CreateCommand(person),
                        new AddTreeNodeCommand(peopleTreeView.Nodes, person)));
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
                var group = UnitOfWork.GetRepository<Group>().Create();
                group.Name = dialog.Value;
                UnitOfWork.GetRepository<Group>().Insert(group);

                CommandManager.Execute(
                    new MacroCommand(
                        new CreateCommand(group),
                        new AddTreeNodeCommand(groupsTreeView.Nodes, group)));

                //AddMemberNode(groupsTreeView.Nodes, group);
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
        }

        private void OnDelete(object sender, EventArgs e)
        {
            if (peopleTreeView.Focused)
            {
                var node = peopleTreeView.SelectedNode;
                if (node == null) return;

                var people = node.GetSemantic<Person>();
                if (people == null) return;

                CommandManager.Execute(
                    new MacroCommand(
                        new DeleteCommand(people),
                        new RemoveTreeNodeCommand(node)));
            }
            else if (groupsTreeView.Focused)
            {
                var node = groupsTreeView.SelectedNode;
                if (node == null) return;

                var group = node.GetSemantic<Group>();
                if (group == null) return;

                CommandManager.Execute(
                    new MacroCommand(
                        new DeleteCommand(group),
                        new RemoveTreeNodeCommand(node)));
            }
        }
    }
}