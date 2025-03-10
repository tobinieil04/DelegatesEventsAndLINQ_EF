using Delegates101;
using System.Threading.Channels;

namespace Delegates101
{

    class Publisher
    {
        public delegate void Notify();
        public event Notify OnNotify;


        public void Trigger()
        {
            if (OnNotify != null)
                OnNotify();
        }
        public static void Welcome() => Console.WriteLine("Welcome");
        public static void GoodBye() => Console.WriteLine("Goodbye");

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }

    //internal class Program
    //{
    //    static void Main()
    //    {
    //        Publisher pub = new Publisher();
    //        pub.OnNotify += () => Console.WriteLine("Event triggered");
    //        pub.Trigger();
    //    }
    //}
}
