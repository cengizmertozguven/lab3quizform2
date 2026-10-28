namespace lab3quizform2
{
    partial class Form1
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
            txtScore = new TextBox();
            lblResult = new Label();
            btnCheckPass = new Button();
            btnLetterGrade = new Button();
            btnAverage = new Button();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.Location = new Point(396, 25);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(471, 164);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "label1";
            // 
            // btnCheckPass
            // 
            btnCheckPass.Location = new Point(78, 12);
            btnCheckPass.Name = "btnCheckPass";
            btnCheckPass.Size = new Size(107, 53);
            btnCheckPass.TabIndex = 2;
            btnCheckPass.Text = "Pass or Fail";
            btnCheckPass.UseVisualStyleBackColor = true;
            btnCheckPass.Click += btnCheckPass_Click;
            // 
            // btnLetterGrade
            // 
            btnLetterGrade.Location = new Point(88, 85);
            btnLetterGrade.Name = "btnLetterGrade";
            btnLetterGrade.Size = new Size(99, 57);
            btnLetterGrade.TabIndex = 4;
            btnLetterGrade.Text = "Letter Grade";
            btnLetterGrade.UseVisualStyleBackColor = true;
            btnLetterGrade.Click += btnLetterGrade_Click;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(88, 158);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(133, 32);
            btnAverage.TabIndex = 6;
            btnAverage.Text = "Average to 100";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAverage);
            Controls.Add(btnLetterGrade);
            Controls.Add(btnCheckPass);
            Controls.Add(lblResult);
            Controls.Add(txtScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScore;
        private Label lblResult;
        private Button btnCheckPass;
        private Button btnLetterGrade;
        private Button btnAverage;
    }
}
