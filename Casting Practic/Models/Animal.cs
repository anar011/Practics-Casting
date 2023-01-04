using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Practic.Models
{
    public class Animal
    {

        public Animal()
        {
            Console.WriteLine("Animal constructor ");

        }


        public void Test()
        {
            Console.WriteLine("Animal test");
        }
        public string Name  { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }


    }
}
