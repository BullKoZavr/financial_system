using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace financial_system
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void close_form1()
        {
            //Form1 form = new Form1();
            //form.Close();

            Close();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string pass = passBox.Text;

            if (login == "1" && pass == "1")
            {
                //Close();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Wrong login or pass!");
            }
        }
    }
}
