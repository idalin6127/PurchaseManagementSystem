using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ling_A1
{
    internal class Program
    {
        /* Project Name: Purchase Management System
         */

        static void Main(string[] args)
        {
            Purchase purchase1 = new Purchase(ProductCategory.Miscellaneous, 5);
            Purchase purchase2 = new Purchase(ProductCategory.Electronics);
            purchase1.CalculateCost();
            purchase2.CalculateCost();
            Console.WriteLine($"{purchase1.ToString()}");
            Console.WriteLine($"{purchase2.ToString()}");

        }
    }



    enum ProductCategory
    {

        Grocery, Electronics, Beverages, CleaningSupplies, Miscellaneous
    }

    class Purchase
    {
        public static int PURCHASE_ID=1;
        public ProductCategory Category;
        public int Quantities;
        public double Cost;
        public int P_ID = 0;

        public Purchase(ProductCategory Category, int quantities=1)
        {
            this.Category = Category;
            this.Quantities = quantities;
            Cost = 0;
            P_ID = PURCHASE_ID;

            PURCHASE_ID++;

        }

        public void CalculateCost()
        {
            //double Totalprice = Category * Quantities
                double price = 0, discount = 0;

        switch(Category)
            {
                case ProductCategory.Miscellaneous:
                    price = 20;
                    discount = 0;
                    break;
                case ProductCategory.Electronics:
                    price = 15;
                    discount = 0.1;
                    break;
                case ProductCategory.Beverages:
                    price = 10;
                    discount = 0.05;
                    break;
                case ProductCategory.CleaningSupplies:
                    price = 5;
                    discount = 0.15;
                    break;
                case ProductCategory.Grocery:
                    price = 1;
                    discount = 0.2;
                    break;
            }
            Cost = (price * Quantities) * (1 - discount) * (1 + 0.13);
        }

        public override string ToString()
        {
            return $"PURCHASE_ID: {P_ID},  Category: {Category},  Quantities: {Quantities}   Cost: {Cost}";
        }

    }


}
