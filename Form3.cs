using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            Form3.ActiveForm.Hide();
            form1 MyForm1 = new form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Очистите поле перед загрузкой нового файла.", "Ошибка.");
            }
            else
            {
                if (File.Exists("C:\\FastFood.xml"))
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml("C:\\FastFood.xml");

                    foreach (DataRow item in ds.Tables["FastFood"].Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item["Longer"];
                        dataGridView1.Rows[n].Cells[1].Value = item["Price"];
                        dataGridView1.Rows[n].Cells[2].Value = item["Data"];
                    }
                }
                else
                {
                    MessageBox.Show("XML файл не найден.", "Ошибка.");
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблица пустая.", "Ошибка.");
            }
        }

       

        private void Button5_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            double x = 0.001;
            const int N = 1000;
            for (int i = 1; i < N; i++)
            {
                double y = (x - 0.0) * (x - 0.0);
                chart1.Series[0].Points.AddXY(x, y);
                x = x + 0.001;
            }
        }

    }

}


        
    

    


