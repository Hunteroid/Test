using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Задание 2 
//Используя Visual Studio 2010, создайте проект по шаблону Console Application.  
//Требуется: Создать класс, представляющий треугольник. Предусмотреть методы для вычисления площади, периметра. 
//Описать свойства для получения состояния объекта.  
//Написать программу, демонстрирующую все разработанные элементы класса. 


namespace task2
{
    class Triangle
    {
        //поля (длины сторон)
        private int a, b, c;      

        //свойства (доступ к полям)
        public int A
        {
            set 
            {
                a = value;
            }
            get 
            {
                return a;
            }        
        }

        public int B
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }

        public int C
        {
            set
            {
                c = value;
            }
            get
            {
                return c;
            }
        }
    
        //коструктор создания экземпляров
        public Triangle(int a, int b, int c)
        { 
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //метод вычисления периметра
        public int Perimeter()
        {
            return (a + b + c);
        }

        //метод вычисления площади
        public double Square()
        {
            int pp = Perimeter()/2;
            return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для рассчета периметра и площади треугольника!");

            Console.Write("Введите цвет треугольника: ");
            string temp = Console.ReadLine();
            Color col = new Color(temp.ToString());
            Console.WriteLine();
            
            Console.Write("Введите длину стороны а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();                   
            
            Console.Write("Введите длину стороны b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите длину стороны c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(new string('-', 50));

            Triangle instanse = new Triangle(a, b, c);
            
            Console.WriteLine("Периметр треугольника равен: {0}", instanse.Perimeter());
            Console.WriteLine("Площадь треугольника равна: {0}", instanse.Square());
            Console.WriteLine("Цвет треугольника {0}", col.color);

            Console.ReadKey();            

        }
    }
}
