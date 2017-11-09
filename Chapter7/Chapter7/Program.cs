using System;

namespace Chapter7
{
    class Program
    {
        public Program()
        {
            int number = 10;
            Console.WriteLine("Si se introduce un numero con mas o con menos de 2 digitos el programa se cerrara");

            do
            {
                int exercise = 47;

                Console.WriteLine("Introduce el numero de ejercicio");
                exercise = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite un numero de 2 digitos");
                number = Int32.Parse(Console.ReadLine());

                switch (exercise)
                {
                    case 45:
                        Exercise45(number);
                        break;
                    case 46:
                        Exercise46(number);
                        break;
                    case 47:
                        break;
                    case 48:
                        break;
                    case 49:
                        break;
                    case 50:
                        break;

                    default:
                        break;
                }

            }
            while (number >= 10 && number <= 99);


        }

        private void Exercise45(int number)
        {
            Console.WriteLine("Ejercicio numero 45");

            if (IsEven(number))
            {
                PrintEvenNumber(number);
            }

            else if (IsPrime(number))
            {
                Console.WriteLine("------------------------------");

                Console.WriteLine("| Es Impar, su ultimo digito" + " |");
                Console.WriteLine("| El ultimo digito es: " + GetLastDigit(number) + "     |");


                if (IsFiveMultiple(number) && number < 30)
                {
                    Console.WriteLine("| El primer digito es : " + GetFirstDigit(number) + "    |");
                }

                Console.WriteLine("------------------------------");

            }

        }

        private void Exercise46(int number)
        {
            Console.WriteLine("Ejercicio numero 46");

            switch (GetLastDigit(number))
            {
                case 1:

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("| El ultimo digito es 1" + "  |");
                    Console.WriteLine("| Su primer digito es: " + GetFirstDigit(number) + " |");
                    Console.WriteLine("--------------------------");

                    break;

                case 2:
                    Console.WriteLine("ultimo digito 2");
                    break;

                case 3:
                    Console.WriteLine("ultimo digito 3");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }


        private void Exercise47()
        {

        }

        private bool IsEven(int n) => (n % 2 == 0) ? true : false;

        private void PrintEvenNumber(int number)
        {

            Console.WriteLine("--------------------------");

            Console.WriteLine("| Es par, suma de digitos| ");
            Console.WriteLine("| Primer digito: " + GetFirstDigit(number) + "       |");
            Console.WriteLine("| Segundo digito: " + GetLastDigit(number) + "      |");
            Console.WriteLine("| Suma de digitos = " + (GetFirstDigit(number) + GetLastDigit(number)) + "      |");

            Console.WriteLine("--------------------------");

        }

        private bool IsPrime(int number)
        {
            for (int i = 2; i < 2; i++)
            {
                return (number % i == 0) ? false : true;
            }
            return true;
        }

        private int GetLastDigit(int number)
        {
            return number % 10;
        }

        private int GetFirstDigit(int number)
        {
            return number / 10;
        }

        private bool IsFiveMultiple(int number) => (number % 5 == 0) ? true : false;

        //Chapter7
        static void Main(string[] args)
        {
            Program p = new Program();
        }

    }

}

