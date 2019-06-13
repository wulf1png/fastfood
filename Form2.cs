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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Form2.ActiveForm.Hide();
            form1 MyForm1 = new form1();
            MyForm1.ShowDialog();
            Close(); 
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "Лонгер Обычный";
            dataGridView1.Rows[n].Cells[1].Value = "50 рублей";
            dataGridView1.Rows[n].Cells[2].Value = DateTime.Today.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "Лонгер с ветчиной";
            dataGridView1.Rows[n].Cells[1].Value = "60 рублей";
            dataGridView1.Rows[n].Cells[2].Value = DateTime.Today.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString(); 
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "Лонгер с сыром";
            dataGridView1.Rows[n].Cells[1].Value = "55 рублей";
            dataGridView1.Rows[n].Cells[2].Value = DateTime.Today.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "Лонгер full";
            dataGridView1.Rows[n].Cells[1].Value = "79 рублей";
            dataGridView1.Rows[n].Cells[2].Value = DateTime.Today.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
                try
                {
                    DataSet ds = new DataSet(); 
                    DataTable dt = new DataTable(); 
                    dt.TableName = "Datasave"; 
                    dt.Columns.Add("Longer"); 
                    dt.Columns.Add("Price");
                    dt.Columns.Add("Data");
                    ds.Tables.Add(dt); 

                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        DataRow row = ds.Tables["Datasave"].NewRow();
                        row["Longer"] = r.Cells[0].Value;
                        row["Price"] = r.Cells[1].Value;
                        row["Data"] = r.Cells[2].Value;
                        ds.Tables["Datasave"].Rows.Add(row);
                    }
                    ds.WriteXml("C:\\Datasave.xml");
            
                    MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }
        }
    }
}
