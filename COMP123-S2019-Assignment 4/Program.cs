using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        //Dictionary that holds the three forms in this application
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Intializes a new empty Dictionary
            Forms = new Dictionary<FormName, Form>();
            //Add the two forms in the application
            Forms.Add(FormName.SPLASH_PAGE, new SplashPageForm());
            Forms.Add(FormName.BMI_CALCULATOR_FORM, new BMICalculatorForm());
            //When the application runs, the Splash Page Form runs first
            Application.Run(Forms[FormName.SPLASH_PAGE]);
        }
    }
}
