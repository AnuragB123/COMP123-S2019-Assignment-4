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

        /// <summary>
        /// This is the constructor for the CalculatorForm
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }


        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            clearNumberPad();
            NumberKeyTableLayout.Visible = false;
            CalculateBMIButton.Enabled = false;
        }

        private void clearNumberPad()
        {
            ResultLabel.Text = "0";
            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
        }

        private void MyHeigtLabelNumberKeypad_Click(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked || MetricRadioButton.Checked)
            {
                NumberKeyTableLayout.Visible = true;
            }
            else
            {
                MessageBox.Show("Metric Units Must be selected");
            }
            
        }

        private void BMICalculatorButton_Click(object sender, EventArgs e)
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
                        clearNumberPad();
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
            MyWeightTextBox.Text = outputValue.ToString();
            clearNumberPad();
            NumberKeyTableLayout.Visible = false;
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
            MyHeightTextBox.Text = outputValue.ToString();
            clearNumberPad();
            NumberKeyTableLayout.Visible = false;
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
                BMIValueTextBox.Text = Convert.ToString(BMI);
            }
        }
    }
}
