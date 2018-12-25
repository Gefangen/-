namespace DbApp
{
    partial class FrmStuInsert
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSdept = new System.Windows.Forms.TextBox();
            this.tbSage = new System.Windows.Forms.TextBox();
            this.tbSsex = new System.Windows.Forms.TextBox();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.tbSno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "所在系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "学号";
            // 
            // tbSdept
            // 
            this.tbSdept.Location = new System.Drawing.Point(149, 186);
            this.tbSdept.Name = "tbSdept";
            this.tbSdept.Size = new System.Drawing.Size(157, 21);
            this.tbSdept.TabIndex = 4;
            // 
            // tbSage
            // 
            this.tbSage.Location = new System.Drawing.Point(149, 159);
            this.tbSage.Name = "tbSage";
            this.tbSage.Size = new System.Drawing.Size(157, 21);
            this.tbSage.TabIndex = 5;
            // 
            // tbSsex
            // 
            this.tbSsex.Location = new System.Drawing.Point(149, 132);
            this.tbSsex.Name = "tbSsex";
            this.tbSsex.Size = new System.Drawing.Size(157, 21);
            this.tbSsex.TabIndex = 6;
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(149, 105);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(157, 21);
            this.tbSname.TabIndex = 7;
            // 
            // tbSno
            // 
            this.tbSno.Location = new System.Drawing.Point(149, 78);
            this.tbSno.Name = "tbSno";
            this.tbSno.Size = new System.Drawing.Size(157, 21);
            this.tbSno.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "插入数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmStuInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSdept);
            this.Controls.Add(this.tbSage);
            this.Controls.Add(this.tbSsex);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbSno);
            this.Controls.Add(this.button1);
            this.Name = "FrmStuInsert";
            this.Text = "FrmStuInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbSdept;
        public System.Windows.Forms.TextBox tbSage;
        public System.Windows.Forms.TextBox tbSsex;
        public System.Windows.Forms.TextBox tbSname;
        public System.Windows.Forms.TextBox tbSno;
        private System.Windows.Forms.Button button1;
    }
}