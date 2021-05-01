//Hoda Khier + Yusef Aborokon 44/5
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Q4__inheretence_
{
    class miniBox:box
    {

        private box mb;

        //שיטה סטטית מקבלת ערכים ומחזירה אמת אם הערכים תואמים ושקר אם לא
        public static bool checkMini(decimal length, decimal hight, decimal width)
        {
            if ((float)hight <= 0.5 && (float)length <= 0.5 && (float)width <= 0.5)
            {
                return true;
            }
            else
                return false;
        }


        public miniBox()//constractor
        {
            this.mb = new box();
        }


        public override string ToString()//פונקצייה מדפיסה את ממדים של הקופסה
        {
            return "Type : SuperBox\nLength :" + this.mb.get_length() + "\nHight : " + this.mb.get_hight() + "\nWidth : " + this.mb.get_width();
        }


        //setters and gettters
        public void set_length(float length)
        {
            this.mb.set_length(length);
        }

        public void set_hight(float hight)
        {
            this.mb.set_hight(hight);
        }
        public void set_width(float width)
        {
            this.mb.set_width(width);
        }
        public void set_color(string color)
        {
            this.mb.set_color(color);
        }


        public float get_length()
        {
            return this.mb.get_length();
        }

        public float get_hight()
        {
            return this.mb.get_hight();
        }
        public float get_width()
        {
            return this.mb.get_width();
        }
        public string get_color()
        {
            return this.mb.get_color();
        }
    }
}
