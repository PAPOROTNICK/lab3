using static System.Math;
namespace Program
{


    class zadanie1
    {
        double log;
        double osn;
        int to_round;

        public zadanie1()
        {
            Console.WriteLine("Введите логарифм");
            log = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите основание");
            osn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("До скольки округлять");
            to_round = Convert.ToInt32(Console.ReadLine());
        }
        public static void Main()
        {
            zadanie1 zadanie1 = new zadanie1();
            Console.WriteLine(Math.Round(Math.Log(zadanie1.log, zadanie1.osn), zadanie1.to_round));
        }
    }

}

         


    
