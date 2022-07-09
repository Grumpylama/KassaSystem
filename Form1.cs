using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(27, 33, 56);
            listBox1.BackColor = Color.FromArgb(37, 44, 72);
            listBox1.BackColor = Color.Gray;
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();

            


        }
    }
}
