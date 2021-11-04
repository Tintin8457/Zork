
namespace Zork.Builder
{
    partial class Form1
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.Game = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.World = new System.Windows.Forms.TabPage();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.editorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.RemoveRoomButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RoomDescription = new System.Windows.Forms.Label();
            this.RoomName = new System.Windows.Forms.Label();
            this.NeighborBox = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StartingLocation = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Game.SuspendLayout();
            this.World.SuspendLayout();
            this.roomsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.NeighborBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem3,
            this.menuItem6,
            this.menuItem7});
            this.menuItem1.Text = "File";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "New Game File";
            this.menuItem4.Click += new System.EventHandler(this.New_File);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Open Game File";
            this.menuItem5.Click += new System.EventHandler(this.Open_File);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "Save Game File";
            this.menuItem6.Click += new System.EventHandler(this.Save_File);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "Save Game File As...";
            this.menuItem7.Click += new System.EventHandler(this.Save_As_File);
            // 
            // Game
            // 
            this.Game.Controls.Add(this.textBox1);
            this.Game.Controls.Add(this.WelcomeMessage);
            this.Game.Location = new System.Drawing.Point(4, 22);
            this.Game.Name = "Game";
            this.Game.Padding = new System.Windows.Forms.Padding(3);
            this.Game.Size = new System.Drawing.Size(539, 358);
            this.Game.TabIndex = 2;
            this.Game.Text = "Game";
            this.Game.UseVisualStyleBackColor = true;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to Zork!";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Location = new System.Drawing.Point(7, 3);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(98, 13);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Welcome Message";
            // 
            // World
            // 
            this.World.Controls.Add(this.roomsGroupBox);
            this.World.Controls.Add(this.textBox3);
            this.World.Controls.Add(this.textBox2);
            this.World.Controls.Add(this.RoomDescription);
            this.World.Controls.Add(this.RoomName);
            this.World.Controls.Add(this.NeighborBox);
            this.World.Controls.Add(this.comboBox1);
            this.World.Controls.Add(this.StartingLocation);
            this.World.Location = new System.Drawing.Point(4, 22);
            this.World.Name = "World";
            this.World.Padding = new System.Windows.Forms.Padding(3);
            this.World.Size = new System.Drawing.Size(539, 358);
            this.World.TabIndex = 0;
            this.World.Text = "World";
            this.World.UseVisualStyleBackColor = true;
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.roomsListBox);
            this.roomsGroupBox.Controls.Add(this.AddRoomButton);
            this.roomsGroupBox.Controls.Add(this.RemoveRoomButton);
            this.roomsGroupBox.Location = new System.Drawing.Point(6, 56);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(187, 288);
            this.roomsGroupBox.TabIndex = 12;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms";
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.editorBindingSource;
            this.roomsListBox.DisplayMember = "RoomNames";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(5, 19);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(176, 225);
            this.roomsListBox.TabIndex = 2;
            this.roomsListBox.ValueMember = "Rooms";
            // 
            // editorBindingSource
            // 
            this.editorBindingSource.AllowNew = true;
            this.editorBindingSource.DataMember = "World";
            this.editorBindingSource.DataSource = this.roomsBindingSource;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Game";
            this.roomsBindingSource.DataSource = typeof(Zork.Builder.ViewModel.GameViewModel);
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(6, 259);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(75, 23);
            this.AddRoomButton.TabIndex = 5;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRoomButton
            // 
            this.RemoveRoomButton.Location = new System.Drawing.Point(106, 259);
            this.RemoveRoomButton.Name = "RemoveRoomButton";
            this.RemoveRoomButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveRoomButton.TabIndex = 6;
            this.RemoveRoomButton.Text = "Remove";
            this.RemoveRoomButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 72);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 100);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 20);
            this.textBox2.TabIndex = 9;
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Location = new System.Drawing.Point(198, 56);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(91, 13);
            this.RoomDescription.TabIndex = 10;
            this.RoomDescription.Text = "Room Description";
            // 
            // RoomName
            // 
            this.RoomName.AutoSize = true;
            this.RoomName.Location = new System.Drawing.Point(198, 8);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(66, 13);
            this.RoomName.TabIndex = 8;
            this.RoomName.Text = "Room Name";
            // 
            // NeighborBox
            // 
            this.NeighborBox.Controls.Add(this.comboBox5);
            this.NeighborBox.Controls.Add(this.comboBox4);
            this.NeighborBox.Controls.Add(this.comboBox3);
            this.NeighborBox.Controls.Add(this.label4);
            this.NeighborBox.Controls.Add(this.label3);
            this.NeighborBox.Controls.Add(this.label2);
            this.NeighborBox.Controls.Add(this.label1);
            this.NeighborBox.Controls.Add(this.comboBox2);
            this.NeighborBox.Location = new System.Drawing.Point(199, 182);
            this.NeighborBox.Name = "NeighborBox";
            this.NeighborBox.Size = new System.Drawing.Size(327, 162);
            this.NeighborBox.TabIndex = 4;
            this.NeighborBox.TabStop = false;
            this.NeighborBox.Text = "Neighbors";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(118, 120);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(96, 21);
            this.comboBox5.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(10, 73);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(96, 21);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(224, 73);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(96, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "South";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "West";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "East";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "North";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(118, 36);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // StartingLocation
            // 
            this.StartingLocation.AutoSize = true;
            this.StartingLocation.Location = new System.Drawing.Point(9, 8);
            this.StartingLocation.Name = "StartingLocation";
            this.StartingLocation.Size = new System.Drawing.Size(87, 13);
            this.StartingLocation.TabIndex = 0;
            this.StartingLocation.Text = "Starting Location";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.World);
            this.tabControl.Controls.Add(this.Game);
            this.tabControl.Location = new System.Drawing.Point(1, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(547, 384);
            this.tabControl.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 370);
            this.Controls.Add(this.tabControl);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Zork Builder";
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.World.ResumeLayout(false);
            this.World.PerformLayout();
            this.roomsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.NeighborBox.ResumeLayout(false);
            this.NeighborBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.OpenFileDialog GetFileDialog
        {
            get => openFileDialog;
        }


        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.TabPage Game;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.TabPage World;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.Label RoomName;
        private System.Windows.Forms.Button RemoveRoomButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.GroupBox NeighborBox;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StartingLocation;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource editorBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

