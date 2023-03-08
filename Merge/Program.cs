using System;

namespace Merge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);

            //Beta add Run()
            ruler.Run();
        }
    }

    //Alpha Ruler add
    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            //{Gamma 2023.03.08 private SetInch 함수를 새로 추가/ Gamma
            private set { this.SetInch(value); }

        }
        public Ruler(int Value) { Centimeter = Value; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm는 {this.Inch}inch 입니다.");
        }

        private void SetInch(float inchValue) { Centimeter = (int)(inchValue / ONE_INCH); }
        //}Gamma 2023.03.08 private SetInch 함수를 새로 추가/ Gamma

    }
}