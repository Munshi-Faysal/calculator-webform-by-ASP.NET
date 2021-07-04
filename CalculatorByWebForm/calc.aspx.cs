using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorByWebForm
{
    public partial class calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 0;
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 1;
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 2;
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 3;
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 4;
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 5;
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 6;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 7;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            
            TextBox1.Text = TextBox1.Text + 8;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 9;
        }
        //Clear
        protected void Button3_Click(object sender, EventArgs e)
        {
            
            TextBox1.Text = "";
        }
      
        //Add Button
        protected void Button16_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "+";
        }
        //sub button
        protected void Button12_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "-";
        }
        //MUl Button
        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "*";
        }
        //Division Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "/";
        }
        //Equal
        protected void Button19_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text.Contains("+"))
            {
                int sum = 0;
                var numbers = TextBox1.Text.Split('+').Select(Int32.Parse).ToList();
                TextBox1.Text = "";
                foreach (var s in numbers)
                {
                    sum = sum + s;

                }
                TextBox1.Text = TextBox1.Text + sum;
            }
            else if(TextBox1.Text.Contains("-"))
            {
                //int sub = 0;
                var numbers = TextBox1.Text.Split('-').Select(Int32.Parse).ToList();
                TextBox1.Text = "";
                int sub = numbers[0] - numbers[1];
                
                TextBox1.Text = TextBox1.Text + sub;
            }
            else if (TextBox1.Text.Contains("*"))
            {
                int sub = 1;
                var numbers = TextBox1.Text.Split('*').Select(Int32.Parse).ToList();
                TextBox1.Text = "";
                foreach (var s in numbers)
                {
                    sub = sub * s;

                }
                TextBox1.Text = TextBox1.Text + sub;
            }
            else
            {
                //int sub = 1;
                var numbers = TextBox1.Text.Split('/').Select(float.Parse).ToList();
                TextBox1.Text = "";
                float res = numbers[0] / numbers[1];
                TextBox1.Text = TextBox1.Text + res;
            }




        }
        //ON Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            enable();
        }
        //OFF Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            disable();
        }

        //user defined function
        public void enable()
        {
            Button1.Enabled = false;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            Button10.Enabled = true;
            Button11.Enabled = true;
            Button12.Enabled = true;
            Button13.Enabled = true;
            Button14.Enabled = true;
            Button15.Enabled = true;
            Button16.Enabled = true;
            Button17.Enabled = true;
            Button18.Enabled = true;
            Button19.Enabled = true;

        }
        public void disable()
        {
            Button1.Enabled = true;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
            Button10.Enabled = false;
            Button11.Enabled = false;
            Button12.Enabled = false;
            Button13.Enabled = false;
            Button14.Enabled = false;
            Button15.Enabled = false;
            Button16.Enabled = false;
            Button17.Enabled = false;
            Button18.Enabled = false;
            Button19.Enabled = false;

        }
    }

        
}