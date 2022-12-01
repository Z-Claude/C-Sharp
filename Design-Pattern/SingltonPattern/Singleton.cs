namespace Design_Pattern.SingltonPattern
{
    public class Singleton
    {
        private static Singleton? instance;

        public static Singleton GetInstance()
        {
            instance ??= new Singleton();
            return instance;
        }
    }
    public class SingletonLock
    {
        private static SingletonLock? instance;
        private static readonly object locker = new object();

        public static SingletonLock GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    instance ??= new SingletonLock();
                }
            }
            return instance;
        }
    }

    public class GenericSingleton<T> where T : class
    {
        private static T? instance;
        private static readonly object locker = new object();

        public static T GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    instance ??= Activator.CreateInstance(typeof(T), true) as T;
                }
            }
            return instance;
        }

    }
}
