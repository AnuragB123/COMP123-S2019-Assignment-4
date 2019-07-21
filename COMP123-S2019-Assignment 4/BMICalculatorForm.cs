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
            //Calls on clearKeyNumberPad() method which clears the key number pad
            clearKeyNumberPad();
            NumberPadLayoutPanel.Visible = false;
            CalculateBMIButton.Enabled = false;
            Size = new Size(320, 480);
        }

        /// <summary>
        /// This event is when the either My Height TextBox or My Weight TextBox are clicked and what happens then
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            if (ActiveTextbox != null)
            {
                ActiveTextbox.BackColor = Color.Black;
                ActiveTextbox = null;
            }
            if (ImperialRadioButton.Checked || MetricRadioButton.Checked)
            {
                NumberPadLayoutPanel.Visible = true;
            }
            ActiveTextbox = sender as TextBox;
            ActiveTextbox.BackColor = Color.LightBlue;
            if (!ImperialRadioButton.Checked && !MetricRadioButton.Checked)
            {
                MessageBox.Show("Metric Units must be selected");
                ActiveTextbox.BackColor = Color.Black;
            }
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
                        //Calls on removeLastCharacter() method, which removes the last number inputted into number key pad
                        removeLastCharacter();
                        break;
                    case "done":
                        //Calls on FinalizeOutput() which finalizes the output
                        FinalizeOutput();
                        if (Convert.ToDouble(MyHeightTextBox.Text) > 0 && Convert.ToDouble(MyWeightTextBox.Text) > 0)
                        {
                            CalculateBMIButton.Enabled = true;
                        }
                        break;
                    case "clear":
                        //Calls on clearKeyNumberPad() method, which clears the ley number pad
                        clearKeyNumberPad();
                        break;
                    case "decimal":
                        //Calls on addDecimal(), which adds decimal to the output
                        addDecimal();
                        break;
                }
            }
        }

        /// <summary>
        /// This is the event when the Calculate BMI Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            //Calls on BMICalculationsAndMessages(), which does the calculations to figure the BMI and the BMI Messages
            BMICalculationsAndMessages();
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
        /// This removes the last character
        /// </summary>
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

        /// <summary>
        /// This is to finalize the output of the text in the two textboxes
        /// </summary>
        private void FinalizeOutput()
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

        /// <summary>
        /// This is called when a decimal is needed for inputting the number from the keypad
        /// </summary>
        private void addDecimal()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }

        /// <summary>
        /// This method calls other methods that do the BMI Calculations and also determins the message
        /// </summary>
        private void BMICalculationsAndMessages()
        {
            if (ImperialRadioButton.Checked)
            {
                //BMI Calculation according to Imperial Units Formula
                ImperialUnitsBMICalculation();
            }
            else if (MetricRadioButton.Checked)
            {
                //BMI Calculation according to Metric Units Formula
                MetricUnitsBMICalculation();
            }
            //Determines the BMI Message
            BMIMessage();
        }

        /// <summary>
        /// This does the calculation in the Imperial Units Formula
        /// </summary>
        private void ImperialUnitsBMICalculation()
        {
            MessageBox.Show("Weight in Kilograms and Height in Meters");
            double BMI = (Convert.ToDouble(MyWeightTextBox.Text) * 703) /
                                (Convert.ToDouble(MyHeightTextBox.Text) * Convert.ToDouble(MyHeightTextBox.Text));
            BMITextBox.Text = BMI.ToString("F");
        }

        /// <summary>
        /// This does the calculation in the Metric Units Formula
        /// </summary>
        private void MetricUnitsBMICalculation()
        {
            MessageBox.Show("Weight in pounds and Height in inches");
            double BMI = (Convert.ToDouble(MyHeightTextBox.Text)) /
                                (Convert.ToDouble(MyHeightTextBox.Text) * Convert.ToDouble(MyHeightTextBox.Text));
            BMITextBox.Text = BMI.ToString("F");
        }

        /// <summary>
        /// This determines the BMI Message to be put
        /// </summary>
        private void BMIMessage()
        {
            double BMIValue = Convert.ToDouble(BMITextBox.Text);
            if (BMIValue < 18.5)
            {
                BMIResultTextBox.Text = "You are Underweight";
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

        /// <summary>
        /// This is the event handler when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
