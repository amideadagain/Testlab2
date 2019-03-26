using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlab2
{
    class Eqtrig
    {
        public double linelenght;
        public double area;

        public void Input()
        {
            Console.WriteLine("Please input a Lenght");
            this.linelenght = Convert.ToDouble(Console.ReadLine());
        }
        public void output()
        {
            area = Math.Pow(linelenght, 3);
            Console.WriteLine("Perimeter =" + linelenght * 3);
            Console.WriteLine("Area =" + Math.Pow(linelenght, 3));
        }
        public class RightTriPRISMABEACH : Eqtrig
        {
            double SiegeHail;
            public double OBbEM;
            public void Calculate()
            {
                OBbEM = area* SiegeHail;
                
            }
            public void input()
            {
                Console.WriteLine("Please input a Height");
                this.SiegeHail = Convert.ToDouble(Console.ReadLine());
            }
            public void  output(double OBbEM)
            {
                Console.WriteLine("Height =" + SiegeHail);
                Console.WriteLine("OBbEM =" + OBbEM);
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Eqtrig eqtrig = new Eqtrig();
            Eqtrig.RightTriPRISMABEACH prisma = new Eqtrig.RightTriPRISMABEACH();
            eqtrig.Input();
            eqtrig.output();
            prisma.input();
            prisma.Calculate();
            Console.WriteLine();
            prisma.output(prisma.OBbEM);
            Console.ReadKey();
        }
    }
    
}
