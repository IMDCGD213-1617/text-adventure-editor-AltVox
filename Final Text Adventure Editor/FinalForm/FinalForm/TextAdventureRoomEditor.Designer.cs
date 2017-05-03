namespace FinalForm
{
    partial class TextAdventureRoomEditor
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
            this.RoomName = new System.Windows.Forms.Label();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.RoomDescription = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.NewRoom = new System.Windows.Forms.Label();
            this.RoomDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.NewRoomTextBox = new System.Windows.Forms.RichTextBox();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.RoomExits = new System.Windows.Forms.Label();
            this.SaveRoomButton = new System.Windows.Forms.Button();
            this.ExitList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoomName
            // 
            this.RoomName.AutoSize = true;
            this.RoomName.Location = new System.Drawing.Point(9, 36);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(66, 13);
            this.RoomName.TabIndex = 0;
            this.RoomName.Text = "Room Name";
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.Location = new System.Drawing.Point(12, 52);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.RoomNameTextBox.TabIndex = 1;
            this.RoomNameTextBox.TextChanged += new System.EventHandler(this.RoomNameTextBox_TextChanged);
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Location = new System.Drawing.Point(9, 80);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(91, 13);
            this.RoomDescription.TabIndex = 2;
            this.RoomDescription.Text = "Room Description";
            this.RoomDescription.Click += new System.EventHandler(this.Items_Click);
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(12, 215);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(62, 13);
            this.Item.TabIndex = 4;
            this.Item.Text = "Item(Single)";
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(12, 231);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(229, 20);
            this.ItemTextBox.TabIndex = 5;
            // 
            // NewRoom
            // 
            this.NewRoom.AutoSize = true;
            this.NewRoom.Location = new System.Drawing.Point(276, 52);
            this.NewRoom.Name = "NewRoom";
            this.NewRoom.Size = new System.Drawing.Size(76, 13);
            this.NewRoom.TabIndex = 10;
            this.NewRoom.Text = "Room Preview";
            // 
            // RoomDescriptionTextBox
            // 
            this.RoomDescriptionTextBox.Location = new System.Drawing.Point(12, 96);
            this.RoomDescriptionTextBox.Name = "RoomDescriptionTextBox";
            this.RoomDescriptionTextBox.Size = new System.Drawing.Size(229, 110);
            this.RoomDescriptionTextBox.TabIndex = 3;
            this.RoomDescriptionTextBox.Text = "";
            this.RoomDescriptionTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // NewRoomTextBox
            // 
            this.NewRoomTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.NewRoomTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.NewRoomTextBox.Location = new System.Drawing.Point(279, 68);
            this.NewRoomTextBox.Name = "NewRoomTextBox";
            this.NewRoomTextBox.ReadOnly = true;
            this.NewRoomTextBox.Size = new System.Drawing.Size(470, 280);
            this.NewRoomTextBox.TabIndex = 13;
            this.NewRoomTextBox.Text = "";
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.Location = new System.Drawing.Point(52, 385);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(140, 23);
            this.CreateRoomButton.TabIndex = 14;
            this.CreateRoomButton.Text = "Preivew Room";
            this.CreateRoomButton.UseVisualStyleBackColor = true;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // RoomExits
            // 
            this.RoomExits.AutoSize = true;
            this.RoomExits.Location = new System.Drawing.Point(9, 267);
            this.RoomExits.Name = "RoomExits";
            this.RoomExits.Size = new System.Drawing.Size(139, 13);
            this.RoomExits.TabIndex = 16;
            this.RoomExits.Text = "Room Exits(Single Exit Only)";
            // 
            // SaveRoomButton
            // 
            this.SaveRoomButton.Location = new System.Drawing.Point(445, 385);
            this.SaveRoomButton.Name = "SaveRoomButton";
            this.SaveRoomButton.Size = new System.Drawing.Size(130, 23);
            this.SaveRoomButton.TabIndex = 18;
            this.SaveRoomButton.Text = "Save Room";
            this.SaveRoomButton.UseVisualStyleBackColor = true;
            this.SaveRoomButton.Click += new System.EventHandler(this.SaveRoomButton_Click);
            // 
            // ExitList
            // 
            this.ExitList.FormattingEnabled = true;
            this.ExitList.Location = new System.Drawing.Point(12, 284);
            this.ExitList.Name = "ExitList";
            this.ExitList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ExitList.Size = new System.Drawing.Size(229, 95);
            this.ExitList.TabIndex = 19;
            this.ExitList.SelectedIndexChanged += new System.EventHandler(this.ExitList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Vahalla Text Adventure Room Creator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitList);
            this.Controls.Add(this.SaveRoomButton);
            this.Controls.Add(this.RoomExits);
            this.Controls.Add(this.CreateRoomButton);
            this.Controls.Add(this.NewRoomTextBox);
            this.Controls.Add(this.NewRoom);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.RoomDescriptionTextBox);
            this.Controls.Add(this.RoomDescription);
            this.Controls.Add(this.RoomNameTextBox);
            this.Controls.Add(this.RoomName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoomName;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.Label NewRoom;
        private System.Windows.Forms.RichTextBox RoomDescriptionTextBox;
        private System.Windows.Forms.RichTextBox NewRoomTextBox;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.Label RoomExits;
        private System.Windows.Forms.Button SaveRoomButton;
        private System.Windows.Forms.ListBox ExitList;
        private System.Windows.Forms.Label label1;
    }
}

