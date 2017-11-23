namespace HW
{
    partial class FrmLogOn2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtenExit = new System.Windows.Forms.Button();
            this.BtnLogOn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PassWordtext = new System.Windows.Forms.TextBox();
            this.UserNametext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.White;
            this.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCreate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(37, 297);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(101, 32);
            this.BtnCreate.TabIndex = 16;
            this.BtnCreate.Text = "建立";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click_1);
            // 
            // BtenExit
            // 
            this.BtenExit.BackColor = System.Drawing.Color.White;
            this.BtenExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtenExit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtenExit.Location = new System.Drawing.Point(353, 297);
            this.BtenExit.Name = "BtenExit";
            this.BtenExit.Size = new System.Drawing.Size(101, 32);
            this.BtenExit.TabIndex = 15;
            this.BtenExit.Text = "結束";
            this.BtenExit.UseVisualStyleBackColor = false;
            this.BtenExit.Click += new System.EventHandler(this.BtenExit_Click_1);
            // 
            // BtnLogOn
            // 
            this.BtnLogOn.BackColor = System.Drawing.Color.White;
            this.BtnLogOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogOn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOn.Location = new System.Drawing.Point(236, 297);
            this.BtnLogOn.Name = "BtnLogOn";
            this.BtnLogOn.Size = new System.Drawing.Size(101, 32);
            this.BtnLogOn.TabIndex = 14;
            this.BtnLogOn.Text = "登入";
            this.BtnLogOn.UseVisualStyleBackColor = false;
            this.BtnLogOn.Click += new System.EventHandler(this.BtnLogOn_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(53, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(254, 28);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "記憶密碼供下次使用";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PassWordtext
            // 
            this.PassWordtext.Location = new System.Drawing.Point(210, 129);
            this.PassWordtext.Name = "PassWordtext";
            this.PassWordtext.Size = new System.Drawing.Size(219, 22);
            this.PassWordtext.TabIndex = 12;
            // 
            // UserNametext
            // 
            this.UserNametext.Location = new System.Drawing.Point(210, 72);
            this.UserNametext.Name = "UserNametext";
            this.UserNametext.Size = new System.Drawing.Size(219, 22);
            this.UserNametext.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "使用者名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "登        入";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "忘記密碼";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogOn2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(490, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtenExit);
            this.Controls.Add(this.BtnLogOn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PassWordtext);
            this.Controls.Add(this.UserNametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmLogOn2";
            this.Load += new System.EventHandler(this.FrmLogOn2_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.UserNametext, 0);
            this.Controls.SetChildIndex(this.PassWordtext, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.BtnLogOn, 0);
            this.Controls.SetChildIndex(this.BtenExit, 0);
            this.Controls.SetChildIndex(this.BtnCreate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtenExit;
        private System.Windows.Forms.Button BtnLogOn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox PassWordtext;
        private System.Windows.Forms.TextBox UserNametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
