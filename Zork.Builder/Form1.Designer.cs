
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
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.World = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RoomDescription = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RoomName = new System.Windows.Forms.Label();
            this.RemoveRoomButton = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.NeighborBox = new System.Windows.Forms.GroupBox();
            this.RoomsList = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StartingLocation = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.TabPage();
            this.Game = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.Files = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.World.SuspendLayout();
            this.NeighborBox.SuspendLayout();
            this.Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem3,
            this.menuItem5,
            this.menuItem6});
            this.menuItem1.Text = "File";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "New Game File";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Save Game File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Open Game File";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Options";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.World);
            this.tabControl.Controls.Add(this.Items);
            this.tabControl.Controls.Add(this.Game);
            this.tabControl.Controls.Add(this.Files);
            this.tabControl.Location = new System.Drawing.Point(3, -5);
            this.tabControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1459, 916);
            this.tabControl.TabIndex = 0;
            // 
            // World
            // 
            this.World.Controls.Add(this.textBox3);
            this.World.Controls.Add(this.RoomDescription);
            this.World.Controls.Add(this.textBox2);
            this.World.Controls.Add(this.RoomName);
            this.World.Controls.Add(this.RemoveRoomButton);
            this.World.Controls.Add(this.AddRoomButton);
            this.World.Controls.Add(this.NeighborBox);
            this.World.Controls.Add(this.RoomsList);
            this.World.Controls.Add(this.listBox1);
            this.World.Controls.Add(this.comboBox1);
            this.World.Controls.Add(this.StartingLocation);
            this.World.Location = new System.Drawing.Point(10, 48);
            this.World.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.World.Name = "World";
            this.World.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.World.Size = new System.Drawing.Size(1439, 858);
            this.World.TabIndex = 0;
            this.World.Text = "World";
            this.World.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(533, 141);
            this.textBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(873, 265);
            this.textBox3.TabIndex = 11;
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Location = new System.Drawing.Point(533, 100);
            this.RoomDescription.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(240, 32);
            this.RoomDescription.TabIndex = 10;
            this.RoomDescription.Text = "Room Description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(533, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(873, 38);
            this.textBox2.TabIndex = 9;
            // 
            // RoomName
            // 
            this.RoomName.AutoSize = true;
            this.RoomName.Location = new System.Drawing.Point(525, 7);
            this.RoomName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(172, 32);
            this.RoomName.TabIndex = 8;
            this.RoomName.Text = "Room Name";
            // 
            // RemoveRoomButton
            // 
            this.RemoveRoomButton.Location = new System.Drawing.Point(29, 767);
            this.RemoveRoomButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RemoveRoomButton.Name = "RemoveRoomButton";
            this.RemoveRoomButton.Size = new System.Drawing.Size(200, 55);
            this.RemoveRoomButton.TabIndex = 6;
            this.RemoveRoomButton.Text = "Remove";
            this.RemoveRoomButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(29, 694);
            this.AddRoomButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(200, 55);
            this.AddRoomButton.TabIndex = 5;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
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
            this.NeighborBox.Location = new System.Drawing.Point(531, 435);
            this.NeighborBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NeighborBox.Name = "NeighborBox";
            this.NeighborBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NeighborBox.Size = new System.Drawing.Size(873, 387);
            this.NeighborBox.TabIndex = 4;
            this.NeighborBox.TabStop = false;
            this.NeighborBox.Text = "Neighbors";
            // 
            // RoomsList
            // 
            this.RoomsList.AutoSize = true;
            this.RoomsList.Location = new System.Drawing.Point(21, 103);
            this.RoomsList.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.Size = new System.Drawing.Size(104, 32);
            this.RoomsList.TabIndex = 3;
            this.RoomsList.Text = "Rooms";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(29, 141);
            this.listBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(463, 531);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 45);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(463, 39);
            this.comboBox1.TabIndex = 1;
            // 
            // StartingLocation
            // 
            this.StartingLocation.AutoSize = true;
            this.StartingLocation.Location = new System.Drawing.Point(21, 7);
            this.StartingLocation.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.StartingLocation.Name = "StartingLocation";
            this.StartingLocation.Size = new System.Drawing.Size(230, 32);
            this.StartingLocation.TabIndex = 0;
            this.StartingLocation.Text = "Starting Location";
            // 
            // Items
            // 
            this.Items.Location = new System.Drawing.Point(10, 48);
            this.Items.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Items.Size = new System.Drawing.Size(1737, 939);
            this.Items.TabIndex = 1;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.Game.Controls.Add(this.textBox1);
            this.Game.Controls.Add(this.WelcomeMessage);
            this.Game.Location = new System.Drawing.Point(10, 48);
            this.Game.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Game.Name = "Game";
            this.Game.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Game.Size = new System.Drawing.Size(1737, 939);
            this.Game.TabIndex = 2;
            this.Game.Text = "Game";
            this.Game.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to Zork!";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Location = new System.Drawing.Point(19, 7);
            this.WelcomeMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(255, 32);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Welcome Message";
            // 
            // Files
            // 
            this.Files.Location = new System.Drawing.Point(10, 48);
            this.Files.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Files.Name = "Files";
            this.Files.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Files.Size = new System.Drawing.Size(1737, 939);
            this.Files.TabIndex = 3;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 39);
            this.comboBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "North";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "East";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "West";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "South";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(596, 174);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(249, 39);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(28, 174);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(249, 39);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(314, 286);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(249, 39);
            this.comboBox5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 905);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Zork Builder";
            this.tabControl.ResumeLayout(false);
            this.World.ResumeLayout(false);
            this.World.PerformLayout();
            this.NeighborBox.ResumeLayout(false);
            this.NeighborBox.PerformLayout();
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage World;
        private System.Windows.Forms.Label RoomsList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StartingLocation;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.TabPage Game;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.GroupBox NeighborBox;
        private System.Windows.Forms.Button RemoveRoomButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Label RoomName;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

