using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaforSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//ZAČETNE VREDNOSTI
            redlightcar.Visible = true;//rdeča luč na avtu gori -- 
            orangelightcar.Visible = false;//oranžna luč na avtu ne gori
            greenlightcar.Visible = false;//zelena luč na avtu ne gori
            redlightfoot.Visible = false;//rdeča luč pešči ne gori
            greenlightfoot.Visible = true;//zelena luč pešči gori
        }
        
        //int a = 123;
        int cnt = -1;       //navadn count/števec
        int global = 0;     //1 - glih je bla rdeča; 2 - glih je bla zelena

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();     //Zapre program
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    //Minimira program
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;   //enabla timer
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //tuki šteje kolk sekund je minil
            cnt++;
            if (cnt % 5 == 0)
            {
                if (redlightcar.Visible == true)
                {


                    global = 1;
                    redlightcar.Visible = false;
                    orangelightcar.Visible = true;
                    greenlightcar.Visible = false;
                    redlightfoot.Visible = true;
                    greenlightfoot.Visible = false;
                }
                else if (greenlightcar.Visible == true)
                {
                    global = 2;
                    redlightcar.Visible = false;
                    orangelightcar.Visible = true;
                    greenlightcar.Visible = false;
                    redlightfoot.Visible = true;
                    greenlightfoot.Visible = false;
                }
            }
            else
            {
                if (orangelightcar.Visible == true)
                {
                    if (global == 1)
                    {
                        redlightcar.Visible = false;
                        orangelightcar.Visible = false;
                        greenlightcar.Visible = true;
                    }
                    else if (global == 2)
                    {
                        redlightcar.Visible = true;
                        orangelightcar.Visible = false;
                        greenlightcar.Visible = false;
                        redlightfoot.Visible = false;
                        greenlightfoot.Visible = true;
                    }
                }
            }
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
