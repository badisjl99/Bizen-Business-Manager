using System;

namespace AppTest.Controllers
{
    public class Message
    {
        public string MessageSender { get; set; }
        public string MessageReciver { get; set; }

        public string MessageContent { get; set; }

        public string MessageID { get; set; }
        public string MessageDate { get; set; }



        public Message(string sender, string reciever, string content)
        {

            this.MessageSender = sender;
            this.MessageReciver = reciever;
            this.MessageContent = content;
            this.MessageDate = GetMessageDate();
            this.MessageID = GenerateMessageID();


        }


        private string GenerateMessageID()
        {

            Random rand = new Random();
            int value = rand.Next(1000, 9999999);


            return "#MID" + value;

        }

        private string GetMessageDate()
        {

            DateTime dateTime = DateTime.Now;

            string date = dateTime.ToString();

            return date;
        }



    }
}
