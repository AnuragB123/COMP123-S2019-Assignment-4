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
        /// <summary>
        /// This is the constructor of Splash Page Form
        /// </summary>
        public SplashPageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler when the Splash Page loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashPageForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        /// <summary>
        /// This is the event handler for when the Timer starts it ticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.BMI_CALCULATOR_FORM].Show();
            this.Hide();
        }

        
    }
}
