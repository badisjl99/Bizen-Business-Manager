using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest.Models
{
    public class Event
    {
    
        public string Event_Name { get; set; }
        public string Event_Type { get; set; }
        public string Event_Description { get; set; }
        public string Event_ID { get; set; }
        public DateTime Event_Date { get; set; }



        public Event(string event_Name, string event_Type, string event_Description, DateTime event_Date)
        {
            Event_Name = event_Name;
            Event_Type = event_Type;
            Event_Description = event_Description;
            Event_ID = GenerateID();
            Event_Date = event_Date;
        }

        private string GenerateID()
        {
            Random rand = new Random();
            int y = rand.Next(10000,1000000);
            string[] keys = { "Q","Z","M", "X", "N","B" ,"K","W","R","T","Y"};
           
            string result = "#EV" + y;
            
            for (int i = 1; i < 4; i++)
            {
                int x = rand.Next(keys.Length - 1);
                result += keys[x];

            }
            
            return result;
        }
    }
}
