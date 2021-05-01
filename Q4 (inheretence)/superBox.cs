//Hoda Khier + Yusef Aborokon 44/5
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4__inheretence_
{
    class superBox : box
    {
        private box sb;
        private float weight;

        //שיטה סטטית מקבלת ערכים ומחזירה אמת אם הערכים תואמים ושקר אם לא
        public static Boolean checkSuper(decimal length, decimal hight, decimal width, decimal weight)
        {
            if (hight <= 3 && length <= 3 && width <= 3 && weight <=150)
            {
                return true;
            }
            else
                return false;
        }

        public superBox()//בנאי
        {
            this.sb = new box();
            this.weight = 0;
        }

        public override string ToString()//פונקצייה מדפיסה את ממדים של הקופסה
        {
            return "Type : SuperBox\nLength :" + this.sb.get_length() + "\nHight : " + this.sb.get_hight() + "\nWidth : " + this.sb.get_width();
        }

        //setters ans getters
        public void Set_length(float length)
        {
            this.sb.set_length(length);
        }

        public void Set_hight(float hight)
        {
            this.sb.set_hight(hight);
        }

        public void Set_width(float width)
        {
            this.sb.set_width(width);
        }

        public void Set_color(string color)
        {
            this.sb.set_color(color);
        }

        public void Set_weight(float weight)
        {
            this.weight= weight;
        }


        public float Get_length()
        {
            return this.sb.get_length();
        }

        public float Get_hight()
        {
            return this.sb.get_hight();
        }

        public float Get_width()
        {
            return this.sb.get_width();
        }

        public string Get_color()
        {
            return this.sb.get_color();
        }

        public float Get_weight()
        {
            return this.weight;
        }


    }
}
