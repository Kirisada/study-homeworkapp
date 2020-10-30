namespace Workapp01
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
            this.txtSNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btNext = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // txtSNo
            // 
            this.txtSNo.Enabled = false;
            this.txtSNo.Location = new System.Drawing.Point(19, 81);
            this.txtSNo.Name = "txtSNo";
            this.txtSNo.Size = new System.Drawing.Size(375, 20);
            this.txtSNo.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(19, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student No :";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(19, 159);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(375, 20);
            this.txtTel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "E - mail :";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(19, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(375, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(239, 288);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(58, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(184, 293);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(35, 13);
            this.lblRecord.TabIndex = 14;
            this.lblRecord.Text = "label8";
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(104, 288);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(58, 23);
            this.btback.TabIndex = 1;
            this.btback.Text = "<";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(40, 288);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(58, 23);
            this.btFirst.TabIndex = 0;
            this.btFirst.Text = "|<";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(303, 288);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(58, 23);
            this.btLast.TabIndex = 3;
            this.btLast.Text = ">|";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Major :";
            // 
            // txtMajor
            // 
            this.txtMajor.Enabled = false;
            this.txtMajor.Location = new System.Drawing.Point(19, 236);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(375, 20);
            this.txtMajor.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 332);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMajor;
    }
}

