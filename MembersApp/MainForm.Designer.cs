﻿namespace MembersApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mainToolStrip = new ToolStrip();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            personToolStripButton = new ToolStripButton();
            groupToolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            undoToolStripButton = new ToolStripButton();
            redoToolStripButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            editToolStripButton = new ToolStripButton();
            deleteToolStripButton = new ToolStripButton();
            mainStatusStrip = new StatusStrip();
            mainStatusLabel = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            peopleTreeView = new TreeView();
            imageList = new ImageList(components);
            groupsTreeView = new TreeView();
            joinButton = new Button();
            leaveButton = new Button();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            mainToolStrip.SuspendLayout();
            mainStatusStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(960, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(62, 34);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(257, 40);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(257, 40);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(254, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(257, 40);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += OnSave;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(254, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(257, 40);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += OnExit;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(66, 34);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(315, 40);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += OnUndo;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(315, 40);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += OnRedo;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(312, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(315, 40);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(315, 40);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(315, 40);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(312, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(315, 40);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(78, 34);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(315, 40);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(315, 40);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem, helpToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(74, 34);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(315, 40);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(315, 40);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(315, 40);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(312, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(315, 40);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // mainToolStrip
            // 
            mainToolStrip.ImageScalingSize = new Size(24, 24);
            mainToolStrip.Items.AddRange(new ToolStripItem[] { saveToolStripButton, toolStripSeparator1, personToolStripButton, groupToolStripButton, toolStripSeparator6, undoToolStripButton, redoToolStripButton, toolStripSeparator7, editToolStripButton, deleteToolStripButton });
            mainToolStrip.Location = new Point(0, 38);
            mainToolStrip.Name = "mainToolStrip";
            mainToolStrip.Size = new Size(960, 34);
            mainToolStrip.TabIndex = 1;
            mainToolStrip.Text = "toolStrip";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(40, 28);
            saveToolStripButton.Text = "Save";
            saveToolStripButton.Click += OnSave;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // personToolStripButton
            // 
            personToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            personToolStripButton.Image = (Image)resources.GetObject("personToolStripButton.Image");
            personToolStripButton.ImageTransparentColor = Color.Magenta;
            personToolStripButton.Name = "personToolStripButton";
            personToolStripButton.Size = new Size(40, 28);
            personToolStripButton.Text = "Add Person";
            personToolStripButton.Click += OnAddPerson;
            // 
            // groupToolStripButton
            // 
            groupToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            groupToolStripButton.Image = (Image)resources.GetObject("groupToolStripButton.Image");
            groupToolStripButton.ImageTransparentColor = Color.Magenta;
            groupToolStripButton.Name = "groupToolStripButton";
            groupToolStripButton.Size = new Size(40, 28);
            groupToolStripButton.Text = "Add Group";
            groupToolStripButton.Click += OnAddGroup;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 34);
            // 
            // undoToolStripButton
            // 
            undoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoToolStripButton.Enabled = false;
            undoToolStripButton.Image = (Image)resources.GetObject("undoToolStripButton.Image");
            undoToolStripButton.ImageTransparentColor = Color.Magenta;
            undoToolStripButton.Name = "undoToolStripButton";
            undoToolStripButton.Size = new Size(40, 28);
            undoToolStripButton.ToolTipText = "Undo";
            undoToolStripButton.Click += OnUndo;
            // 
            // redoToolStripButton
            // 
            redoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoToolStripButton.Enabled = false;
            redoToolStripButton.Image = (Image)resources.GetObject("redoToolStripButton.Image");
            redoToolStripButton.ImageTransparentColor = Color.Magenta;
            redoToolStripButton.Name = "redoToolStripButton";
            redoToolStripButton.Size = new Size(40, 28);
            redoToolStripButton.Text = "redoToolStripButton";
            redoToolStripButton.ToolTipText = "Redo";
            redoToolStripButton.Click += OnRedo;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 34);
            // 
            // editToolStripButton
            // 
            editToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            editToolStripButton.Image = (Image)resources.GetObject("editToolStripButton.Image");
            editToolStripButton.ImageTransparentColor = Color.Magenta;
            editToolStripButton.Name = "editToolStripButton";
            editToolStripButton.Size = new Size(40, 28);
            editToolStripButton.Text = "Edit";
            editToolStripButton.Click += OnEdit;
            // 
            // deleteToolStripButton
            // 
            deleteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            deleteToolStripButton.Image = (Image)resources.GetObject("deleteToolStripButton.Image");
            deleteToolStripButton.ImageTransparentColor = Color.Magenta;
            deleteToolStripButton.Name = "deleteToolStripButton";
            deleteToolStripButton.Size = new Size(40, 28);
            deleteToolStripButton.Text = "Delete";
            deleteToolStripButton.Click += OnDelete;
            // 
            // mainStatusStrip
            // 
            mainStatusStrip.ImageScalingSize = new Size(24, 24);
            mainStatusStrip.Items.AddRange(new ToolStripItem[] { mainStatusLabel });
            mainStatusStrip.Location = new Point(0, 647);
            mainStatusStrip.Name = "mainStatusStrip";
            mainStatusStrip.Padding = new Padding(1, 0, 17, 0);
            mainStatusStrip.Size = new Size(960, 39);
            mainStatusStrip.TabIndex = 2;
            mainStatusStrip.Text = "statusStrip1";
            // 
            // mainStatusLabel
            // 
            mainStatusLabel.Name = "mainStatusLabel";
            mainStatusLabel.Size = new Size(28, 30);
            mainStatusLabel.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999924F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000038F));
            tableLayoutPanel1.Controls.Add(peopleTreeView, 0, 0);
            tableLayoutPanel1.Controls.Add(groupsTreeView, 2, 0);
            tableLayoutPanel1.Controls.Add(joinButton, 1, 0);
            tableLayoutPanel1.Controls.Add(leaveButton, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 72);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(960, 575);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // peopleTreeView
            // 
            peopleTreeView.Dock = DockStyle.Fill;
            peopleTreeView.FullRowSelect = true;
            peopleTreeView.HideSelection = false;
            peopleTreeView.ImageIndex = 0;
            peopleTreeView.ImageList = imageList;
            peopleTreeView.Location = new Point(4, 4);
            peopleTreeView.Margin = new Padding(4);
            peopleTreeView.Name = "peopleTreeView";
            tableLayoutPanel1.SetRowSpan(peopleTreeView, 2);
            peopleTreeView.SelectedImageIndex = 0;
            peopleTreeView.Size = new Size(452, 567);
            peopleTreeView.TabIndex = 0;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "Person");
            imageList.Images.SetKeyName(1, "Group");
            // 
            // groupsTreeView
            // 
            groupsTreeView.Dock = DockStyle.Fill;
            groupsTreeView.FullRowSelect = true;
            groupsTreeView.HideSelection = false;
            groupsTreeView.ImageIndex = 0;
            groupsTreeView.ImageList = imageList;
            groupsTreeView.Location = new Point(502, 4);
            groupsTreeView.Margin = new Padding(4);
            groupsTreeView.Name = "groupsTreeView";
            tableLayoutPanel1.SetRowSpan(groupsTreeView, 2);
            groupsTreeView.SelectedImageIndex = 0;
            groupsTreeView.Size = new Size(454, 567);
            groupsTreeView.TabIndex = 1;
            // 
            // joinButton
            // 
            joinButton.Anchor = AnchorStyles.Bottom;
            joinButton.AutoSize = true;
            joinButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            joinButton.Enabled = false;
            joinButton.Image = (Image)resources.GetObject("joinButton.Image");
            joinButton.Location = new Point(464, 253);
            joinButton.Margin = new Padding(4);
            joinButton.Name = "joinButton";
            joinButton.Size = new Size(30, 30);
            joinButton.TabIndex = 2;
            joinButton.UseVisualStyleBackColor = true;
            joinButton.Click += OnJoinGroup;
            // 
            // leaveButton
            // 
            leaveButton.Anchor = AnchorStyles.Top;
            leaveButton.AutoSize = true;
            leaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            leaveButton.Enabled = false;
            leaveButton.Image = (Image)resources.GetObject("leaveButton.Image");
            leaveButton.Location = new Point(464, 291);
            leaveButton.Margin = new Padding(4);
            leaveButton.Name = "leaveButton";
            leaveButton.Size = new Size(30, 30);
            leaveButton.TabIndex = 3;
            leaveButton.UseVisualStyleBackColor = true;
            leaveButton.Click += OnLeaveGroup;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(315, 40);
            helpToolStripMenuItem1.Text = "&Help";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 686);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mainStatusStrip);
            Controls.Add(mainToolStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "ES2023 - Members App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainToolStrip.ResumeLayout(false);
            mainToolStrip.PerformLayout();
            mainStatusStrip.ResumeLayout(false);
            mainStatusStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip mainToolStrip;
        private ToolStripButton personToolStripButton;
        private StatusStrip mainStatusStrip;
        private ToolStripButton groupToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton editToolStripButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TreeView peopleTreeView;
        private TreeView groupsTreeView;
        private Button joinButton;
        private Button leaveButton;
        private ToolStripButton undoToolStripButton;
        private ToolStripButton redoToolStripButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripStatusLabel mainStatusLabel;
        private ImageList imageList;
        private ToolStripButton deleteToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem helpToolStripMenuItem1;
    }
}