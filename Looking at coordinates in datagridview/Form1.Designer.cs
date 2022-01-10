
namespace Looking_at_coordinates_in_datagridview
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxInputName = new System.Windows.Forms.TextBox();
            this.checkboxReady = new System.Windows.Forms.CheckBox();
            this.butInputCurInfo = new System.Windows.Forms.Button();
            this.txtboxInputScore = new System.Windows.Forms.TextBox();
            this.lblNameOfStudent = new System.Windows.Forms.Label();
            this.lblScoreOfStudent = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblErrorOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Column2});
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(240, 150);
            this.dgv1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxInputName
            // 
            this.txtboxInputName.Location = new System.Drawing.Point(13, 189);
            this.txtboxInputName.Name = "txtboxInputName";
            this.txtboxInputName.Size = new System.Drawing.Size(100, 20);
            this.txtboxInputName.TabIndex = 2;
            this.txtboxInputName.TextChanged += new System.EventHandler(this.txtboxInputName_TextChanged);
            // 
            // checkboxReady
            // 
            this.checkboxReady.AutoSize = true;
            this.checkboxReady.Location = new System.Drawing.Point(13, 244);
            this.checkboxReady.Name = "checkboxReady";
            this.checkboxReady.Size = new System.Drawing.Size(138, 17);
            this.checkboxReady.TabIndex = 3;
            this.checkboxReady.Text = "Ready to input all data?";
            this.checkboxReady.UseVisualStyleBackColor = true;
            this.checkboxReady.CheckedChanged += new System.EventHandler(this.checkboxReady_CheckedChanged);
            // 
            // butInputCurInfo
            // 
            this.butInputCurInfo.Location = new System.Drawing.Point(12, 215);
            this.butInputCurInfo.Name = "butInputCurInfo";
            this.butInputCurInfo.Size = new System.Drawing.Size(75, 23);
            this.butInputCurInfo.TabIndex = 4;
            this.butInputCurInfo.Text = "Input student/score";
            this.butInputCurInfo.UseVisualStyleBackColor = true;
            this.butInputCurInfo.Click += new System.EventHandler(this.butInputCurInfo_Click);
            // 
            // txtboxInputScore
            // 
            this.txtboxInputScore.Location = new System.Drawing.Point(119, 189);
            this.txtboxInputScore.Name = "txtboxInputScore";
            this.txtboxInputScore.Size = new System.Drawing.Size(100, 20);
            this.txtboxInputScore.TabIndex = 5;
            // 
            // lblNameOfStudent
            // 
            this.lblNameOfStudent.AutoSize = true;
            this.lblNameOfStudent.Location = new System.Drawing.Point(13, 169);
            this.lblNameOfStudent.Name = "lblNameOfStudent";
            this.lblNameOfStudent.Size = new System.Drawing.Size(87, 13);
            this.lblNameOfStudent.TabIndex = 6;
            this.lblNameOfStudent.Text = "Name of Student";
            // 
            // lblScoreOfStudent
            // 
            this.lblScoreOfStudent.AutoSize = true;
            this.lblScoreOfStudent.Location = new System.Drawing.Point(116, 169);
            this.lblScoreOfStudent.Name = "lblScoreOfStudent";
            this.lblScoreOfStudent.Size = new System.Drawing.Size(87, 13);
            this.lblScoreOfStudent.TabIndex = 7;
            this.lblScoreOfStudent.Text = "Score of Student";
            // 
            // Names
            // 
            this.Names.HeaderText = "Names";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Scores";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lblErrorOutput
            // 
            this.lblErrorOutput.AutoSize = true;
            this.lblErrorOutput.Location = new System.Drawing.Point(309, 83);
            this.lblErrorOutput.Name = "lblErrorOutput";
            this.lblErrorOutput.Size = new System.Drawing.Size(43, 13);
            this.lblErrorOutput.TabIndex = 8;
            this.lblErrorOutput.Text = "no error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorOutput);
            this.Controls.Add(this.lblScoreOfStudent);
            this.Controls.Add(this.lblNameOfStudent);
            this.Controls.Add(this.txtboxInputScore);
            this.Controls.Add(this.butInputCurInfo);
            this.Controls.Add(this.checkboxReady);
            this.Controls.Add(this.txtboxInputName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxInputName;
        private System.Windows.Forms.CheckBox checkboxReady;
        private System.Windows.Forms.Button butInputCurInfo;
        private System.Windows.Forms.TextBox txtboxInputScore;
        private System.Windows.Forms.Label lblNameOfStudent;
        private System.Windows.Forms.Label lblScoreOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblErrorOutput;
    }
}

