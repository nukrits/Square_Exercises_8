using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Exercises_8
{
   public  class Square : Rectangle
    {
        public Square (double lenght,double width) : base(lenght, width) 
        {

        }
        public void GetSquareArea()
        {
            Console.WriteLine(length * width);
        }
    }
}
