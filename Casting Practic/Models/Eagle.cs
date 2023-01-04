using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Practic.Models
{
    internal class Eagle : Bird
    {
        public int Speed { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Salmon sound");
        }

        public void Test()
        {
            Console.WriteLine("Eagle test");
        }



    }
}
