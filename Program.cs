
using System;

class Program
{
        
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Cześć tu kalkulator");

            Console.WriteLine("Podaj liczbę");


            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Jaką operacje chcesz wykonać?");

            var operation = Console.ReadLine();

            Console.WriteLine("Wpisz 2 liczbę");

            var number2 = int.Parse(Console.ReadLine());

            var result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;

                    break;
                case "-":
                    result = number1 - number2;
                    break;

                    break;
                case "*":
                    result = number1 * number2;
                    break;

                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("Wybrałeś złe operacje");

            }

            Console.WriteLine($"Wynik Twojego działania to: {result}.");
        }
        catch (Exception)
        {

            Console.WriteLine("Błąd");
        }

        

    }

}