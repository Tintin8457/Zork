
namespace Zork.Builder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuFile = new System.Windows.Forms.MenuItem();
            this.MenuFileNewOption = new System.Windows.Forms.MenuItem();
            this.MenuFileOpenOption = new System.Windows.Forms.MenuItem();
            this.MenuFileDivider = new System.Windows.Forms.MenuItem();
            this.MenuFileSaveOption = new System.Windows.Forms.MenuItem();
            this.MenuFileSaveAsOption = new System.Windows.Forms.MenuItem();
            this.GameTab = new System.Windows.Forms.TabPage();
            this.WelcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.WorldTab = new System.Windows.Forms.TabPage();
            this.RoomsGroupBox = new System.Windows.Forms.GroupBox();
            this.RoomsListBox = new System.Windows.Forms.ListBox();
            this.RoomAddButton = new System.Windows.Forms.Button();
            this.RoomRemoveButton = new System.Windows.Forms.Button();
            this.RoomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.RoomDescriptionLabel = new System.Windows.Forms.Label();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.NeighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.NeighborSouthDropBox = new System.Windows.Forms.ComboBox();
            this.NeighborWestDropBox = new System.Windows.Forms.ComboBox();
            this.NeighborEastDropBox = new System.Windows.Forms.ComboBox();
            this.NeighborSouthLabel = new System.Windows.Forms.Label();
            this.NeighborWestLabel = new System.Windows.Forms.Label();
            this.NeighborEastLabel = new System.Windows.Forms.Label();
            this.NeighborNorthLabel = new System.Windows.Forms.Label();
            this.NeighborNorthDropBox = new System.Windows.Forms.ComboBox();
            this.StartingLocationDropBox = new System.Windows.Forms.ComboBox();
            this.StartingLocationLabel = new System.Windows.Forms.Label();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.defaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GameTab.SuspendLayout();
            this.WorldTab.SuspendLayout();
            this.RoomsGroupBox.SuspendLayout();
            this.NeighborsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLocationBindingSource)).BeginInit();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuFile});
            // 
            // MenuFile
            // 
            this.MenuFile.Index = 0;
            this.MenuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuFileNewOption,
            this.MenuFileOpenOption,
            this.MenuFileDivider,
            this.MenuFileSaveOption,
            this.MenuFileSaveAsOption});
            this.MenuFile.Text = "File";
            // 
            // MenuFileNewOption
            // 
            this.MenuFileNewOption.Index = 0;
            this.MenuFileNewOption.Text = "New Game File";
            this.MenuFileNewOption.Click += new System.EventHandler(this.New_File);
            // 
            // MenuFileOpenOption
            // 
            this.MenuFileOpenOption.Index = 1;
            this.MenuFileOpenOption.Text = "Open Game File";
            this.MenuFileOpenOption.Click += new System.EventHandler(this.Open_File);
            // 
            // MenuFileDivider
            // 
            this.MenuFileDivider.Index = 2;
            this.MenuFileDivider.Text = "-";
            // 
            // MenuFileSaveOption
            // 
            this.MenuFileSaveOption.Index = 3;
            this.MenuFileSaveOption.Text = "Save Game File";
            this.MenuFileSaveOption.Click += new System.EventHandler(this.Save_File);
            // 
            // MenuFileSaveAsOption
            // 
            this.MenuFileSaveAsOption.Index = 4;
            this.MenuFileSaveAsOption.Text = "Save Game File As...";
            this.MenuFileSaveAsOption.Click += new System.EventHandler(this.Save_As_File);
            // 
            // GameTab
            // 
            this.GameTab.Controls.Add(this.WelcomeMessageTextBox);
            this.GameTab.Controls.Add(this.WelcomeMessageLabel);
            this.GameTab.Location = new System.Drawing.Point(4, 22);
            this.GameTab.Name = "GameTab";
            this.GameTab.Padding = new System.Windows.Forms.Padding(3);
            this.GameTab.Size = new System.Drawing.Size(539, 358);
            this.GameTab.TabIndex = 2;
            this.GameTab.Text = "Game";
            this.GameTab.UseVisualStyleBackColor = true;
            this.GameTab.Click += new System.EventHandler(this.Game_Click);
            // 
            // WelcomeMessageTextBox
            // 
            this.WelcomeMessageTextBox.Location = new System.Drawing.Point(10, 20);
            this.WelcomeMessageTextBox.Name = "WelcomeMessageTextBox";
            this.WelcomeMessageTextBox.Size = new System.Drawing.Size(100, 20);
            this.WelcomeMessageTextBox.TabIndex = 1;
            this.WelcomeMessageTextBox.Text = "Welcome to Zork!";
            this.WelcomeMessageTextBox.TextChanged += new System.EventHandler(this.WelcomeMessageTextBox_Changed);
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(7, 3);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(98, 13);
            this.WelcomeMessageLabel.TabIndex = 0;
            this.WelcomeMessageLabel.Text = "Welcome Message";
            // 
            // WorldTab
            // 
            this.WorldTab.Controls.Add(this.RoomsGroupBox);
            this.WorldTab.Controls.Add(this.RoomDescriptionTextBox);
            this.WorldTab.Controls.Add(this.RoomNameTextBox);
            this.WorldTab.Controls.Add(this.RoomDescriptionLabel);
            this.WorldTab.Controls.Add(this.RoomNameLabel);
            this.WorldTab.Controls.Add(this.NeighborsGroupBox);
            this.WorldTab.Controls.Add(this.StartingLocationDropBox);
            this.WorldTab.Controls.Add(this.StartingLocationLabel);
            this.WorldTab.Location = new System.Drawing.Point(4, 22);
            this.WorldTab.Name = "WorldTab";
            this.WorldTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorldTab.Size = new System.Drawing.Size(539, 358);
            this.WorldTab.TabIndex = 0;
            this.WorldTab.Text = "World";
            this.WorldTab.UseVisualStyleBackColor = true;
            // 
            // RoomsGroupBox
            // 
            this.RoomsGroupBox.Controls.Add(this.RoomsListBox);
            this.RoomsGroupBox.Controls.Add(this.RoomAddButton);
            this.RoomsGroupBox.Controls.Add(this.RoomRemoveButton);
            this.RoomsGroupBox.Location = new System.Drawing.Point(6, 56);
            this.RoomsGroupBox.Name = "RoomsGroupBox";
            this.RoomsGroupBox.Size = new System.Drawing.Size(187, 288);
            this.RoomsGroupBox.TabIndex = 12;
            this.RoomsGroupBox.TabStop = false;
            this.RoomsGroupBox.Text = "Rooms";
            // 
            // RoomsListBox
            // 
            this.RoomsListBox.FormattingEnabled = true;
            this.RoomsListBox.Location = new System.Drawing.Point(5, 19);
            this.RoomsListBox.Name = "RoomsListBox";
            this.RoomsListBox.Size = new System.Drawing.Size(176, 225);
            this.RoomsListBox.TabIndex = 2;
            // 
            // RoomAddButton
            // 
            this.RoomAddButton.Location = new System.Drawing.Point(6, 259);
            this.RoomAddButton.Name = "RoomAddButton";
            this.RoomAddButton.Size = new System.Drawing.Size(75, 23);
            this.RoomAddButton.TabIndex = 5;
            this.RoomAddButton.Text = "Add";
            this.RoomAddButton.UseVisualStyleBackColor = true;
            this.RoomAddButton.Click += new System.EventHandler(this.RoomAddButton_Click);
            // 
            // RoomRemoveButton
            // 
            this.RoomRemoveButton.Location = new System.Drawing.Point(106, 259);
            this.RoomRemoveButton.Name = "RoomRemoveButton";
            this.RoomRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RoomRemoveButton.TabIndex = 6;
            this.RoomRemoveButton.Text = "Remove";
            this.RoomRemoveButton.UseVisualStyleBackColor = true;
            this.RoomRemoveButton.Click += new System.EventHandler(this.RoomRemoveButton_Click);
            // 
            // RoomDescriptionTextBox
            // 
            this.RoomDescriptionTextBox.Location = new System.Drawing.Point(200, 72);
            this.RoomDescriptionTextBox.Multiline = true;
            this.RoomDescriptionTextBox.Name = "RoomDescriptionTextBox";
            this.RoomDescriptionTextBox.Size = new System.Drawing.Size(330, 100);
            this.RoomDescriptionTextBox.TabIndex = 11;
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.Location = new System.Drawing.Point(200, 25);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(330, 20);
            this.RoomNameTextBox.TabIndex = 9;
            // 
            // RoomDescriptionLabel
            // 
            this.RoomDescriptionLabel.AutoSize = true;
            this.RoomDescriptionLabel.Location = new System.Drawing.Point(198, 56);
            this.RoomDescriptionLabel.Name = "RoomDescriptionLabel";
            this.RoomDescriptionLabel.Size = new System.Drawing.Size(91, 13);
            this.RoomDescriptionLabel.TabIndex = 10;
            this.RoomDescriptionLabel.Text = "Room Description";
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(198, 8);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(66, 13);
            this.RoomNameLabel.TabIndex = 8;
            this.RoomNameLabel.Text = "Room Name";
            // 
            // NeighborsGroupBox
            // 
            this.NeighborsGroupBox.Controls.Add(this.NeighborSouthDropBox);
            this.NeighborsGroupBox.Controls.Add(this.NeighborWestDropBox);
            this.NeighborsGroupBox.Controls.Add(this.NeighborEastDropBox);
            this.NeighborsGroupBox.Controls.Add(this.NeighborSouthLabel);
            this.NeighborsGroupBox.Controls.Add(this.NeighborWestLabel);
            this.NeighborsGroupBox.Controls.Add(this.NeighborEastLabel);
            this.NeighborsGroupBox.Controls.Add(this.NeighborNorthLabel);
            this.NeighborsGroupBox.Controls.Add(this.NeighborNorthDropBox);
            this.NeighborsGroupBox.Location = new System.Drawing.Point(199, 182);
            this.NeighborsGroupBox.Name = "NeighborsGroupBox";
            this.NeighborsGroupBox.Size = new System.Drawing.Size(327, 162);
            this.NeighborsGroupBox.TabIndex = 4;
            this.NeighborsGroupBox.TabStop = false;
            this.NeighborsGroupBox.Text = "Neighbors";
            // 
            // NeighborSouthDropBox
            // 
            this.NeighborSouthDropBox.FormattingEnabled = true;
            this.NeighborSouthDropBox.Location = new System.Drawing.Point(118, 120);
            this.NeighborSouthDropBox.Margin = new System.Windows.Forms.Padding(1);
            this.NeighborSouthDropBox.Name = "NeighborSouthDropBox";
            this.NeighborSouthDropBox.Size = new System.Drawing.Size(96, 21);
            this.NeighborSouthDropBox.TabIndex = 7;
            // 
            // NeighborWestDropBox
            // 
            this.NeighborWestDropBox.FormattingEnabled = true;
            this.NeighborWestDropBox.Location = new System.Drawing.Point(10, 73);
            this.NeighborWestDropBox.Margin = new System.Windows.Forms.Padding(1);
            this.NeighborWestDropBox.Name = "NeighborWestDropBox";
            this.NeighborWestDropBox.Size = new System.Drawing.Size(96, 21);
            this.NeighborWestDropBox.TabIndex = 6;
            // 
            // NeighborEastDropBox
            // 
            this.NeighborEastDropBox.FormattingEnabled = true;
            this.NeighborEastDropBox.Location = new System.Drawing.Point(224, 73);
            this.NeighborEastDropBox.Margin = new System.Windows.Forms.Padding(1);
            this.NeighborEastDropBox.Name = "NeighborEastDropBox";
            this.NeighborEastDropBox.Size = new System.Drawing.Size(96, 21);
            this.NeighborEastDropBox.TabIndex = 5;
            // 
            // NeighborSouthLabel
            // 
            this.NeighborSouthLabel.AutoSize = true;
            this.NeighborSouthLabel.Location = new System.Drawing.Point(147, 99);
            this.NeighborSouthLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NeighborSouthLabel.Name = "NeighborSouthLabel";
            this.NeighborSouthLabel.Size = new System.Drawing.Size(35, 13);
            this.NeighborSouthLabel.TabIndex = 4;
            this.NeighborSouthLabel.Text = "South";
            // 
            // NeighborWestLabel
            // 
            this.NeighborWestLabel.AutoSize = true;
            this.NeighborWestLabel.Location = new System.Drawing.Point(45, 52);
            this.NeighborWestLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NeighborWestLabel.Name = "NeighborWestLabel";
            this.NeighborWestLabel.Size = new System.Drawing.Size(32, 13);
            this.NeighborWestLabel.TabIndex = 3;
            this.NeighborWestLabel.Text = "West";
            // 
            // NeighborEastLabel
            // 
            this.NeighborEastLabel.AutoSize = true;
            this.NeighborEastLabel.Location = new System.Drawing.Point(259, 52);
            this.NeighborEastLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NeighborEastLabel.Name = "NeighborEastLabel";
            this.NeighborEastLabel.Size = new System.Drawing.Size(28, 13);
            this.NeighborEastLabel.TabIndex = 2;
            this.NeighborEastLabel.Text = "East";
            // 
            // NeighborNorthLabel
            // 
            this.NeighborNorthLabel.AutoSize = true;
            this.NeighborNorthLabel.Location = new System.Drawing.Point(150, 16);
            this.NeighborNorthLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NeighborNorthLabel.Name = "NeighborNorthLabel";
            this.NeighborNorthLabel.Size = new System.Drawing.Size(33, 13);
            this.NeighborNorthLabel.TabIndex = 1;
            this.NeighborNorthLabel.Text = "North";
            // 
            // NeighborNorthDropBox
            // 
            this.NeighborNorthDropBox.FormattingEnabled = true;
            this.NeighborNorthDropBox.Location = new System.Drawing.Point(118, 36);
            this.NeighborNorthDropBox.Margin = new System.Windows.Forms.Padding(1);
            this.NeighborNorthDropBox.Name = "NeighborNorthDropBox";
            this.NeighborNorthDropBox.Size = new System.Drawing.Size(96, 21);
            this.NeighborNorthDropBox.TabIndex = 0;
            // 
            // StartingLocationDropBox
            // 
            this.StartingLocationDropBox.FormattingEnabled = true;
            this.StartingLocationDropBox.Location = new System.Drawing.Point(11, 25);
            this.StartingLocationDropBox.Name = "StartingLocationDropBox";
            this.StartingLocationDropBox.Size = new System.Drawing.Size(176, 21);
            this.StartingLocationDropBox.TabIndex = 1;
            // 
            // StartingLocationLabel
            // 
            this.StartingLocationLabel.AutoSize = true;
            this.StartingLocationLabel.Location = new System.Drawing.Point(9, 8);
            this.StartingLocationLabel.Name = "StartingLocationLabel";
            this.StartingLocationLabel.Size = new System.Drawing.Size(87, 13);
            this.StartingLocationLabel.TabIndex = 0;
            this.StartingLocationLabel.Text = "Starting Location";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "World";
            this.roomsBindingSource.DataSource = this.defaultBindingSource;
            // 
            // startLocationBindingSource
            // 
            this.startLocationBindingSource.DataSource = this.defaultBindingSource;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.WorldTab);
            this.TabControl.Controls.Add(this.GameTab);
            this.TabControl.Location = new System.Drawing.Point(1, -2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(547, 384);
            this.TabControl.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.Filter = "Json files|*.json|All files|*.*";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Browse Game Files";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.Filter = "Json files|*.json|All files|*.*";
            this.saveFileDialog.FilterIndex = 2;
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save Game File As";
            // 
            // defaultBindingSource
            // 
            this.defaultBindingSource.AllowNew = true;
            this.defaultBindingSource.DataMember = "Game";
            this.defaultBindingSource.DataSource = typeof(Zork.Builder.ViewModel.GameViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 380);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.GameTab.ResumeLayout(false);
            this.GameTab.PerformLayout();
            this.WorldTab.ResumeLayout(false);
            this.WorldTab.PerformLayout();
            this.RoomsGroupBox.ResumeLayout(false);
            this.NeighborsGroupBox.ResumeLayout(false);
            this.NeighborsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLocationBindingSource)).EndInit();
            this.TabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.OpenFileDialog GetFileDialog
        {
            get => openFileDialog;
        }


        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem MenuFile;
        private System.Windows.Forms.MenuItem MenuFileNewOption;
        private System.Windows.Forms.MenuItem MenuFileOpenOption;
        private System.Windows.Forms.MenuItem MenuFileDivider;
        private System.Windows.Forms.MenuItem MenuFileSaveOption;
        private System.Windows.Forms.MenuItem MenuFileSaveAsOption;
        private System.Windows.Forms.TabPage GameTab;
        private System.Windows.Forms.TextBox WelcomeMessageTextBox;
        private System.Windows.Forms.Label WelcomeMessageLabel;
        private System.Windows.Forms.TabPage WorldTab;
        private System.Windows.Forms.TextBox RoomDescriptionTextBox;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.Label RoomDescriptionLabel;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Button RoomRemoveButton;
        private System.Windows.Forms.Button RoomAddButton;
        private System.Windows.Forms.GroupBox NeighborsGroupBox;
        private System.Windows.Forms.ComboBox NeighborSouthDropBox;
        private System.Windows.Forms.ComboBox NeighborWestDropBox;
        private System.Windows.Forms.ComboBox NeighborEastDropBox;
        private System.Windows.Forms.Label NeighborSouthLabel;
        private System.Windows.Forms.Label NeighborWestLabel;
        private System.Windows.Forms.Label NeighborEastLabel;
        private System.Windows.Forms.Label NeighborNorthLabel;
        private System.Windows.Forms.ComboBox NeighborNorthDropBox;
        private System.Windows.Forms.ListBox RoomsListBox;
        private System.Windows.Forms.ComboBox StartingLocationDropBox;
        private System.Windows.Forms.Label StartingLocationLabel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox RoomsGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource defaultBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource startLocationBindingSource;
    }
}

