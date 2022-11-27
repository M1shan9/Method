using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы
{
    internal class Program
    {//№1
     // метод принимает два целых числа и сумму 
     static int Sum(int aFirst, int aSecond)
     {
      return aFirst + aSecond;
     }
   static void Main(string[] args)
        {
         // Вызываем метод с фактичискими параметрами 
         int result = Sum(24, 6);
         // Выводим результат в консоль
         Console.WriteLine("Summ nembers = " + result);
         



         float a, b, multiply;

         Console.WriteLine("write first number");
         a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("write second number");
         b = Convert.ToInt32(Console.ReadLine());

         multiply = a * b;
         Console.WriteLine("result: " + multiply);
  }
         private void Multy(float multyply)
  {
         Console.WriteLine(+multyply);
         Console.ReadKey();
  }
  

 
    }
}


 


        
