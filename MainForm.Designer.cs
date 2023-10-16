namespace SavingsCalculator
{
    partial class MainForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            paid = new Label();
            balance = new Label();
            textDeposit = new TextBox();
            textYears = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 55);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Saving plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 103);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Monthley deposit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 139);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Period in years";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 225);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Future value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 271);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Amount paid";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 312);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Fibal balance";
            // 
            // paid
            // 
            paid.AutoSize = true;
            paid.BorderStyle = BorderStyle.Fixed3D;
            paid.Location = new Point(260, 271);
            paid.Name = "paid";
            paid.Size = new Size(2, 17);
            paid.TabIndex = 6;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.BorderStyle = BorderStyle.Fixed3D;
            balance.Location = new Point(260, 312);
            balance.Name = "balance";
            balance.Size = new Size(2, 17);
            balance.TabIndex = 7;
            // 
            // textDeposit
            // 
            textDeposit.Location = new Point(260, 95);
            textDeposit.Name = "textDeposit";
            textDeposit.Size = new Size(100, 23);
            textDeposit.TabIndex = 8;
            // 
            // textYears
            // 
            textYears.Location = new Point(260, 131);
            textYears.Name = "textYears";
            textYears.Size = new Size(100, 23);
            textYears.TabIndex = 9;
            // 
            // button
            // 
            button.Location = new Point(260, 185);
            button.Name = "button";
            button.Size = new Size(100, 23);
            button.TabIndex = 10;
            button.Text = "Caclculate";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 416);
            Controls.Add(button);
            Controls.Add(textYears);
            Controls.Add(textDeposit);
            Controls.Add(balance);
            Controls.Add(paid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label paid;
        private Label balance;
        private TextBox textDeposit;
        private TextBox textYears;
        private Button button;
    }
}