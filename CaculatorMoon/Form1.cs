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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormMover formMover = new FormMover();
            formMover.AttachToPanel(Control_panel, this);
        }

        private void CloseButt_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Confirm ir you want to exit", "Caculator", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

        private void Keep_on_Top_Click(object sender, EventArgs e)
        {
            if (!TopMost == true) 
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
    }
}
