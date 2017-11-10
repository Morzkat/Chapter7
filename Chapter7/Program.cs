using System;

namespace Chapter7
{
    class Program
    {
        public Program()
        {
            int number = 10;
            Console.WriteLine("Si se introduce un numero con mas o con menos de 2 digitos el programa se cerrara");
            Console.WriteLine("Numero entre 10 y 99");
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
                        Exercise47();
                        break;
                    case 48:
                        Exercise48(number);
                        break;
                    case 49:
                        Exercise49();
                        break;
                    case 50:
                        Exercise50();
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


                if (IsMultipleOf(number, 5) && number < 30)
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

                    Console.WriteLine("----------------------------");
                    Console.WriteLine("| El ultimo digito es 2" + "    |");
                    Console.WriteLine("| Suma de los 2 digitos: " + (GetFirstDigit(number) + GetLastDigit(number)) + " |");
                    Console.WriteLine("----------------------------");
                    
                    break;

                case 3:
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("| El ultimo digito es 3" + "            |");
                    Console.WriteLine("| El producto de los 2 digitos: " + (GetFirstDigit(number) * GetLastDigit(number)) + " |");
                    Console.WriteLine("------------------------------------");

                    break;

                default:
                    Console.WriteLine("Debe ser un numero que termine en '1', '2' o '3'");
                    break;
            }
        }


        private void Exercise47()
        {
            Console.WriteLine("Ejercicio numero 47");

            Console.WriteLine("Primer numero");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo numero");
            int number2 = Int32.Parse(Console.ReadLine());

            int result = number1 - number2;

            if (IsEven(result))
            {
                Console.WriteLine("Suma de los 2 numeros: " + (number1 + number2));
            }

            else if (IsPrime(result) && result < 10)
            {
                Console.WriteLine("Producto de los 2 numeros: " + (number1 * number2));

            }
            //Will never be true because if last digit is 4 means is even 
            else if (GetLastDigit(result) == 4)
            {
                Console.WriteLine("" + GetFirstDigit(result) + " ------ " + GetLastDigit(result) + " ------ ");

            }
        }

        private void Exercise48(int number)
        {
            Console.WriteLine("Ejercicio 48");

            if (IsPrime(number))
            {
                Console.WriteLine("Es un numero primo");
            }

            else
            {
                Console.WriteLine("No es un numero primo");
            }
        }

        private void Exercise49()
        {
            Console.WriteLine("Ejercicio 49");
            Console.WriteLine("Introduce un numero entero");
            int number = Int32.Parse(Console.ReadLine());

            if (IsMultipleOf(number,4))
            {
                Console.WriteLine("El numero es multiplo de 4");

                if (IsPrime(GetLastDigit(number)))
                {
                    Console.WriteLine("El ultimo digito es primo");
                }
            }
        }

        private void Exercise50()
        {
            Console.WriteLine("Ejercicio 50");
            Console.WriteLine("Introduce un numero entero");
            int number = Int32.Parse(Console.ReadLine());

            if (IsMultipleOf(number, 4))
            {
                Console.WriteLine("La mitad de: " + number + "es: " + (number / 2));
            }

            else if (IsMultipleOf(number, 5))
            {
                Console.WriteLine("El cuadrado del numero es: " + (number * number));
            }

            else if (IsMultipleOf(number, 6))
            {
                Console.WriteLine("Su primer digito es: " + GetFirstDigit(number));
            }
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
            for (int i = 3; i < number; i++)
            {
                if (number % i == 0) return false;
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

        private bool IsMultipleOf(int number, int multipleOf) => (number % multipleOf == 0) ? true : false;

        //Chapter7
        static void Main(string[] args)
        {
            Program p = new Program();
        }

    }

}

