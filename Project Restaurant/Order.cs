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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Users\poste\Desktop\ปปxx\Project Restaurant\Project Restaurant\bin\Debug\output.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int lastUsedRow = worksheet.Dimension.End.Row;
                for (int row = 1; row <= lastUsedRow; row++)
                {
                    string value = worksheet.Cells[row, 1].Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.dataGridView1.Rows.Add(value);
                    }
                }

            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menufood menufood = new Menufood();
            menufood.ShowDialog();
        }
    }
}
