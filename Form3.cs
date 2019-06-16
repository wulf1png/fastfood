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
using ZedGraph;

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
                if (File.Exists("C:\\Datasave.xml"))
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml("C:\\Datasave.xml");

                    foreach (DataRow item in ds.Tables["Datasave"].Rows)
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

        private void Chart1_Click(object sender, EventArgs e)
        {


        }

        private void Button5_Click(object sender, EventArgs e)
        {
            zedGraph.GraphPane.CurveList.Clear();

            double x = 0, y = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    x = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    y = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                }
                catch (Exception)
                {
                    continue;
                }


                zedGraph.Invalidate();
                PointPairList f1_list = new PointPairList();


                f1_list.Add(x, y);
                LineItem f1_curve = zedGraph.GraphPane.AddCurve(" ", f1_list, System.Drawing.Color.Red);
                zedGraph.AxisChange();
                zedGraph.Invalidate();

            }

        }

    }

}
        
    

    


