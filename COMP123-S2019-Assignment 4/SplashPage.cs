using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name: Anurag Bhattacharya
/// Student Number: 301050634
/// Date Last Modified: 2019-07-22
/// Program Description: This is a BMI Calculator where users can select their weight and height based on a specific units
/// and figure out what their BMI is and whether they are underweight, normal or overweight
/// Revision History:
/// 1) Created Empty Form
/// 2) Added the Buttons and Design of the Form
/// 3) Programmed the Keyboard pad to work with the user input
/// 4) Programmed the calculation of the BMI and the message shown
/// 5) Fixed some documentation of the application
/// 6) Added the Splash Screen and Programmed the Splash Screen to show for 3 seconds
/// 7) Made Final Fixes to the whole programming of the application and documentations
/// </summary>
/// 
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
