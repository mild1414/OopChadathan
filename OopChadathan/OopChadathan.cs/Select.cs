using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChadathan.cs
{
    class Select
    {
       public void select()

        {
            Console.WriteLine("Choose the type of flower");
            Console.WriteLine("1.Rose");
            Console.WriteLine("2.Jasmine");
            Console.WriteLine("3.Sunflower");
            Console.WriteLine("4.Lotus");

            int.TryParse(Console.ReadLine(), out int flower);
            switch (flower)
            {
                case 1:
                    Rose ro = new Rose();
                    ro.color();
                    ro.Meaning();
                    break;
                case 2:
                    Jasmine jm = new Jasmine();
                    jm.color();
                    jm.Meaning();
                    break;
                case 3:
                    Sunflower sf = new Sunflower();
                    sf.color();
                    sf.Meaning();
                    break;
                case 4:
                    Lotus lt = new Lotus();
                    lt.color();
                    lt.Meaning();
                    break;
                default:
                    Console.WriteLine(" Please select");
                    break;
            }
        }
    }
}
