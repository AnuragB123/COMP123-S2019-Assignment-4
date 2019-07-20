namespace COMP123_S2019_Assignment_4
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculatorForm));
            this.NumberPadLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMILabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.InformationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.NumberPadLayoutPanel.SuspendLayout();
            this.BMITableLayoutPanel.SuspendLayout();
            this.InformationTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberPadLayoutPanel
            // 
            this.NumberPadLayoutPanel.ColumnCount = 4;
            this.NumberPadLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPadLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPadLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPadLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPadLayoutPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.NumberPadLayoutPanel.Controls.Add(this.ResultLabel, 0, 0);
            this.NumberPadLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.NumberPadLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.NumberPadLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.NumberPadLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.NumberPadLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.NumberPadLayoutPanel.Controls.Add(this.ClearButton, 3, 2);
            this.NumberPadLayoutPanel.Controls.Add(this.button10, 3, 1);
            this.NumberPadLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.NumberPadLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.NumberPadLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.NumberPadLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.NumberPadLayoutPanel.Controls.Add(this.DoneButton, 3, 3);
            this.NumberPadLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.NumberPadLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberPadLayoutPanel.Location = new System.Drawing.Point(12, 215);
            this.NumberPadLayoutPanel.Name = "NumberPadLayoutPanel";
            this.NumberPadLayoutPanel.RowCount = 5;
            this.NumberPadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NumberPadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NumberPadLayoutPanel.Size = new System.Drawing.Size(278, 141);
            this.NumberPadLayoutPanel.TabIndex = 0;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NumberPadLayoutPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 115);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(132, 23);
            this.ZeroButton.TabIndex = 6;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberPadLayoutPanel.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(272, 28);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 31);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(63, 22);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(72, 31);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(63, 22);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 87);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(63, 22);
            this.OneButton.TabIndex = 5;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(72, 87);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(63, 22);
            this.TwoButton.TabIndex = 5;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(141, 87);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(63, 22);
            this.ThreeButton.TabIndex = 5;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(210, 59);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(65, 22);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.SteelBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(210, 31);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 22);
            this.button10.TabIndex = 5;
            this.button10.Tag = "back";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(141, 31);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(63, 22);
            this.NineButton.TabIndex = 1;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(72, 59);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(63, 22);
            this.FiveButton.TabIndex = 1;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(141, 59);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(63, 22);
            this.SixButton.TabIndex = 1;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 59);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(63, 22);
            this.FourButton.TabIndex = 1;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(210, 87);
            this.DoneButton.Name = "DoneButton";
            this.NumberPadLayoutPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(65, 51);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.Location = new System.Drawing.Point(141, 115);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(63, 23);
            this.DecimalButton.TabIndex = 8;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.BMICalculatorButtons_Click);
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 4;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.Controls.Add(this.BMILabel, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 2);
            this.BMITableLayoutPanel.Controls.Add(this.BMITextBox, 2, 0);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(-4, 362);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 4;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(294, 71);
            this.BMITableLayoutPanel.TabIndex = 2;
            // 
            // BMILabel
            // 
            this.BMILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMILabel.AutoSize = true;
            this.BMILabel.BackColor = System.Drawing.Color.Black;
            this.BMILabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMITableLayoutPanel.SetColumnSpan(this.BMILabel, 2);
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.ForeColor = System.Drawing.Color.White;
            this.BMILabel.Location = new System.Drawing.Point(3, 0);
            this.BMILabel.Name = "BMILabel";
            this.BMITableLayoutPanel.SetRowSpan(this.BMILabel, 2);
            this.BMILabel.Size = new System.Drawing.Size(140, 34);
            this.BMILabel.TabIndex = 1;
            this.BMILabel.Tag = "BMI";
            this.BMILabel.Text = "BMI:";
            this.BMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Black;
            this.BMITableLayoutPanel.SetColumnSpan(this.CalculateBMIButton, 4);
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 37);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.BMITableLayoutPanel.SetRowSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Size = new System.Drawing.Size(288, 31);
            this.CalculateBMIButton.TabIndex = 0;
            this.CalculateBMIButton.Tag = "Calculate BMI";
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMITextBox
            // 
            this.BMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMITextBox.BackColor = System.Drawing.Color.Black;
            this.BMITableLayoutPanel.SetColumnSpan(this.BMITextBox, 2);
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITextBox.ForeColor = System.Drawing.Color.White;
            this.BMITextBox.Location = new System.Drawing.Point(149, 3);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITableLayoutPanel.SetRowSpan(this.BMITextBox, 2);
            this.BMITextBox.Size = new System.Drawing.Size(142, 45);
            this.BMITextBox.TabIndex = 2;
            this.BMITextBox.Text = "0";
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InformationTableLayoutPanel
            // 
            this.InformationTableLayoutPanel.ColumnCount = 2;
            this.InformationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InformationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InformationTableLayoutPanel.Controls.Add(this.MyWeightTextBox, 1, 4);
            this.InformationTableLayoutPanel.Controls.Add(this.MetricRadioButton, 0, 2);
            this.InformationTableLayoutPanel.Controls.Add(this.BMIResultTextBox, 0, 0);
            this.InformationTableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 1);
            this.InformationTableLayoutPanel.Controls.Add(this.MyHeightLabel, 0, 3);
            this.InformationTableLayoutPanel.Controls.Add(this.MyWeightLabel, 0, 4);
            this.InformationTableLayoutPanel.Controls.Add(this.MyHeightTextBox, 1, 3);
            this.InformationTableLayoutPanel.Location = new System.Drawing.Point(12, 4);
            this.InformationTableLayoutPanel.Name = "InformationTableLayoutPanel";
            this.InformationTableLayoutPanel.RowCount = 5;
            this.InformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InformationTableLayoutPanel.Size = new System.Drawing.Size(278, 205);
            this.InformationTableLayoutPanel.TabIndex = 3;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightTextBox.BackColor = System.Drawing.Color.Black;
            this.MyWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightTextBox.ForeColor = System.Drawing.Color.White;
            this.MyWeightTextBox.Location = new System.Drawing.Point(142, 167);
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(133, 45);
            this.MyWeightTextBox.TabIndex = 6;
            this.MyWeightTextBox.Tag = "My Height";
            this.MyWeightTextBox.Text = "0";
            this.MyWeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MyWeightTextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.BackColor = System.Drawing.Color.Black;
            this.InformationTableLayoutPanel.SetColumnSpan(this.MetricRadioButton, 2);
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.ForeColor = System.Drawing.Color.White;
            this.MetricRadioButton.Location = new System.Drawing.Point(3, 85);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(272, 35);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Tag = "Metric";
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricRadioButton.UseVisualStyleBackColor = false;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIResultTextBox.BackColor = System.Drawing.Color.Black;
            this.InformationTableLayoutPanel.SetColumnSpan(this.BMIResultTextBox, 2);
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.White;
            this.BMIResultTextBox.Location = new System.Drawing.Point(3, 3);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(272, 35);
            this.BMIResultTextBox.TabIndex = 0;
            this.BMIResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.BackColor = System.Drawing.Color.Black;
            this.InformationTableLayoutPanel.SetColumnSpan(this.ImperialRadioButton, 2);
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.White;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 44);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(272, 35);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Tag = "Imperial";
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = false;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightLabel.BackColor = System.Drawing.Color.Black;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.ForeColor = System.Drawing.Color.White;
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 123);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(133, 41);
            this.MyHeightLabel.TabIndex = 3;
            this.MyHeightLabel.Tag = "My Height";
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightLabel.BackColor = System.Drawing.Color.Black;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.ForeColor = System.Drawing.Color.White;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 164);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(133, 41);
            this.MyWeightLabel.TabIndex = 4;
            this.MyWeightLabel.Tag = "My Weight";
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightTextBox.BackColor = System.Drawing.Color.Black;
            this.MyHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightTextBox.ForeColor = System.Drawing.Color.White;
            this.MyHeightTextBox.Location = new System.Drawing.Point(142, 126);
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(133, 45);
            this.MyHeightTextBox.TabIndex = 5;
            this.MyHeightTextBox.Tag = "My Height";
            this.MyHeightTextBox.Text = "0";
            this.MyHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MyHeightTextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 650);
            this.Controls.Add(this.InformationTableLayoutPanel);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Controls.Add(this.NumberPadLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.NumberPadLayoutPanel.ResumeLayout(false);
            this.NumberPadLayoutPanel.PerformLayout();
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.InformationTableLayoutPanel.ResumeLayout(false);
            this.InformationTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NumberPadLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TableLayoutPanel InformationTableLayoutPanel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button DecimalButton;
    }
}

