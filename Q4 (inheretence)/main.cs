//Hoda Khier + Yusef Aborokon 44/5
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4__inheretence_
{
    public partial class main : Form
    {
        superBox b1sb = new superBox();
        miniBox b1mb = new miniBox();
        superBox b2sb = new superBox();
        miniBox b2mb = new miniBox();

        

        public main()
        {
            InitializeComponent();
        }
        


        // שיטה שמקבלת כל הערכים שהמשתמש הקליד אחרי לחיצה על קבל מידע
        private void result_Click(object sender, EventArgs e)
        {
            if (Length.Value >= 0 && height.Value >= 0 && width.Value >= 0 && weight.Value >= 0)//בודקים אם המשתמש לא הקליד ערכים שליליים
            {
                if (Length.Value != 0 && height.Value != 0 && width.Value != 0)//בודקים אם המשתמש לא השאיר תא ריק
                {
                    if (weight.Value != 0)//בודקים אם המשתמש הקליד משקל
                    {
                        if (superBox.checkSuper(Length.Value, height.Value, width.Value, weight.Value))//בודקים במחלקה אם הקופסה היא מסוג גדול
                        {
                            int length = Convert.ToInt32(Length.Value);
                            int Hight = Convert.ToInt32(height.Value);
                            int Width = Convert.ToInt32(width.Value);
                            int Weight = Convert.ToInt32(weight.Value);

                            b1sb.Set_length(length);
                            b1sb.Set_hight(Hight);
                            b1sb.Set_width(Width);
                            
                            b1sb.Set_color(colorBox.Text);
                           
                            
                            
                            

                        }
                        else
                            screen.Text = "Invalid box";
                    }
                    else
                    {
                        if (miniBox.checkMini(Length.Value, height.Value, width.Value))//בודקים במחלקה אם הקופסה היא מסוג הקטן
                        {
                            int length = Convert.ToInt32(Length.Value);
                            int Hight = Convert.ToInt32(height.Value);
                            int Width = Convert.ToInt32(width.Value);
                            int Weight = Convert.ToInt32(weight.Value);

                            b2sb.Set_length(length);
                            b2sb.Set_hight(Hight);
                            b2sb.Set_width(Width);
                            b2sb.Set_color(colorBox.Text);


                        }
                        else
                            screen.Text = "Invalid box";
                    }
                    



                }
                else
                    MessageBox.Show("Please fill out this fields");
            }
            else
                MessageBox.Show("Invalid value");



            /*
            if (Length.Value >= 0 && height.Value >= 0 && width.Value >= 0 && weight.Value >= 0)//בודקים אם המשתמש לא הקליד ערכים שליליים
            {
                if (Length.Value != 0 && height.Value != 0 && width.Value != 0)//בודקים אם המשתמש לא השאיר תא ריק
                {
                    if (weight.Value != 0)//בודקים אם המשתמש הקליד משקל
                    {
                        if (weight.Value <= 150)//בודקים אם המשקל בטווח המתאים
                        {
                            if (superBox.checkSuper(Length.Value, height.Value, width.Value, weight.Value))//בודקים במחלקה אם הקופסה היא מסוג גדול
                            {
                                box b1 = new box(1, 1, 1, "red");
                                box b = new box(Length.Value, height.Value, width.Value, colorBox.Text);

                                float area = b.area_calculate();
                                float capacity = b.capacity_calculate();
                                screen.Text = "Type : SuperBox\n" + "Box's area : " + area + "\nBox's capacity : " + capacity + "\nColor : " + colorBox.Text +"true or false : "+ b.Equals(b1);//מדפיס את סוג הקופסה ואת כל החישובים לקופסה
                            }
                            else
                                screen.Text = "Invalid box";
                        }
                        else
                            screen.Text = "Invalid box";
                    }
                    else
                    {
                        if(miniBox.checkMini(Length.Value, height.Value, width.Value))//בודקים במחלקה אם הקופסה היא מסוג הקטן
                        {
                            box b = new box(Length.Value, height.Value, width.Value, colorBox.Text);
                            float area = b.area_calculate();
                            float capacity = b.capacity_calculate();
                            screen.Text = "Type : MiniBox\n" + "Box's area : " + area + "\nBox's capacity : " + capacity + "\nColor : " + colorBox.Text;//מדפיס את סוג הקופסה ואת כל החישובים לקופסה
                        }
                        else
                            screen.Text = "Invalid box";
                    }
                }
                else
                    MessageBox.Show("Please fill out this fields");

            }
           
             
            */

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            

                label9.Text =  b1sb.ToString();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (Length.Value >= 0 && height.Value >= 0 && width.Value >= 0 && weight.Value >= 0)//בודקים אם המשתמש לא הקליד ערכים שליליים
            {
                if (Length.Value != 0 && height.Value != 0 && width.Value != 0)//בודקים אם המשתמש לא השאיר תא ריק
                {
                    if (weight.Value != 0)//בודקים אם המשתמש הקליד משקל
                    {
                        if (superBox.checkSuper(Length.Value, height.Value, width.Value, weight.Value))//בודקים במחלקה אם הקופסה היא מסוג גדול
                        {
                            int length = Convert.ToInt32(Length.Value);
                            int Hight = Convert.ToInt32(height.Value);
                            int Width = Convert.ToInt32(width.Value);
                            int Weight = Convert.ToInt32(weight.Value);

                            b2sb.Set_length(length);
                            b2sb.Set_hight(Hight);
                            b2sb.Set_width(Width);
                            b2sb.Set_weight(Weight);
                            b2sb.Set_color(colorBox.Text);

                        }
                        else
                            screen.Text = "Invalid box";
                    }
                    else
                    {
                        if (miniBox.checkMini(Length.Value, height.Value, width.Value))//בודקים במחלקה אם הקופסה היא מסוג הקטן
                        {
                            int length = Convert.ToInt32(Length.Value);
                            int Hight = Convert.ToInt32(height.Value);
                            int Width = Convert.ToInt32(width.Value);
                            int Weight = Convert.ToInt32(weight.Value);

                            b2mb.set_length(length);
                            b2mb.set_hight(Hight);
                            b2mb.set_width(Width);
                            b2mb.set_color(colorBox.Text);


                        }
                        else
                            screen.Text = "Invalid box";
                    }


                }
                else
                    MessageBox.Show("Please fill out this fields");
            }
            else
                MessageBox.Show("Invalid value");
        }
    }
}
