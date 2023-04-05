using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace Project_Restaurant
{
    public partial class Menufood : Form
    {
        public string name;
        public int amount;
        public string size;
        public string spicy;
        public string meat;


        public Menufood()
        {
            InitializeComponent();
            comboBox7.Items.Add("เล็ก");
            comboBox7.Items.Add("กลาง");
            comboBox7.Items.Add("ใหญ่");
            comboBox8.Items.Add("เล็ก");
            comboBox8.Items.Add("กลาง");
            comboBox8.Items.Add("ใหญ่");
            comboBox9.Items.Add("ไก่");
            comboBox9.Items.Add("เนื้อ");
            comboBox10.Items.Add("ไก่");
            comboBox10.Items.Add("เนื้อ");
            comboBox11.Items.Add("ไก่");
            comboBox11.Items.Add("เนื้อ");
            comboBox12.Items.Add("เผ็ดน้อย");
            comboBox12.Items.Add("เผ็ดปานกลาง");
            comboBox12.Items.Add("เผ็ดมาก");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Menufood_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) >= 1)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                name = label3.Text;
                amount = Int32.Parse(this.textBox1.Text);
                size = comboBox7.Text;
                Foodsize foodsize = new Foodsize(name,amount, size);
                var message = $"{foodsize.getName()} จำนวน {foodsize.getAmount()} ถุง\nขนาด {foodsize.getSize()}";
                using (var package = new ExcelPackage(new FileInfo(@"C:\Users\poste\Desktop\ปปxx\Project Restaurant\Project Restaurant\bin\Debug\output.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet does not exist");
                    }
                    int lastUsedRow = worksheet.Dimension.End.Row;

                    ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                    cell.Value = message;

                    package.Save();
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MessageBox.Show(message);
            }
            if (Int32.Parse(textBox2.Text) >= 1)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                name = label4.Text;
                amount = Int32.Parse(this.textBox2.Text);
                size = comboBox8.Text;
                Foodsize foodsize = new Foodsize(name, amount, size);
                var message = $"{foodsize.getName()} จำนวน {foodsize.getAmount()} ถาด\nขนาด {foodsize.getSize()}";
                using (var package = new ExcelPackage(new FileInfo(@"C:\Users\poste\Desktop\ปปxx\Project Restaurant\Project Restaurant\bin\Debug\output.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet does not exist");
                    }
                    int lastUsedRow = worksheet.Dimension.End.Row;

                    ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                    cell.Value = message;

                    package.Save();
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MessageBox.Show(message);
            }
            if (Int32.Parse(textBox5.Text) >= 1)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                name = label5.Text;
                amount = Int32.Parse(this.textBox5.Text);
                size = comboBox9.Text;
                Foodsize foodsize = new Foodsize(name, amount, size);
                var message = $"{foodsize.getName()} จำนวน {foodsize.getAmount()} ชิ้น\nประเภท {foodsize.getSize()}";
                using (var package = new ExcelPackage(new FileInfo(@"C:\Users\poste\Desktop\ปปxx\Project Restaurant\Project Restaurant\bin\Debug\output.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet does not exist");
                    }
                    int lastUsedRow = worksheet.Dimension.End.Row;

                    ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                    cell.Value = message;

                    package.Save();
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MessageBox.Show(message);
            }
            if (Int32.Parse(textBox3.Text) >= 1)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                name = label6.Text;
                amount = Int32.Parse(this.textBox3.Text);
                size = comboBox10.Text;
                Foodsize foodsize = new Foodsize(name, amount, size);
                var message = $"{foodsize.getName()} จำนวน {foodsize.getAmount()} จาน\nประเภท {foodsize.getSize()}";
                using (var package = new ExcelPackage(new FileInfo(@"C:\Users\poste\Desktop\ปปxx\Project Restaurant\Project Restaurant\bin\Debug\output.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet does not exist");
                    }
                    int lastUsedRow = worksheet.Dimension.End.Row;

                    ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                    cell.Value = message;

                    package.Save();
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MessageBox.Show(message);
            }
            if (Int32.Parse(textBox4.Text) >= 1)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                name = label7.Text;
                amount = Int32.Parse(this.textBox4.Text);
                size = comboBox11.Text;
                Foodsize foodsize = new Foodsize(name, amount, size);
                var message = $"{foodsize.getName()} จำนวน {foodsize.getAmount()} ถ้วย\nประเภท {foodsize.getSize()}";
                using (var package = new ExcelPackage(new FileInfo(@"C:\Users\poste\Desktop\ปปxx\Project Restaurant\Project Restaurant\bin\Debug\output.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet does not exist");
                    }
                    int lastUsedRow = worksheet.Dimension.End.Row;

                    ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                    cell.Value = message;

                    package.Save();
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MessageBox.Show(message);
            }
            if (Int32.Parse(textBox6.Text) >= 1)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                name = label8.Text;
                amount = Int32.Parse(this.textBox6.Text);
                size = comboBox12.Text;
                Foodsize foodsize = new Foodsize(name, amount, size);
                var message = $"{foodsize.getName()} จำนวน {foodsize.getAmount()} จาน\nขนาด {foodsize.getSize()}";
                using (var package = new ExcelPackage(new FileInfo(@"C:\Users\poste\Desktop\ปปxx\Project Restaurant\Project Restaurant\bin\Debug\output.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet does not exist");
                    }
                    int lastUsedRow = worksheet.Dimension.End.Row;

                    ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                    cell.Value = message;

                    package.Save();
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MessageBox.Show(message);
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
            if (order.DialogResult == DialogResult.OK)
            {

            }
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
    }
}
