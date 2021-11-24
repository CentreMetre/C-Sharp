
namespace BBC_Bitesize_wage_calculator
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
            this.txtbox_hours_worked = new System.Windows.Forms.TextBox();
            this.lbl_hours_worked = new System.Windows.Forms.Label();
            this.lbl_total_pay_label = new System.Windows.Forms.Label();
            this.lbl_total_pay_output = new System.Windows.Forms.Label();
            this.lbl_error_output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_normal_pay_rate = new System.Windows.Forms.Label();
            this.lbl_normal_pay_rate_output = new System.Windows.Forms.Label();
            this.lbl_overtime_pay_rate_output = new System.Windows.Forms.Label();
            this.lbl_overtime_pay_rate = new System.Windows.Forms.Label();
            this.lbl_hours_worked_output = new System.Windows.Forms.Label();
            this.lbl_hours_worked_2 = new System.Windows.Forms.Label();
            this.lbl_overtime_hours_worked = new System.Windows.Forms.Label();
            this.lbl_overtime_hours_worked_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_hours_worked
            // 
            this.txtbox_hours_worked.Location = new System.Drawing.Point(104, 55);
            this.txtbox_hours_worked.Name = "txtbox_hours_worked";
            this.txtbox_hours_worked.Size = new System.Drawing.Size(100, 23);
            this.txtbox_hours_worked.TabIndex = 0;
            this.txtbox_hours_worked.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_hours_worked
            // 
            this.lbl_hours_worked.AutoSize = true;
            this.lbl_hours_worked.Location = new System.Drawing.Point(15, 58);
            this.lbl_hours_worked.Name = "lbl_hours_worked";
            this.lbl_hours_worked.Size = new System.Drawing.Size(86, 15);
            this.lbl_hours_worked.TabIndex = 1;
            this.lbl_hours_worked.Text = "Hours Worked:";
            this.lbl_hours_worked.Click += new System.EventHandler(this.lbl_hours_worked_Click);
            // 
            // lbl_total_pay_label
            // 
            this.lbl_total_pay_label.AutoSize = true;
            this.lbl_total_pay_label.Location = new System.Drawing.Point(89, 196);
            this.lbl_total_pay_label.Name = "lbl_total_pay_label";
            this.lbl_total_pay_label.Size = new System.Drawing.Size(58, 15);
            this.lbl_total_pay_label.TabIndex = 2;
            this.lbl_total_pay_label.Text = "Total Pay:";
            // 
            // lbl_total_pay_output
            // 
            this.lbl_total_pay_output.AutoSize = true;
            this.lbl_total_pay_output.Location = new System.Drawing.Point(153, 196);
            this.lbl_total_pay_output.Name = "lbl_total_pay_output";
            this.lbl_total_pay_output.Size = new System.Drawing.Size(19, 15);
            this.lbl_total_pay_output.TabIndex = 3;
            this.lbl_total_pay_output.Text = "£0";
            this.lbl_total_pay_output.Click += new System.EventHandler(this.lbl_total_pay_output_Click);
            // 
            // lbl_error_output
            // 
            this.lbl_error_output.Location = new System.Drawing.Point(12, 211);
            this.lbl_error_output.Name = "lbl_error_output";
            this.lbl_error_output.Size = new System.Drawing.Size(189, 42);
            this.lbl_error_output.TabIndex = 4;
            this.lbl_error_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wage Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(72, 94);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_normal_pay_rate
            // 
            this.lbl_normal_pay_rate.AutoSize = true;
            this.lbl_normal_pay_rate.Location = new System.Drawing.Point(49, 136);
            this.lbl_normal_pay_rate.Name = "lbl_normal_pay_rate";
            this.lbl_normal_pay_rate.Size = new System.Drawing.Size(98, 15);
            this.lbl_normal_pay_rate.TabIndex = 8;
            this.lbl_normal_pay_rate.Text = "Normal Pay Rate:";
            // 
            // lbl_normal_pay_rate_output
            // 
            this.lbl_normal_pay_rate_output.AutoSize = true;
            this.lbl_normal_pay_rate_output.Location = new System.Drawing.Point(153, 136);
            this.lbl_normal_pay_rate_output.Name = "lbl_normal_pay_rate_output";
            this.lbl_normal_pay_rate_output.Size = new System.Drawing.Size(19, 15);
            this.lbl_normal_pay_rate_output.TabIndex = 9;
            this.lbl_normal_pay_rate_output.Text = "£0";
            // 
            // lbl_overtime_pay_rate_output
            // 
            this.lbl_overtime_pay_rate_output.AutoSize = true;
            this.lbl_overtime_pay_rate_output.Location = new System.Drawing.Point(153, 151);
            this.lbl_overtime_pay_rate_output.Name = "lbl_overtime_pay_rate_output";
            this.lbl_overtime_pay_rate_output.Size = new System.Drawing.Size(19, 15);
            this.lbl_overtime_pay_rate_output.TabIndex = 11;
            this.lbl_overtime_pay_rate_output.Text = "£0";
            // 
            // lbl_overtime_pay_rate
            // 
            this.lbl_overtime_pay_rate.AutoSize = true;
            this.lbl_overtime_pay_rate.Location = new System.Drawing.Point(40, 151);
            this.lbl_overtime_pay_rate.Name = "lbl_overtime_pay_rate";
            this.lbl_overtime_pay_rate.Size = new System.Drawing.Size(107, 15);
            this.lbl_overtime_pay_rate.TabIndex = 10;
            this.lbl_overtime_pay_rate.Text = "Overtime Pay Rate:";
            // 
            // lbl_hours_worked_output
            // 
            this.lbl_hours_worked_output.AutoSize = true;
            this.lbl_hours_worked_output.Location = new System.Drawing.Point(153, 166);
            this.lbl_hours_worked_output.Name = "lbl_hours_worked_output";
            this.lbl_hours_worked_output.Size = new System.Drawing.Size(13, 15);
            this.lbl_hours_worked_output.TabIndex = 13;
            this.lbl_hours_worked_output.Text = "0";
            // 
            // lbl_hours_worked_2
            // 
            this.lbl_hours_worked_2.AutoSize = true;
            this.lbl_hours_worked_2.Location = new System.Drawing.Point(61, 166);
            this.lbl_hours_worked_2.Name = "lbl_hours_worked_2";
            this.lbl_hours_worked_2.Size = new System.Drawing.Size(86, 15);
            this.lbl_hours_worked_2.TabIndex = 12;
            this.lbl_hours_worked_2.Text = "Hours Worked:";
            // 
            // lbl_overtime_hours_worked
            // 
            this.lbl_overtime_hours_worked.AutoSize = true;
            this.lbl_overtime_hours_worked.Location = new System.Drawing.Point(9, 181);
            this.lbl_overtime_hours_worked.Name = "lbl_overtime_hours_worked";
            this.lbl_overtime_hours_worked.Size = new System.Drawing.Size(138, 15);
            this.lbl_overtime_hours_worked.TabIndex = 14;
            this.lbl_overtime_hours_worked.Text = "Overtime Hours Worked:";
            // 
            // lbl_overtime_hours_worked_output
            // 
            this.lbl_overtime_hours_worked_output.AutoSize = true;
            this.lbl_overtime_hours_worked_output.Location = new System.Drawing.Point(153, 181);
            this.lbl_overtime_hours_worked_output.Name = "lbl_overtime_hours_worked_output";
            this.lbl_overtime_hours_worked_output.Size = new System.Drawing.Size(13, 15);
            this.lbl_overtime_hours_worked_output.TabIndex = 15;
            this.lbl_overtime_hours_worked_output.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 226);
            this.Controls.Add(this.lbl_overtime_hours_worked_output);
            this.Controls.Add(this.lbl_overtime_hours_worked);
            this.Controls.Add(this.lbl_hours_worked_output);
            this.Controls.Add(this.lbl_hours_worked_2);
            this.Controls.Add(this.lbl_overtime_pay_rate_output);
            this.Controls.Add(this.lbl_overtime_pay_rate);
            this.Controls.Add(this.lbl_normal_pay_rate_output);
            this.Controls.Add(this.lbl_normal_pay_rate);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_error_output);
            this.Controls.Add(this.lbl_total_pay_output);
            this.Controls.Add(this.lbl_total_pay_label);
            this.Controls.Add(this.lbl_hours_worked);
            this.Controls.Add(this.txtbox_hours_worked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(234, 265);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_hours_worked;
        private System.Windows.Forms.Label lbl_hours_worked;
        private System.Windows.Forms.Label lbl_total_pay_label;
        private System.Windows.Forms.Label lbl_total_pay_output;
        private System.Windows.Forms.Label lbl_error_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_normal_pay_rate;
        private System.Windows.Forms.Label lbl_normal_pay_rate_output;
        private System.Windows.Forms.Label lbl_overtime_pay_rate_output;
        private System.Windows.Forms.Label lbl_overtime_pay_rate;
        private System.Windows.Forms.Label lbl_hours_worked_output;
        private System.Windows.Forms.Label lbl_hours_worked_2;
        private System.Windows.Forms.Label lbl_overtime_hours_worked;
        private System.Windows.Forms.Label lbl_overtime_hours_worked_output;
    }
}

