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

namespace Read_Write_ExcelFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            String textFile = "C:\\Users\\Public\\Desktop\\csv_data.csv";

            using (StreamWriter file = new StreamWriter(textFile))
            {
                for (double x = 0; x < lb_1.Items.Count; x++)
                    file.WriteLine(lb_1.Items.ToString());
                file.Close();
            }
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            lb_1.Items.Add(tb_input.Text);
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            String textFile;
            textFile = "C:\\Users\\Public\\Desktop\\csv_data.csv"; 

            using (StreamReader file = new StreamReader(textFile))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    lb_1.Items.Add(ln);
                }
                file.Close();

                
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double sum, ans1;
            ans1 = 0;
            sum = 0;
            for (double x = 0; x < lb_1.Items.Count; x++)
                ans1 = sum + double.Parse(lb_1.Text);
            lb_sum.Text = ans1.ToString();
        }
    }
}

