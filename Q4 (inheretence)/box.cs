//Hoda Khier + Yusef Aborokon 44/5
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4__inheretence_
{
    class box
    {
        //תכונות של מחלקה
        private float Length;
        private float hight;
        private float width;
        private string color;


       
        //בנאי מקבל ערכים 
        public box()
        {
            this.Length = 0;
            this.hight = 0;
            this.width = 0;
            this.color = "white";
        }
        


        public override bool Equals(Object obj)//פונקצייה משווה בין שני אובייקטים
        {
            if (obj is box)
            {
                box b;
                b = (box)obj;
                if (this.area_calculate() == b.area_calculate())
                {
                    return true;
                }
                else
                return false;
            }
            else
                return false; 
        }



        public float area_calculate()//שיטה לחישוב שטח של קופסה
        {
            return (float)(2 * (width * Length) + 2 * (width * hight) + 2 * (Length * hight));
        }

        public float capacity_calculate()//שיטה לחישוב נפח של קופסה
        {
            return (float)(Length * width * hight);
        }

        
        public void set_length(float length)
        {
            this.Length = length;
        }

        public void set_hight(float hight)
        {
            this.hight = hight;
        }
        public void set_width(float width)
        {
            this.width = width;
        }
        public void set_color(string color)
        {
            this.color = color;
        }


        public float get_length()
        {
            return this.Length;
        }

        public float get_hight()
        {
            return this.hight;
        }
        public float get_width()
        {
            return this.width;
        }
        public string get_color()
        {
            return this.color;
        }


    }


}

