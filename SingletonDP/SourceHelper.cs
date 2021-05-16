namespace SingletonDesignPatern
{
    public class SourceHelper
    {
        private static SourceHelper instance;
        private SourceHelper(string instanceName)
        {
            this.InctanceName = instanceName;
        }

        public string InctanceName { get; }

        public static SourceHelper GetInstance(string instanceName)
        {
            if (instance == null) instance = new SourceHelper(instanceName);
            return instance;
        }
    }
}
//İnstance ın ikinci bir kez üretilmediğine ve aynı nesnenin adının yazıldığına dikkat ediniz