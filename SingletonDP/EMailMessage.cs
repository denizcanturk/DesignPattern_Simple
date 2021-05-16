namespace SingletonDesignPatern
{
    public class EMailMessage : IMessage
    {
        public string content { get; set; }
        public string receiver { get; set; }

        public void Send()
        {
            System.Console.WriteLine("E-Posta gönderildi...");
        }
    }
}
