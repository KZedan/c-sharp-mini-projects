using System;

namespace complex_number_calculator
{
    class Program
    {
        struct complex
        {
            public int real;
            public int imaginary;
            public void getdata()
            {
                try
                {
                    Console.WriteLine("Enter the real part\t:");
                    real = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the imaginary part\t:");
                    imaginary = int.Parse(Console.ReadLine());
                }
                catch(Exception e1)
                {
                    Console.WriteLine("Error\t:" + e1);
                }
            }
            public void putdata()
            {
                Console.WriteLine(real + " + i" + imaginary);
            }
        }
        static void Main(string[] args)
        {
            int choice;
            complex c1 = new complex();
            complex c2 = new complex();
            complex result = new complex();
            Console.WriteLine("Enter the first complex number");
            c1.getdata();
            c1.putdata();
            Console.WriteLine("Enter the second complex number");
            c2.getdata();
            Console.WriteLine("1\t:Sum\n2\t:Product\n3\t:Difference\t:\n4\t:Exit");
            Console.WriteLine("Enter your choice");
            try
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        result.real = c1.real + c2.real;
                        result.imaginary = c1.imaginary + c2.imaginary;
                        result.putdata();
                        break;
                    case 2:
                        result.real = c1.real - c2.real;
                        result.imaginary = c1.imaginary - c2.imaginary;
                        result.putdata();
                        break;
                    case 3:
                        result.real = c1.real * c2.real - c1.imaginary * c2.imaginary;
                        result.imaginary = c1.real * c2.imaginary + c1.imaginary * c2.real;
                        result.putdata();
                        break;
                    case 4:
                        Console.WriteLine("Exitting");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine("Error\t" + e1);
            }
            Console.ReadKey();
        }
    }
}
