namespace WindowsFormsApp5
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
            this.passwordlbl = new System.Windows.Forms.Label();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.passwordbtn = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(210, 103);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 0;
            this.passwordlbl.Text = "Password";
            this.passwordlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(367, 103);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(100, 20);
            this.passwordtxtbox.TabIndex = 1;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.passwordtxtbox_TextChanged);
            // 
            // passwordbtn
            // 
            this.passwordbtn.Location = new System.Drawing.Point(275, 146);
            this.passwordbtn.Name = "passwordbtn";
            this.passwordbtn.Size = new System.Drawing.Size(75, 23);
            this.passwordbtn.TabIndex = 2;
            this.passwordbtn.Text = "Submit";
            this.passwordbtn.UseVisualStyleBackColor = true;
            this.passwordbtn.Click += new System.EventHandler(this.passwordbtn_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(292, 203);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.passwordbtn);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.passwordlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Button passwordbtn;
        private System.Windows.Forms.Label lbl2;
    }
}

