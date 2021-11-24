using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Discount
    {
         static void Main(string[] args)
         {
            Console.WriteLine("Take into account that the program rounds the figure in decimal");
        Console.WriteLine("Quantity");
        int buy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Discount");
            int discount = Convert.ToInt16(Console.ReadLine());

        int total;
        total = buy * discount / 100;
        

        Console.WriteLine("Full payment: " + total);

        Console.ReadKey();
            


         }
    }
    
 }