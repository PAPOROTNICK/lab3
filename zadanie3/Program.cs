using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;



public class zadanie5
{
    private int[,] MasRand = new int[5, 10];
    private int newchisla;
    public int min;
    public int max;
    public double sin;
    public double cos;
    public double tan;
    public double sins;
    public double coss;
    public double tans;
    public double[] mas_0 = new double[5];
    public double mas_1 = 0;

    public zadanie5()
    {
        AutoFill();
        Printmas();
        MaxANDMinMas();
        zadanie2();

    }

    private void AutoFill()
    {
        Random rmd = new Random();
        HashSet<int> known = new HashSet<int>();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {

                newchisla = rmd.Next(-100, 100);
                while (known.Contains(newchisla))
                {
                    newchisla = rmd.Next(-100, 100);
                }
                known.Add(newchisla);
                MasRand[i, j] = newchisla;

            }
        }
    }
    public void Printmas()
    {
        Console.WriteLine("____________________ввывод массива____________________");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(MasRand[i, j]);
            }
        }
    }
    public void MaxANDMinMas()
    {
        min = MasRand[0, 0];
        max = MasRand[0, 0];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (min > MasRand[i, j])
                    min = MasRand[i, j];
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (max < MasRand[i, j])
                    max = MasRand[i, j];
            }
        }
    }
    public void PrintMinANDMax()
    {
        Console.WriteLine($"Минимальный элемент:" + min);
        Console.WriteLine($"Минимальный элемент:" + max);

    }

    public void SINANDCOSANDTAN()
    {
        for (int j = -10; j < 10; j++)
        {

            sin = Math.Sin(j * max);
            cos = Math.Cos(j * max);
            tan = Math.Tan(j * max);
            double sinround = Math.Round(sin, 2);
            double cosround = Math.Round(cos, 2);
            double tanround = Math.Round(tan, 2);
            sins = sinround;
            coss = cosround;
            tans = tanround;
            Console.WriteLine("________________рассчет sin ________________");
            Console.WriteLine(sins);
            Console.WriteLine("________________рассчет cos ________________");
            Console.WriteLine(coss);
            Console.WriteLine("________________рассчет tan ________________");
            Console.WriteLine(tans);


        }
    }

    public void zadanie2()
    {

        for (int i = 0; i < 5; i++)
        {

            for (int j = 0; j < 10; j++)
            {
                mas_1 = Math.Abs(MasRand[i, j]);
            }
            mas_1 /= 10;
            mas_0[i] = mas_1;

        }

    }
    public void PrintZadanie2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(mas_0[i]);
        }
    }

    public void zadanie3()
    {
        double min2 = double.MinValue;
        double max2 = double.MaxValue;
        for (int i = 0; i < 5; i++)
        {
            if (mas_0[i] < min2)
            {
                min2 = mas_0[i];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (mas_0[i] > min2)
            {
                max2 = mas_0[i];
            }
        }

        Console.WriteLine("минимальное значение" + min2);
        Console.WriteLine("максимальное значение" + max2);
        using StreamWriter file = new("test.xlst", append: true);
        for (int j = -10; j < 10; j++)
        {
            double sin = Math.Sin(j * max2);
            double cos = Math.Cos(j * max2);
            double tan = Math.Tan(j * max2);
            double sinround = Math.Round(sin, 2);
            double cosround = Math.Round(cos, 2);
            double tanround = Math.Round(tan, 2);
            string sins = Convert.ToString(sinround);
            string coss = Convert.ToString(cosround);
            string tans = Convert.ToString(tanround);


            file.WriteLineAsync($"|{sins}|{coss}|{tans}|");
        }
    }

        tatic void Main()
        {
            var zadanie5 = new zadanie5();
            
            Console.WriteLine("____________________задание первое____________________");
            zadanie5.PrintMinANDMax();
            Console.WriteLine("____________________рассчет sin,cos.tan____________________");
            zadanie5.SINANDCOSANDTAN();
            Console.WriteLine("____________________задание второе____________________");
            zadanie5.PrintZadanie2();
            Console.WriteLine("____________________задание третье____________________");
        }

    
}




















