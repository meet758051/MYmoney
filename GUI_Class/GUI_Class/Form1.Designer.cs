
namespace GUI_Class
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kkick = new System.Windows.Forms.Label();
            this.fsh = new System.Windows.Forms.Label();
            this.ice = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btm_0313 = new System.Windows.Forms.Button();
            this.btmctof = new System.Windows.Forms.Button();
            this.button_math = new System.Windows.Forms.Button();
            this.button_Timer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kkick
            // 
            this.kkick.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kkick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kkick.Image = ((System.Drawing.Image)(resources.GetObject("kkick.Image")));
            this.kkick.Location = new System.Drawing.Point(4, -5);
            this.kkick.Name = "kkick";
            this.kkick.Size = new System.Drawing.Size(802, 458);
            this.kkick.TabIndex = 0;
            this.kkick.Click += new System.EventHandler(this.label1_Click);
            // 
            // fsh
            // 
            this.fsh.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fsh.ForeColor = System.Drawing.Color.Teal;
            this.fsh.Location = new System.Drawing.Point(565, 57);
            this.fsh.Name = "fsh";
            this.fsh.Size = new System.Drawing.Size(223, 59);
            this.fsh.TabIndex = 1;
            this.fsh.Text = "魚口渴了";
            // 
            // ice
            // 
            this.ice.AutoSize = true;
            this.ice.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ice.ForeColor = System.Drawing.Color.Navy;
            this.ice.Location = new System.Drawing.Point(523, 9);
            this.ice.Name = "ice";
            this.ice.Size = new System.Drawing.Size(265, 48);
            this.ice.TabIndex = 2;
            this.ice.Text = "被冰塊燙傷";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(572, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(216, 48);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "點我一下";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btm_0313
            // 
            this.btm_0313.Location = new System.Drawing.Point(12, 12);
            this.btm_0313.Name = "btm_0313";
            this.btm_0313.Size = new System.Drawing.Size(172, 68);
            this.btm_0313.TabIndex = 4;
            this.btm_0313.Text = "不要點我";
            this.btm_0313.UseVisualStyleBackColor = true;
            this.btm_0313.Click += new System.EventHandler(this.btm_0313_Click);
            // 
            // btmctof
            // 
            this.btmctof.Location = new System.Drawing.Point(216, 16);
            this.btmctof.Name = "btmctof";
            this.btmctof.Size = new System.Drawing.Size(185, 64);
            this.btmctof.TabIndex = 5;
            this.btmctof.Text = "其中考-攝氏轉華氏";
            this.btmctof.UseVisualStyleBackColor = true;
            this.btmctof.Click += new System.EventHandler(this.btmctof_Click);
            // 
            // button_math
            // 
            this.button_math.Location = new System.Drawing.Point(20, 98);
            this.button_math.Name = "button_math";
            this.button_math.Size = new System.Drawing.Size(164, 66);
            this.button_math.TabIndex = 6;
            this.button_math.Text = "加減乘除";
            this.button_math.UseVisualStyleBackColor = true;
            this.button_math.Click += new System.EventHandler(this.button_math_Click);
            // 
            // button_Timer
            // 
            this.button_Timer.Location = new System.Drawing.Point(216, 98);
            this.button_Timer.Name = "button_Timer";
            this.button_Timer.Size = new System.Drawing.Size(185, 66);
            this.button_Timer.TabIndex = 7;
            this.button_Timer.Text = "時間";
            this.button_Timer.UseVisualStyleBackColor = true;
            this.button_Timer.Click += new System.EventHandler(this.button_Timer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "核取方塊";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "版面配置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Timer);
            this.Controls.Add(this.button_math);
            this.Controls.Add(this.btmctof);
            this.Controls.Add(this.btm_0313);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ice);
            this.Controls.Add(this.fsh);
            this.Controls.Add(this.kkick);
            this.Name = "Form1";
            this.Text = "N10310028";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kkick;
        private System.Windows.Forms.Label fsh;
        private System.Windows.Forms.Label ice;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btm_0313;
        private System.Windows.Forms.Button btmctof;
        private System.Windows.Forms.Button button_math;
        private System.Windows.Forms.Button button_Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

