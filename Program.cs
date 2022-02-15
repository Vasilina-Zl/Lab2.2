using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conventer stconventer = new Conventer();

            stconventer.purchaseUSD = 27.8500;
            stconventer.saleUSD = 28.0500;

            stconventer.purchaseEUR = 31.7150;
            stconventer.saleEUR = 32.0500;

            stconventer.purchaseRUB = 0.3570;
            stconventer.saleRUB = 0.3720;

            double compareSum = 0;
            string changeFromStr, changeToStr;
            string cycleCondition = "";



            while (cycleCondition != "exit")
            {
                Console.Clear();
                Console.WriteLine("Конвертер валют\n");




                Console.SetCursorPosition(13, 2);
                Console.WriteLine("Поточний курс валют:\n");
                Console.WriteLine($"Продати USD: {stconventer.saleUSD} RUB, "
                    + $"Купити USD: {stconventer.purchaseUSD} RUB\n"
                    + $"Продати EUR: {stconventer.saleEUR} RUB, "
                    + $"Купити EUR: {stconventer.purchaseEUR} RUB\n"
                    + $"Продати RUB: {stconventer.saleRUB} RUB, "
                    + $"Купити RUB: {stconventer.purchaseRUB} RUB\n");


                Console.Write("Яку валюту бажаєте помiняти?\n" +
                         "1-гривнi, 2-долари, 3-євро, 4-рублi: ");
                changeFromStr = Console.ReadLine();

                Console.Write("Введiть суму для обмiну: ");
                double changeSum = Convert.ToDouble(Console.ReadLine());

                
                
                stconventer.Calculate(changeFromStr, changeSum);
               

                Console.Clear();
                Console.WriteLine($"Обмiн зроблено.\n" +
                    $"У Вас {Math.Round(stconventer.compareSum, 2)}");

                Console.WriteLine("Для продовження натиснiть Enter,\n" +
                    "для виходу з програми введiть exit i натиснiть Enter");

                cycleCondition = Console.ReadLine();
            }
        }
    }
}

