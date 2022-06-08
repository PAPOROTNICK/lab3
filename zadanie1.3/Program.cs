class prorgam
{
    public class zadanie3
    {
        double ax1;
        double ay1;
        double bx1;
        double by1;
        double cx1;
        double cy1;
        double dx1;
        double dy1;

        double ax2;
        double ay2;
        double bx2;
        double by2;
        double cx2;
        double cy2;
        double dx2;
        double dy2;


        double levo1;
        double pravo1;
        double levo2;
        double pravo2;
        double up1;
        double down1;
        double up2;
        double down2;

        public zadanie3()
        {
            Vvod();
            Create();
            check();
            
        }

        public void Vvod()
        {
            Console.WriteLine("________________Точки первой фигуры________________");
            Console.WriteLine("введите точки первой фигуры a по х");
            ax1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки первой фигуры а по у ");
            ay1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки первой фигуры b по х");
            bx1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки первой фигуры b по у ");
            by1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки первой фигуры c по x ");
            cx1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки первой фигуры c по y ");
            cy1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки первой фигуры d по x ");
            dx1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки первой фигуры d по y ");
            dy1 = double.Parse(Console.ReadLine());


            Console.WriteLine("________________точки второй фигуры________________");
            Console.WriteLine("введите точки второй фигуры a по х ");
            ax2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки второй фигуры a по у ");
            ay2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки второй фигуры b по x ");
            bx2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки второй фигуры b по y ");
            by2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки второй фигуры c по x");
            cx2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки второй фигуры c по y ");
            cy2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки второй фигуры d по х ");
            dx2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите точки второй фигуры d по y ");
            dy2 = double.Parse(Console.ReadLine());

        }
        public void Create()
        {
            levo1 = ay1 + by1;
            pravo1 = cy1 + dy1;
            levo2 = ay1 + by1;
            pravo2 = cy2 + dy2;
            up1 = bx1 + cx1;
            down1 = ax1 + dx1;
            up2 = dx2 + cx2;
            down2 = ax2 + dx2;
        }
        public void check()
        {
            if (levo1 == pravo1 | levo2 == pravo2 | up1 == down1 | up2 == down2)
            {
                //проверяем накладывается ли или нет Проверяем если верхняя грань первого прямоугольника находится ниже второго, или нижняя выше верхней  грани первого. Тоже самое и для оси X. 
                if (by1 < dy2 || dy1 > by2 || dx1 < bx2 || bx1 > dx2)
                {
                    Console.WriteLine("фигуры построены и не накладываются");
                }
                else
                {
                    Console.WriteLine("накладываются");
                    
                }
            }

            else
            {
                Console.WriteLine("неверный ввод данных");
                
            }

            
        }
    }


    static void Main()
    {
        zadanie3 zadanie3 = new zadanie3();
        

    }
}