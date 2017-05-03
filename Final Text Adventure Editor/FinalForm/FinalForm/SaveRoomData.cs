using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;// Using serialization allows me to uses Serialize, which can turn objects into XML documents.
using System.IO;

namespace FinalForm
{
    class SaveRoomData
    {
      

        public static void SaveData(object room, string filename)
        {
            //Using XmlSerializer allows this function to control how objects are encoded into XML documents 
            XmlSerializer Data = new XmlSerializer(room.GetType());//This function creates a String(Name) for the exported XML Document.
           
            TextWriter writer = new StreamWriter(filename);//This function names and serializes the file XML Document created.
           
            Data.Serialize(writer, room); 


            writer.Close();//This function closes the writer stream from before. 
        }



    }
}
