using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuanHoaChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            string standardizedName="";

            Console.Write("Enter your name: ");
            fullName = Console.ReadLine();

            // "Trim whitespace at the beginning and end."
            fullName = fullName.Trim();

            //"Replace double spaces with a single space."
            while(fullName.IndexOf("  ") != -1)
            {
                fullName = fullName.Replace("  ", " ");
            }

            string[] subName = fullName.Split(' ');
            for(int i = 0; i < subName.Length; i++)
            {
                subName[i] = subName[i].Substring(0, 1).ToUpper() +
                             subName[i].Substring(1).ToLower();
                standardizedName += subName[i] + " ";
            }

            Console.WriteLine("If your name were to be standardized: " + standardizedName);

            Console.ReadKey();
        }
    }
}
