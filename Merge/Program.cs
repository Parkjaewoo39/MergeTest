using System;

namespace Merge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler();
        }
    }


    //Alpha Ruler add
    public class Ruler 
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; }
    }
}