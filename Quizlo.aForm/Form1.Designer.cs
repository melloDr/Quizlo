namespace Quizlo.aForm
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
            grbC1 = new GroupBox();
            lblContent = new Label();
            grbC2 = new GroupBox();
            lblD = new Label();
            lblC = new Label();
            lblB = new Label();
            lblA = new Label();
            btnD = new Button();
            btnC = new Button();
            btnB = new Button();
            btnA = new Button();
            btnStart = new Button();
            lblResult = new Label();
            btnKey = new Button();
            grbC1.SuspendLayout();
            grbC2.SuspendLayout();
            SuspendLayout();
            // 
            // grbC1
            // 
            grbC1.Controls.Add(lblContent);
            grbC1.Location = new Point(20, 14);
            grbC1.Margin = new Padding(3, 2, 3, 2);
            grbC1.Name = "grbC1";
            grbC1.Padding = new Padding(3, 2, 3, 2);
            grbC1.Size = new Size(558, 137);
            grbC1.TabIndex = 0;
            grbC1.TabStop = false;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(26, 22);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(39, 16);
            lblContent.TabIndex = 0;
            lblContent.Text = "Content";
            // 
            // grbC2
            // 
            grbC2.Controls.Add(lblD);
            grbC2.Controls.Add(lblC);
            grbC2.Controls.Add(lblB);
            grbC2.Controls.Add(lblA);
            grbC2.Controls.Add(btnD);
            grbC2.Controls.Add(btnC);
            grbC2.Controls.Add(btnB);
            grbC2.Controls.Add(btnA);
            grbC2.Location = new Point(18, 170);
            grbC2.Margin = new Padding(3, 2, 3, 2);
            grbC2.Name = "grbC2";
            grbC2.Padding = new Padding(3, 2, 3, 2);
            grbC2.Size = new Size(648, 134);
            grbC2.TabIndex = 1;
            grbC2.TabStop = false;
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(453, 99);
            lblD.Name = "lblD";
            lblD.Size = new Size(17, 15);
            lblD.TabIndex = 7;
            lblD.Text = "--";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(116, 95);
            lblC.Name = "lblC";
            lblC.Size = new Size(17, 15);
            lblC.TabIndex = 6;
            lblC.Text = "--";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(453, 34);
            lblB.Name = "lblB";
            lblB.Size = new Size(17, 15);
            lblB.TabIndex = 5;
            lblB.Text = "--";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(116, 34);
            lblA.Name = "lblA";
            lblA.Size = new Size(17, 15);
            lblA.TabIndex = 4;
            lblA.Text = "--";
            // 
            // btnD
            // 
            btnD.Location = new Point(366, 92);
            btnD.Margin = new Padding(3, 2, 3, 2);
            btnD.Name = "btnD";
            btnD.Size = new Size(82, 22);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(28, 92);
            btnC.Margin = new Padding(3, 2, 3, 2);
            btnC.Name = "btnC";
            btnC.Size = new Size(82, 22);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(366, 28);
            btnB.Margin = new Padding(3, 2, 3, 2);
            btnB.Name = "btnB";
            btnB.Size = new Size(82, 22);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnA
            // 
            btnA.Location = new Point(28, 28);
            btnA.Margin = new Padding(3, 2, 3, 2);
            btnA.Name = "btnA";
            btnA.Size = new Size(82, 22);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(603, 22);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(82, 22);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            btnStart.KeyPress += btnStart_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(590, 65);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(12, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "-";
            // 
            // btnKey
            // 
            btnKey.Location = new Point(603, 142);
            btnKey.Name = "btnKey";
            btnKey.Size = new Size(75, 23);
            btnKey.TabIndex = 4;
            btnKey.Text = "KeyBoard";
            btnKey.UseVisualStyleBackColor = true;
            btnKey.Click += btnKey_Click;
            btnKey.KeyPress += btnKey_KeyPress;
            btnKey.Leave += btnKey_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnKey);
            Controls.Add(lblResult);
            Controls.Add(btnStart);
            Controls.Add(grbC2);
            Controls.Add(grbC1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            grbC1.ResumeLayout(false);
            grbC1.PerformLayout();
            grbC2.ResumeLayout(false);
            grbC2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbC1;
        private Label lblContent;
        private GroupBox grbC2;
        private Button btnA;
        private Button btnStart;
        private Label lblD;
        private Label lblC;
        private Label lblB;
        private Label lblA;
        private Button btnD;
        private Button btnC;
        private Button btnB;
        private Label lblResult;
        private Button btnKey;
    }
}