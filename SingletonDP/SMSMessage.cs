namespace SingletonDesignPatern
{
    public class SMSMessage : IMessage
    {
        public string content {get; set;}
        public string receiver{get; set;}
        public void Send()
        {
            /* SMS */
            System.Console.WriteLine("SMS Gönderildi...");
        }
    }
}
