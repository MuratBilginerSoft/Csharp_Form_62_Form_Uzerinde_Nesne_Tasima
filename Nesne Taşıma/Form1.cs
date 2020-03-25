using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nesne_Taşıma
{
    public partial class Form1 : Form
    {

        #region Değişkenler

        bool sürükle = false;

        Point ilkkonum;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;

            button1.Cursor = Cursors.SizeAll;

            ilkkonum = e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükle==true)
            {
                button1.Left = e.X + button1.Left - (ilkkonum.X);

                button1.Top = e.Y + button1.Top - ilkkonum.Y;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;

            button1.Cursor = Cursors.Default;
        }
    }
}
