using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_4
{
    public partial class SplashPageForm : Form
    {
        public SplashPageForm()
        {
            InitializeComponent();
        }
        private void SplashPageForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.BMI_CALCULATOR_FORM].Show();
            this.Hide();
        }

        
    }
}
