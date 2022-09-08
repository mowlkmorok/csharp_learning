using System;



namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            

            try
            {

                Console.Clear();

                Console.WriteLine("1° Number: ");
                float n1 = float.Parse(Console.ReadLine()!);

                Console.WriteLine("2° Number: ");
                float n2 = float.Parse(Console.ReadLine()!);

                Console.Clear();

                Console.WriteLine("\n-----------------\n1) +\n2) -\n3) *\n4) /");


                Console.WriteLine("\n________________\nOperation:\n");

                string opt = Console.ReadLine()!;


                Calc newCalc = new Calc(n1, n2);

                Console.WriteLine("\n________________\nResults:\n");
                switch (opt)
                {
                    case "1":
                        Console.WriteLine(newCalc.Sum());
                        break;

                    case "2":
                        Console.WriteLine(newCalc.Sub());
                        break;

                    case "3":
                        Console.WriteLine(newCalc.Mult());
                        break;
                        
                    case "4":
                        Console.WriteLine(newCalc.Div());
                        break;
                        
                    default:
                        Console.Clear();
                        Console.WriteLine("Option invalid [!]");
                        break;
                }


                Console.ReadLine();
    
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }



    struct Calc
    {
        public Calc(float number1, float number2)
        {
            Number1 = number1;
            Number2 = number2;
        }


        
        public float Number1;
        public float Number2;


        public float Sum()
        {

            return Number1 + Number2;

        }


        public float Sub()
        {
            return Number1 - Number2;
        }


        public float Mult()
        {
            return Number1 * Number2;
        }


        public float Div()
        {
            return  Number1 / Number2;
        }

    }



}