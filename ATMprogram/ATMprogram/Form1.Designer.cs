namespace ATMprogram
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDeposit = new System.Windows.Forms.Button();
            this.btWithdrawl = new System.Windows.Forms.Button();
            this.btbalance = new System.Windows.Forms.Button();
            this.gbPinPad = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.lbDisplay2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbPinPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM";
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(38, 45);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(76, 64);
            this.lbDisplay.TabIndex = 1;
            this.lbDisplay.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btDeposit);
            this.groupBox1.Controls.Add(this.btWithdrawl);
            this.groupBox1.Controls.Add(this.btbalance);
            this.groupBox1.Controls.Add(this.gbPinPad);
            this.groupBox1.Controls.Add(this.lbDisplay2);
            this.groupBox1.Controls.Add(this.lbDisplay);
            this.groupBox1.Location = new System.Drawing.Point(41, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 847);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // btCancel
            // 
            this.btCancel.Enabled = false;
            this.btCancel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(893, 697);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(299, 114);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDeposit
            // 
            this.btDeposit.Enabled = false;
            this.btDeposit.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeposit.Location = new System.Drawing.Point(893, 545);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(299, 114);
            this.btDeposit.TabIndex = 7;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.UseVisualStyleBackColor = true;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // btWithdrawl
            // 
            this.btWithdrawl.Enabled = false;
            this.btWithdrawl.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWithdrawl.Location = new System.Drawing.Point(893, 390);
            this.btWithdrawl.Name = "btWithdrawl";
            this.btWithdrawl.Size = new System.Drawing.Size(299, 114);
            this.btWithdrawl.TabIndex = 6;
            this.btWithdrawl.Text = "Withdrawal";
            this.btWithdrawl.UseVisualStyleBackColor = true;
            this.btWithdrawl.Click += new System.EventHandler(this.btWithdrawl_Click);
            // 
            // btbalance
            // 
            this.btbalance.Enabled = false;
            this.btbalance.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbalance.Location = new System.Drawing.Point(893, 247);
            this.btbalance.Name = "btbalance";
            this.btbalance.Size = new System.Drawing.Size(299, 114);
            this.btbalance.TabIndex = 5;
            this.btbalance.Text = "Balance";
            this.btbalance.UseVisualStyleBackColor = true;
            this.btbalance.Click += new System.EventHandler(this.btbalance_Click);
            // 
            // gbPinPad
            // 
            this.gbPinPad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbPinPad.Controls.Add(this.tbOutput);
            this.gbPinPad.Controls.Add(this.btEnter);
            this.gbPinPad.Controls.Add(this.btClear);
            this.gbPinPad.Controls.Add(this.button_0);
            this.gbPinPad.Controls.Add(this.button_1);
            this.gbPinPad.Controls.Add(this.button_4);
            this.gbPinPad.Controls.Add(this.button_7);
            this.gbPinPad.Controls.Add(this.button_2);
            this.gbPinPad.Controls.Add(this.button_5);
            this.gbPinPad.Controls.Add(this.button_8);
            this.gbPinPad.Controls.Add(this.button_3);
            this.gbPinPad.Controls.Add(this.button_9);
            this.gbPinPad.Controls.Add(this.button_6);
            this.gbPinPad.Location = new System.Drawing.Point(40, 247);
            this.gbPinPad.Name = "gbPinPad";
            this.gbPinPad.Size = new System.Drawing.Size(750, 572);
            this.gbPinPad.TabIndex = 3;
            this.gbPinPad.TabStop = false;
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOutput.Location = new System.Drawing.Point(32, 665);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(680, 22);
            this.tbOutput.TabIndex = 9;
            this.tbOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOutput_KeyDown);
            this.tbOutput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbOutput_KeyUp);
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btEnter.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Location = new System.Drawing.Point(40, 436);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(180, 79);
            this.btEnter.TabIndex = 12;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btClear.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(486, 436);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(180, 79);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_0.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(267, 436);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(180, 79);
            this.button_0.TabIndex = 10;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_1.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(40, 47);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(180, 85);
            this.button_1.TabIndex = 9;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_4.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(40, 177);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(180, 85);
            this.button_4.TabIndex = 8;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_7.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(40, 313);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(180, 85);
            this.button_7.TabIndex = 7;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_2.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(267, 47);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(180, 85);
            this.button_2.TabIndex = 6;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_5.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(267, 177);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(180, 85);
            this.button_5.TabIndex = 5;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_8.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(267, 313);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(180, 85);
            this.button_8.TabIndex = 4;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_3.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(486, 47);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(180, 85);
            this.button_3.TabIndex = 3;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_9.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(486, 313);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(180, 85);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_6.Font = new System.Drawing.Font("Consolas", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(486, 177);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(180, 85);
            this.button_6.TabIndex = 1;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            // 
            // lbDisplay2
            // 
            this.lbDisplay2.AutoSize = true;
            this.lbDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay2.Location = new System.Drawing.Point(38, 143);
            this.lbDisplay2.Name = "lbDisplay2";
            this.lbDisplay2.Size = new System.Drawing.Size(76, 64);
            this.lbDisplay2.TabIndex = 2;
            this.lbDisplay2.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1526, 965);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPinPad.ResumeLayout(false);
            this.gbPinPad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithdrawl;
        private System.Windows.Forms.Button btbalance;
        private System.Windows.Forms.GroupBox gbPinPad;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Label lbDisplay2;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

