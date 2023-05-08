
namespace GUI_Class
{
    partial class Form_button
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
            this.btm0313 = new System.Windows.Forms.Button();
            this.btmadd = new System.Windows.Forms.Button();
            this.lab0 = new System.Windows.Forms.Label();
            this.btn_reubce = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btm0313
            // 
            this.btm0313.AutoSize = true;
            this.btm0313.Location = new System.Drawing.Point(12, 12);
            this.btm0313.Name = "btm0313";
            this.btm0313.Size = new System.Drawing.Size(161, 73);
            this.btm0313.TabIndex = 0;
            this.btm0313.Text = "請按我一下";
            this.btm0313.UseVisualStyleBackColor = true;
            this.btm0313.Click += new System.EventHandler(this.btm0313_Click);
            // 
            // btmadd
            // 
            this.btmadd.Location = new System.Drawing.Point(310, 62);
            this.btmadd.Name = "btmadd";
            this.btmadd.Size = new System.Drawing.Size(75, 23);
            this.btmadd.TabIndex = 1;
            this.btmadd.Text = "加";
            this.btmadd.UseVisualStyleBackColor = true;
            this.btmadd.Click += new System.EventHandler(this.btmadd_Click);
            // 
            // lab0
            // 
            this.lab0.AutoSize = true;
            this.lab0.Location = new System.Drawing.Point(304, 42);
            this.lab0.Name = "lab0";
            this.lab0.Size = new System.Drawing.Size(11, 12);
            this.lab0.TabIndex = 2;
            this.lab0.Text = "0";
            // 
            // btn_reubce
            // 
            this.btn_reubce.Location = new System.Drawing.Point(229, 62);
            this.btn_reubce.Name = "btn_reubce";
            this.btn_reubce.Size = new System.Drawing.Size(75, 23);
            this.btn_reubce.TabIndex = 3;
            this.btn_reubce.Text = "減";
            this.btn_reubce.UseVisualStyleBackColor = true;
            this.btn_reubce.Click += new System.EventHandler(this.btn_reubce_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "點我沒有任何意義";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "變大";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reubce);
            this.Controls.Add(this.lab0);
            this.Controls.Add(this.btmadd);
            this.Controls.Add(this.btm0313);
            this.Name = "Form_button";
            this.Text = "Form_button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm0313;
        private System.Windows.Forms.Button btmadd;
        private System.Windows.Forms.Label lab0;
        private System.Windows.Forms.Button btn_reubce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}