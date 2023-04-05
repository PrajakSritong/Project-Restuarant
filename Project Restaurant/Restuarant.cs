using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Restaurant
{
    public partial class Restuarant : Form
    {
        public Restuarant()
        {
            InitializeComponent();
            

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
            
        }

        private void fastfoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menufood menufood = new Menufood();
            menufood.ShowDialog();
        }


        private void thaifoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menufood menufood = new Menufood();
            menufood.ShowDialog();
        }

        private void Restuarant_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menufood menufood = new Menufood();
            menufood.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }
    }
}
