namespace SingletonDesignPatern
{
    public interface IMessage
    {
        string content { get; set; }
        string receiver { get; set; }

        void Send();
    }
}