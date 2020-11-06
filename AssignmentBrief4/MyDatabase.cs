using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBrief4
{
    class MyDatabase
    {
        public List<TShirt> TShirts { get; set; } = new List<TShirt>();


        public MyDatabase()
        {
            TShirt t1 = new TShirt(Color.ORANGE, Size.L, Fabric.COTTON);
            TShirt t2 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt t3 = new TShirt(Color.RED, Size.XL, Fabric.LINEN);
            TShirt t4 = new TShirt(Color.ORANGE, Size.M, Fabric.COTTON);
            TShirt t5 = new TShirt(Color.INDIGO, Size.XXL, Fabric.RAYON);
            TShirt t6 = new TShirt(Color.YELLOW, Size.XS, Fabric.LINEN); 
            TShirt t7 = new TShirt(Color.VIOLET, Size.S, Fabric.POLYESTER);
            TShirt t8 = new TShirt(Color.BLUE, Size.XXXL, Fabric.RAYON);
            TShirt t9 = new TShirt(Color.ORANGE, Size.XS, Fabric.SILK);
            TShirt t10 = new TShirt(Color.BLUE, Size.M, Fabric.WOOL);
            TShirt t11 = new TShirt(Color.BLUE, Size.L, Fabric.LINEN);
            TShirt t12 = new TShirt(Color.RED, Size.S, Fabric.COTTON);
            TShirt t13 = new TShirt(Color.YELLOW, Size.S, Fabric.POLYESTER);
            TShirt t14 = new TShirt(Color.INDIGO, Size.XS, Fabric.SILK);
            TShirt t15 = new TShirt(Color.INDIGO, Size.XXXL, Fabric.COTTON);
            TShirt t16 = new TShirt(Color.GREEN, Size.L, Fabric.WOOL);
            TShirt t17 = new TShirt(Color.VIOLET, Size.S, Fabric.RAYON);
            TShirt t18 = new TShirt(Color.YELLOW, Size.M, Fabric.SILK);
            TShirt t19 = new TShirt(Color.RED, Size.M, Fabric.WOOL);
            TShirt t20 = new TShirt(Color.GREEN, Size.M, Fabric.COTTON);
            TShirt t21 = new TShirt(Color.ORANGE, Size.M, Fabric.LINEN);
            TShirt t22= new TShirt(Color.BLUE, Size.M, Fabric.RAYON);
            TShirt t23= new TShirt(Color.INDIGO, Size.XL, Fabric.POLYESTER);
            TShirt t24= new TShirt(Color.GREEN, Size.L, Fabric.WOOL);
            TShirt t25= new TShirt(Color.ORANGE, Size.XL, Fabric.LINEN);
            TShirt t26= new TShirt(Color.RED, Size.S, Fabric.RAYON);
            TShirt t27= new TShirt(Color.VIOLET, Size.XXL, Fabric.SILK);
            TShirt t28= new TShirt(Color.INDIGO, Size.XS, Fabric.POLYESTER);
            TShirt t29= new TShirt(Color.ORANGE, Size.XL, Fabric.CASHMERE);
            TShirt t30= new TShirt(Color.BLUE, Size.XS, Fabric.LINEN);
            TShirt t31= new TShirt(Color.VIOLET, Size.XXXL, Fabric.RAYON);
            TShirt t32= new TShirt(Color.GREEN, Size.XXL, Fabric.SILK);
            TShirt t33= new TShirt(Color.INDIGO, Size.XL, Fabric.WOOL);
            TShirt t34= new TShirt(Color.RED, Size.S, Fabric.POLYESTER);
            TShirt t35= new TShirt(Color.GREEN, Size.M, Fabric.CASHMERE);
            TShirt t36= new TShirt(Color.YELLOW, Size.XS, Fabric.RAYON);
            TShirt t37= new TShirt(Color.BLUE, Size.XL, Fabric.WOOL);
            TShirt t38= new TShirt(Color.ORANGE, Size.M, Fabric.COTTON);
            TShirt t39= new TShirt(Color.ORANGE, Size.XL, Fabric.POLYESTER);
            TShirt t40= new TShirt(Color.ORANGE, Size.XS, Fabric.LINEN);

            TShirts.Add(t1);
            TShirts.Add(t2);
            TShirts.Add(t3);
            TShirts.Add(t4);
            TShirts.Add(t5);
            TShirts.Add(t6);
            TShirts.Add(t7);
            TShirts.Add(t8);
            TShirts.Add(t9);
            TShirts.Add(t10);
            TShirts.Add(t11);
            TShirts.Add(t12);
            TShirts.Add(t13);
            TShirts.Add(t14);
            TShirts.Add(t15);
            TShirts.Add(t16);
            TShirts.Add(t17);
            TShirts.Add(t18);
            TShirts.Add(t19);
            TShirts.Add(t20);
            TShirts.Add(t21);
            TShirts.Add(t22);
            TShirts.Add(t23);
            TShirts.Add(t24);
            TShirts.Add(t25);
            TShirts.Add(t26);
            TShirts.Add(t27);
            TShirts.Add(t28);
            TShirts.Add(t29);
            TShirts.Add(t30);
            TShirts.Add(t31);
            TShirts.Add(t32);
            TShirts.Add(t33);
            TShirts.Add(t34);
            TShirts.Add(t35);
            TShirts.Add(t36);
            TShirts.Add(t37);
            TShirts.Add(t38);
            TShirts.Add(t39);
            TShirts.Add(t40);
                       
        }
    }
}
