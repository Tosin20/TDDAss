namespace TDDAss
{
    partial class Calculator
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
            this.labelDiag1 = new System.Windows.Forms.Label();
            this.labelDiag2 = new System.Windows.Forms.Label();
            this.labelCal = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxDiag1 = new System.Windows.Forms.TextBox();
            this.textBox2Diag2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDiag1
            // 
            this.labelDiag1.AutoSize = true;
            this.labelDiag1.Location = new System.Drawing.Point(69, 58);
            this.labelDiag1.Name = "labelDiag1";
            this.labelDiag1.Size = new System.Drawing.Size(98, 25);
            this.labelDiag1.TabIndex = 0;
            this.labelDiag1.Text = "Diagonal 1";
            // 
            // labelDiag2
            // 
            this.labelDiag2.AutoSize = true;
            this.labelDiag2.Location = new System.Drawing.Point(69, 171);
            this.labelDiag2.Name = "labelDiag2";
            this.labelDiag2.Size = new System.Drawing.Size(98, 25);
            this.labelDiag2.TabIndex = 1;
            this.labelDiag2.Text = "Diagonal 2";
            // 
            // labelCal
            // 
            this.labelCal.AutoSize = true;
            this.labelCal.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCal.Location = new System.Drawing.Point(311, 247);
            this.labelCal.Name = "labelCal";
            this.labelCal.Size = new System.Drawing.Size(143, 30);
            this.labelCal.TabIndex = 2;
            this.labelCal.Text = "Calculate";
            this.labelCal.Click += new System.EventHandler(this.labelCal_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(79, 312);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 25);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Result";
            // 
            // textBoxDiag1
            // 
            this.textBoxDiag1.Location = new System.Drawing.Point(234, 58);
            this.textBoxDiag1.Name = "textBoxDiag1";
            this.textBoxDiag1.Size = new System.Drawing.Size(312, 31);
            this.textBoxDiag1.TabIndex = 4;
            // 
            // textBox2Diag2
            // 
            this.textBox2Diag2.Location = new System.Drawing.Point(240, 173);
            this.textBox2Diag2.Name = "textBox2Diag2";
            this.textBox2Diag2.Size = new System.Drawing.Size(306, 31);
            this.textBox2Diag2.TabIndex = 5;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(255, 319);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(291, 31);
            this.textBoxResult.TabIndex = 6;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBox2Diag2);
            this.Controls.Add(this.textBoxDiag1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCal);
            this.Controls.Add(this.labelDiag2);
            this.Controls.Add(this.labelDiag1);
            this.Name = "Calculator";
            this.Text = "Area of Rhombus Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDiag1;
        private Label labelDiag2;
        private Label labelCal;
        private Label labelResult;
        private TextBox textBoxDiag1;
        private TextBox textBox2Diag2;
        private TextBox textBoxResult;
    }
}