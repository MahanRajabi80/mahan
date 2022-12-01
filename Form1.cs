using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            byte age = Convert.ToByte(txtAge.Text);
            long sal_base = Convert.ToInt64(txtSal.Text);
            long sal;
            if (age <= 20)
                sal = sal_base - 5 * sal_base / 100 + 10000;
            else if (age > 20 && age <= 30)
                sal = sal_base - 5 * sal_base / 100 + 20000;
            else
                sal = sal_base - 5 * sal_base / 100 + sal_base;
            sal *= 12;
            MessageBox.Show("Salary 12 Month=" + sal.ToString());
        }
    }
}
