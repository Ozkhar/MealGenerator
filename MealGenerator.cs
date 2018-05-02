using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            public void DishOfTheDay()
			{
        
				Random rnd = new Random();
				string[] dishes = new string[] { "Rice", "Fish", "Beef", "Chicken", "Pasta", "Cream", "Korean", "Dumplings" };

				int index = rnd.Next(dishes.Length);            

				Console.WriteLine("Suggested dish for today");
				Console.WriteLine(dishes[index]);      
			}			
        
        }
    }
}
