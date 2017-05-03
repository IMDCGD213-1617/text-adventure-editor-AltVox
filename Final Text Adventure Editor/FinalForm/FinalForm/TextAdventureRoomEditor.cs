using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalForm
{
    public partial class TextAdventureRoomEditor : Form
    {

        public TextAdventureRoomEditor()
        {
            InitializeComponent();
           
            
            var Exit = ExitList.Items; //This line of code creates a varible name Exit, which is used to add items to the ExitList.  
            Exit.Add("North");
            Exit.Add("South");
            Exit.Add("East");
            Exit.Add("West");




        }

        private void Items_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            //This function replaces the text within the New room preview text box, with the text that has been enter in the follow text boxes listed below. With \n inbewteen to create spaces. I did this so it would look how it would within the console application.
            NewRoomTextBox.Text = RoomNameTextBox.Text + "\n\n" + RoomDescriptionTextBox.Text + "\n" + "\nYou find the following item:\n " + ItemTextBox.Text + "\n\nAvailable Exits:\n " + ExitList.Text;
        }

        public void SaveRoomButton_Click(object sender, EventArgs e)
        {
            //This line of code below creates a MeesageBox with a Yes,No or Cancel option. It double checks if the user is happy with the room that they have created.  
            DialogResult result1 = MessageBox.Show("Are you sure you want to create this room?","Save Room", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
          
          if(result1 == DialogResult.Yes)//If the result of answering the MessageBox is yes, then the follow If statement takes place. 
            {
               
                    RoomData Data = new RoomData();//This function replaces the old data with the new data that has been added. 
                    Data.roomNameData = RoomNameTextBox.Text;//This function obtains the text that has been enter within the RoomNameTextBox and extracts it as data to set as a value 
                    Data.roomDescriptionData = RoomDescriptionTextBox.Text; ;//This function obtains the text that has been enter within the RoomDescriptionTextBox and extracts it as data to set as a value 
                    Data.roomItemData = ItemTextBox.Text; ;//This function obtains the text that has been enter within the ItemTextBox and extracts it as data to set as a value 
                    Data.roomExitData = ExitList.Text; ;//This function obtains the text that has been enter within the ExitList and extracts it as data to set as a value 

                SaveRoomData.SaveData(Data, "RoomData.txt");//This line of code saves the data that has been previously obtained and exportes it as a .txt file in XML Format.          
            } 
           
            
        }

        private void ExitList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
