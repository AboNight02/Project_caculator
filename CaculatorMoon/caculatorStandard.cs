using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculatorMoon
{
    public partial class caculatorStandard : UserControl
    {
        double EnterFirst, EnterSecond,Show;
        string op;

        public void Click_Number(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button num = (Guna.UI2.WinForms.Guna2Button)sender;
            if (TxtOut.Text == "0")
                TxtOut.Text = "";
            {
                if (num.Text == ".")
                {
                    // this is mean if numbers have also one dot you cant add dot again 
                    if (!TxtOut.Text.Contains(".")) TxtOut.Text += num.Text;
                }
                else TxtOut.Text += num.Text;

            }
        }
        public caculatorStandard()
        {
            InitializeComponent();
        }

        private void caculatorStandard_Load(object sender, EventArgs e)
        {

        }

        private void click_num(object sender, EventArgs e)
        {
            Click_Number(sender, e);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            TxtOut.Text = "0";
            TxtShow.Text = "0";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            TxtOut.Text = "0";
            string F, S;
            F = Convert.ToString(EnterFirst);
            S = Convert.ToString(EnterSecond);
            F = ""; S = "";
        }

        private void PM_butt_Click(object sender, EventArgs e)
        {
            double PM = Convert.ToDouble(TxtOut.Text);
            TxtOut.Text = Convert.ToString(-1 * PM); 

        }

        private void Back_butt_Click(object sender, EventArgs e)
        {
            if (TxtOut.Text.Length > 0) TxtOut.Text = TxtOut.Text.Remove(TxtOut.Text.Length - 1, 1);
            if (TxtOut.Text == "") TxtOut.Text = "0";
        }

        private void sq_Click(object sender, EventArgs e)
        {
            TxtOut.Text = Math.Sqrt(Convert.ToDouble(TxtOut.Text)).ToString();
        }

        private void P_but_Click(object sender, EventArgs e)
        {
            TxtOut.Text = Math.Pow(Convert.ToDouble(TxtOut.Text), 2).ToString();

        }

        private void x1_Click(object sender, EventArgs e)
        {
            TxtOut.Text =(1/Convert.ToDouble(TxtOut.Text)).ToString();
        }

        private void Prcent_Click(object sender, EventArgs e)
        {
            TxtOut.Text = (Convert.ToDouble(TxtOut.Text) / 100).ToString();
        }

        private void DoubleClick(object sender, EventArgs e)
        {
            click_num(sender,e);
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                EnterSecond = Convert.ToDouble(TxtOut.Text);
                switch (op)
                {
                    case "+":
                        TxtOut.Text = (EnterFirst + EnterSecond).ToString();
                        break;
                    case "–":
                        TxtOut.Text = (EnterFirst - EnterSecond).ToString();
                        break;
                    case "⨉":
                        TxtOut.Text = (EnterFirst * EnterSecond).ToString();
                        break;
                    case "÷":
                        TxtOut.Text = (EnterFirst / EnterSecond).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                MessageBox.Show("You Should Entering Number", "Caculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Operation_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button num = (Guna.UI2.WinForms.Guna2Button)sender;
            if (TxtOut.Text != null)
            {
                try
                {
                    EnterFirst = Convert.ToDouble(TxtOut.Text);
                    TxtShow.Text = EnterFirst.ToString();
                    op = num.Text;
                    TxtOut.Clear();
                }
                catch
                {
                    MessageBox.Show("You Should Entering Number", "Caculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
