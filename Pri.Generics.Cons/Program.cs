using Pri.Generics.Cons.Entities;
using Pri.Generics.Cons.Generics;

namespace Pri.Generics.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics voorbeelden");
            var order1 = new Order<int>(1, 10);
            var order2 = new Order<string>("My item", 5);
            //complex types
            var television = new Television 
            {
                Brand = "Philips",
                ScreenSize = 50,
                
            };
            var order3 = new Order<Television>(television, 20);
            //list van complex objects
            var televionList = new List<Television>
            {
                television,
                new Television
                {
                    Brand = "Philips",
                    ScreenSize = 40,
                },
                new Television
                {
                    Brand = "LG",
                    ScreenSize = 60,
                },
            };
            var order4 = new Order<List<Television>>(televionList, 4);
        }
    }
}