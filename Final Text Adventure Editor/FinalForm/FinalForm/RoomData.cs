using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalForm
{
    public class RoomData
    {

        //The following private strings below are uses to create save slots of the get return and set value functions.
        private string RoomNamedata;
        private string RoomDescriptiondata;
        private string RoomItemdata;
        private string RoomExitdata;

        //The following public classes get the data that has been entered within the respected classes in the windows form, setting that data as the values then exporting it to a XML Document. 
        public string roomNameData
        {                           //This public string gathers the data that has been enter for the room name and sets it as that value. 
            get { return RoomNamedata; }
            set { RoomNamedata = value; }
        }
        public string roomDescriptionData
        {                           //This public string gathers the data that has been enter for a room's description and sets it as that value. 
            get { return RoomDescriptiondata; }
            set { RoomDescriptiondata = value; }
        }
        public string roomItemData
        {                            //This public string gathers the data that has been enter for the item withing the room and sets it as that value. 
            get { return RoomItemdata; }
            set { RoomItemdata = value; }
        }
        public string roomExitData
        {                            //This public string gathers the data that has been enter for the exit within the room and sets it as that value. 
            get { return RoomExitdata; }
            set { RoomExitdata = value; }
        }
    }
}
