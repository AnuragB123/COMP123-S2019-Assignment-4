using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
