namespace SingletonDesignPatern
{
    public class MessageFactor /* Creator Class */
    {

        public enum EnumMessageTypes
        {
            SMS,
            Email
        }
        public IMessage CreateMessage(EnumMessageTypes messageType)
        {
            
            switch(messageType)
            {
                case EnumMessageTypes.Email:
                    return new EMailMessage();
                case EnumMessageTypes.SMS:
                    return new SMSMessage();
                default : 
                    return null;
            }
       
        }

        public IMessage CreateMessage()
        {
            string notification_type = System.Configuration.ConfigurationManager.AppSettings["bildirimtipi"];
        }
    }
}
