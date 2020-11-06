using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBrief4
{
    public class TShirt
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }


        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }


        public void Output() 
        {
            Console.WriteLine("{0 ,12} | {1,12} | {2,12}", Color, Size, Fabric);
        }
    }
  
}
