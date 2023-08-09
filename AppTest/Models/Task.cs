using System;

namespace AppTest.Models
{
    public class Task
    {
        public string Id { get; set; }
        public string task { get; set; }
        public string assigned_to { get; set; }
        public int status { get; set; }

        public Task(string task, string assigned)
        {

            this.Id = GenerateID();
            this.task = task;
            this.assigned_to = assigned;
            this.status = 0;

        }



        private string GenerateID()
        {

            Random rnd = new Random();
            int x = rnd.Next(10000, 100000);


            return "#TD" + x;
        }


    }
}
