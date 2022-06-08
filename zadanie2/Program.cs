using static System.Math;


    public class Program
    {
        public class zadanie2
        {
            public double radiant;
            public double gradus;
            public int to_round;
            public double Pi;
            public double gradisandradiant;
            public double radiantandgradus;
            public zadanie2()
            {
                Pi = Math.PI;
                Console.WriteLine("введите градусы");
                gradus = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите радиант");
                radiant = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("до какого числа округлить");
                radiant = Convert.ToInt32(Console.ReadLine());

                gradisandradiant = gradus * Pi / 180;
                radiantandgradus = radiant * 180 / Pi;

            }
        }

        public static void Main()
        {
            zadanie2 zadanie2 = new zadanie2();
            Console.WriteLine("из радианта в градусы");
            Console.WriteLine(Math.Round(zadanie2.radiantandgradus));
            Console.WriteLine("из градуса в радианты");
            Console.WriteLine(Math.Round(zadanie2.gradisandradiant));
        }
    }
