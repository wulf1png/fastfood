using System;
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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

 

        private void Button1_Click(object sender, EventArgs e)
        {
            form1 frm = new form1();
            form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close(); ;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
              form1 frm = new form1();
            form1.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close(); ;
        }
    }
}
