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
    }
}
