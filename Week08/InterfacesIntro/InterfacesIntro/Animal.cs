using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Animal : IWalker
    {
        public int Height { get; set; }

        public double MaxSpeed { get; set; }

        public string Name { get; set; }

        public int NumLegs { get; set; }

        public double StrideLength { get; set; }


        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }

        public virtual void Speak()
        {

        }

        public void walk()
        {
            MessageBox.Show("I walk around with my " + NumLegs + " number of legs and have a stride length of " + StrideLength + ".");

        }
    }
}
