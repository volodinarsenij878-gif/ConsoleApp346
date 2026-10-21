using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program186
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Курс (1–4): ");
            if (!int.TryParse(Console.ReadLine(), out int course) || course < 1 || course > 4)
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string status;
            switch (course)
            {
                case 1: status = "Первокурсник"; break;
                case 2: status = "Второй курс"; break;
                case 3: status = "Предвыпускной курс"; break;
                case 4: status = "Выпускник"; break;
                default: return;
            }
            Console.WriteLine(status);
        }
    }
}