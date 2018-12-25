namespace DbApp
{
    partial class FrmCourseUpdate
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCcredit = new System.Windows.Forms.TextBox();
            this.tbCpno = new System.Windows.Forms.TextBox();
            this.tbCname = new System.Windows.Forms.TextBox();
            this.tbCno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "课程学分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "先修课程号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "课程名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "课程号";
            // 
            // tbCcredit
            // 
            this.tbCcredit.Location = new System.Drawing.Point(149, 145);
            this.tbCcredit.Name = "tbCcredit";
            this.tbCcredit.Size = new System.Drawing.Size(147, 21);
            this.tbCcredit.TabIndex = 4;
            // 
            // tbCpno
            // 
            this.tbCpno.Location = new System.Drawing.Point(149, 118);
            this.tbCpno.Name = "tbCpno";
            this.tbCpno.Size = new System.Drawing.Size(147, 21);
            this.tbCpno.TabIndex = 5;
            // 
            // tbCname
            // 
            this.tbCname.Location = new System.Drawing.Point(149, 91);
            this.tbCname.Name = "tbCname";
            this.tbCname.Size = new System.Drawing.Size(147, 21);
            this.tbCname.TabIndex = 6;
            // 
            // tbCno
            // 
            this.tbCno.Location = new System.Drawing.Point(149, 64);
            this.tbCno.Name = "tbCno";
            this.tbCno.ReadOnly = true;
            this.tbCno.Size = new System.Drawing.Size(147, 21);
            this.tbCno.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "更新课程信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCourseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 274);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCcredit);
            this.Controls.Add(this.tbCpno);
            this.Controls.Add(this.tbCname);
            this.Controls.Add(this.tbCno);
            this.Controls.Add(this.button1);
            this.Name = "FrmCourseUpdate";
            this.Text = "FrmCourseUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbCcredit;
        public System.Windows.Forms.TextBox tbCpno;
        public System.Windows.Forms.TextBox tbCname;
        public System.Windows.Forms.TextBox tbCno;
        private System.Windows.Forms.Button button1;
    }
}