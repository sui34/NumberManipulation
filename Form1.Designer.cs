namespace ComputingNumbers
{
    partial class numberManipulationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enterTheArrayListLabel = new Label();
            textBox1 = new TextBox();
            listOddNumbersRadio = new RadioButton();
            sumRadio = new RadioButton();
            countDuplicateRadio = new RadioButton();
            computeButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // enterTheArrayListLabel
            // 
            enterTheArrayListLabel.AutoSize = true;
            enterTheArrayListLabel.Location = new Point(12, 26);
            enterTheArrayListLabel.Name = "enterTheArrayListLabel";
            enterTheArrayListLabel.Size = new Size(177, 25);
            enterTheArrayListLabel.TabIndex = 0;
            enterTheArrayListLabel.Text = "Enter The Array List : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 20);
            textBox1.MaxLength = 1000;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // listOddNumbersRadio
            // 
            listOddNumbersRadio.AutoSize = true;
            listOddNumbersRadio.Location = new Point(12, 82);
            listOddNumbersRadio.Name = "listOddNumbersRadio";
            listOddNumbersRadio.Size = new Size(182, 29);
            listOddNumbersRadio.TabIndex = 2;
            listOddNumbersRadio.TabStop = true;
            listOddNumbersRadio.Text = "List Odd Numbers";
            listOddNumbersRadio.UseVisualStyleBackColor = true;
            listOddNumbersRadio.CheckedChanged += listOddNumbersRadio_CheckedChanged;
            // 
            // sumRadio
            // 
            sumRadio.AutoSize = true;
            sumRadio.Location = new Point(221, 82);
            sumRadio.Name = "sumRadio";
            sumRadio.Size = new Size(73, 29);
            sumRadio.TabIndex = 3;
            sumRadio.TabStop = true;
            sumRadio.Text = "Sum";
            sumRadio.UseVisualStyleBackColor = true;
            // 
            // countDuplicateRadio
            // 
            countDuplicateRadio.AutoSize = true;
            countDuplicateRadio.Location = new Point(320, 82);
            countDuplicateRadio.Name = "countDuplicateRadio";
            countDuplicateRadio.Size = new Size(164, 29);
            countDuplicateRadio.TabIndex = 4;
            countDuplicateRadio.TabStop = true;
            countDuplicateRadio.Text = "Count Duplicate";
            countDuplicateRadio.UseVisualStyleBackColor = true;
            countDuplicateRadio.CheckedChanged += countDuplicateRadio_CheckedChanged;
            // 
            // computeButton
            // 
            computeButton.Location = new Point(115, 163);
            computeButton.Name = "computeButton";
            computeButton.Size = new Size(112, 34);
            computeButton.TabIndex = 5;
            computeButton.Text = "Compute";
            computeButton.UseVisualStyleBackColor = true;
            computeButton.Click += computeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(272, 163);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // numberManipulationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 229);
            Controls.Add(clearButton);
            Controls.Add(computeButton);
            Controls.Add(countDuplicateRadio);
            Controls.Add(sumRadio);
            Controls.Add(listOddNumbersRadio);
            Controls.Add(textBox1);
            Controls.Add(enterTheArrayListLabel);
            Name = "numberManipulationForm";
            Text = "Number Manipulation";
            Load += numberManipulationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterTheArrayListLabel;
        private TextBox textBox1;
        private RadioButton listOddNumbersRadio;
        private RadioButton sumRadio;
        private RadioButton countDuplicateRadio;
        private Button computeButton;
        private Button clearButton;
    }
}
