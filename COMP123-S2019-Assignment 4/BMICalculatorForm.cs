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
    public partial class BMICalculatorForm : Form
    {
        //Class Properties
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }

        public TextBox ActiveTextbox { get; set; }

        /// <summary>
        /// This is the constructor for the CalculatorForm
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event when the BMI Calculator Form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            clearKeyNumberPad();
            NumberPadLayoutPanel.Visible = false;
            CalculateBMIButton.Enabled = false;
            BMIProgressBar.Visible = false;
            Size = new Size(320, 480);

        }
        
        /// <summary>
        /// This method shows what happens when the number pad is cleared
        /// </summary>
        private void clearKeyNumberPad()
        {
            ResultLabel.Text = "0";
            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
        }

        /// <summary>
        /// This event is when the My Height Textbox is clicked to be inpputted 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked || MetricRadioButton.Checked)
            {
                NumberPadLayoutPanel.Visible = true;
            }
            

            if (ActiveTextbox != null)
            {
                ActiveTextbox.BackColor = Color.Black;
                ActiveTextbox = null;
            }

            ActiveTextbox = sender as TextBox;

            ActiveTextbox.BackColor = Color.LightBlue;

            if (ActiveTextbox.Text != "0")
            {
                ResultLabel.Text = ActiveTextbox.Text;
                outputString = ActiveTextbox.Text;
            }


        }

        /// <summary>
        /// This is the event handler for all the buttons on the number pad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorButtons_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;
                if (outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if (outputString.Length < maxSize)
                    {
                        outputString += tag;
                    }
                }

                ResultLabel.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        removeLastCharacter();
                        break;
                    case "done":
                        if (MyHeightTextBox.Text == "0")
                        {
                            myHeightFinalizeOutput();
                        }

                        else if (MyWeightTextBox.Text == "0")
                        {
                            myWeightFinalizeOutput();
                        }
                        if (Convert.ToDouble(MyHeightTextBox.Text) > 0 && Convert.ToDouble(MyWeightTextBox.Text) > 0)
                        {
                            CalculateBMIButton.Enabled = true;
                        }
                        break;
                    case "clear":
                        clearKeyNumberPad();
                        break;
                    case "decimal":
                        addDecimal();
                        break;
                }
            }
            

        }

        private void myWeightFinalizeOutput()
        {
            outputValue = float.Parse(outputString);

            outputValue = (float)(Math.Round(outputValue, 1));

            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            outputValue = float.Parse(outputString);
            ActiveTextbox.Text = outputValue.ToString();
            clearKeyNumberPad();
            ActiveTextbox.BackColor = Color.Black;
            ActiveTextbox = null;
            NumberPadLayoutPanel.Visible = false;
        }

        private void addDecimal()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }

        private void myHeightFinalizeOutput()
        {
            outputValue = float.Parse(outputString);

            outputValue = (float)(Math.Round(outputValue, 1));

            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            outputValue = float.Parse(outputString);
            ActiveTextbox.Text = outputValue.ToString();
            clearKeyNumberPad();
            ActiveTextbox.BackColor = Color.Black;
            ActiveTextbox = null;
            NumberPadLayoutPanel.Visible = false;
        }

        private void removeLastCharacter()
        {
            var lastChar = outputString.Substring(outputString.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);

            if (outputString.Length == 0)
            {
                outputString = "0";
            }

            ResultLabel.Text = outputString;
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {

            if (ImperialRadioButton.Checked)
            {
                double BMI = (Convert.ToDouble(MyWeightTextBox.Text) * 703) /
                    (Convert.ToDouble(MyHeightTextBox.Text) * Convert.ToDouble(MyHeightTextBox.Text));
                BMITextBox.Text = BMI.ToString("F");
            }
            else if (MetricRadioButton.Checked)
            {
                    double BMI = (Convert.ToDouble(MyHeightTextBox.Text)) /
                        (Convert.ToDouble(MyHeightTextBox.Text) * Convert.ToDouble(MyHeightTextBox.Text));
                    BMITextBox.Text = BMI.ToString("F");
            }
            double BMIValue;

            BMIValue = Convert.ToDouble(BMITextBox.Text);
            BMIProgressBar.Visible = true;
            if (BMIValue < 18.5)
            {
                BMIResultTextBox.Text = "You are Underweight";
                BMIProgressBar.Minimum = 0;
                BMIProgressBar.Maximum = 100;
                BMIProgressBar.Value = 25;
                
            }

            else if (BMIValue >= 18.5 && BMIValue <= 24.9)
            {
                BMIResultTextBox.Text = "You are Normal";
                

            }

            else if (BMIValue >= 25 && BMIValue <= 29.8)
            {
                BMIResultTextBox.Text = "You are Overwight";
               

            }

            else if (BMIValue >= 30)
            {
                BMIResultTextBox.Text = "You are Obese";
            }
        }

        
    }
}
