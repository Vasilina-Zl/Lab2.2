using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    internal class Conventer
    {
        public double purchaseUSD;
        public double saleUSD;

        public double purchaseEUR;
        public double saleEUR;

        public double purchaseRUB;
        public double saleRUB;

        public double compareSum = 0;
        public string changeFromStr, changeToStr;
        public string cycleCondition = "";
        public double changeSum;


        public double Calculate(string cfs, double changeSum)
        {
            if (cfs == "1")
            {
               return If1(changeToStr, changeSum);
            }
            else if (cfs == "2")
            {
                compareSum = changeSum * saleUSD;
                return compareSum;
            }
            else if (cfs == "3")
            {
                compareSum = changeSum * saleEUR;
                return compareSum;
            }
            else if (cfs == "4")
            {
                compareSum = changeSum * saleRUB;
                return compareSum;
            }
            else
            {
                return 0;
            }
        }

        public double If1(string cts, double cs) 
        {
            Console.Write("Яку валюту бажаєте отримати?\n" +
                                   "1-долари, 2-євро, 3-рублi: ");
            changeToStr = Console.ReadLine();


            if (changeToStr == "1")
            {
                compareSum = cs / purchaseUSD;
                return compareSum;
            }
            else if (changeToStr == "2")
            {
                compareSum = cs / purchaseEUR;
                return compareSum;
            }
            else if (changeToStr == "3")
            {
                compareSum = cs / purchaseRUB;
                return compareSum;
            }
            else
            {
                return 0;
            }
        }
    }
}
