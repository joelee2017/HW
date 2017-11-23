namespace HW
{
    partial class FrmCreate2
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
            this.BtnLogOn = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ScuExAAtext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ScuExtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckPassWordtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.PassWordtext = new System.Windows.Forms.TextBox();
            this.UserNametext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogOn
            // 
            this.BtnLogOn.BackColor = System.Drawing.Color.White;
            this.BtnLogOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogOn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOn.Location = new System.Drawing.Point(333, 390);
            this.BtnLogOn.Name = "BtnLogOn";
            this.BtnLogOn.Size = new System.Drawing.Size(101, 32);
            this.BtnLogOn.TabIndex = 35;
            this.BtnLogOn.Text = "登入";
            this.BtnLogOn.UseVisualStyleBackColor = false;
            this.BtnLogOn.Click += new System.EventHandler(this.BtnLogOn_Click_1);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.White;
            this.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCreate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(206, 390);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(101, 32);
            this.BtnCreate.TabIndex = 34;
            this.BtnCreate.Text = "建立";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "安全性解答";
            // 
            // ScuExAAtext
            // 
            this.ScuExAAtext.Location = new System.Drawing.Point(215, 331);
            this.ScuExAAtext.Name = "ScuExAAtext";
            this.ScuExAAtext.Size = new System.Drawing.Size(219, 22);
            this.ScuExAAtext.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "安全性問題";
            // 
            // ScuExtext
            // 
            this.ScuExtext.Location = new System.Drawing.Point(215, 280);
            this.ScuExtext.Name = "ScuExtext";
            this.ScuExtext.Size = new System.Drawing.Size(219, 22);
            this.ScuExtext.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "電子郵件";
            // 
            // CheckPassWordtext
            // 
            this.CheckPassWordtext.Location = new System.Drawing.Point(215, 178);
            this.CheckPassWordtext.Name = "CheckPassWordtext";
            this.CheckPassWordtext.Size = new System.Drawing.Size(219, 22);
            this.CheckPassWordtext.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "確認密碼";
            // 
            // Emailtext
            // 
            this.Emailtext.Location = new System.Drawing.Point(215, 225);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(219, 22);
            this.Emailtext.TabIndex = 26;
            // 
            // PassWordtext
            // 
            this.PassWordtext.Location = new System.Drawing.Point(215, 125);
            this.PassWordtext.Name = "PassWordtext";
            this.PassWordtext.Size = new System.Drawing.Size(219, 22);
            this.PassWordtext.TabIndex = 25;
            // 
            // UserNametext
            // 
            this.UserNametext.Location = new System.Drawing.Point(215, 68);
            this.UserNametext.Name = "UserNametext";
            this.UserNametext.Size = new System.Drawing.Size(219, 22);
            this.UserNametext.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "使用者名稱";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "建立使用者";
            // 
            // FrmCreate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(486, 473);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnLogOn);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ScuExAAtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ScuExtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckPassWordtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.PassWordtext);
            this.Controls.Add(this.UserNametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmCreate2";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.UserNametext, 0);
            this.Controls.SetChildIndex(this.PassWordtext, 0);
            this.Controls.SetChildIndex(this.Emailtext, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.CheckPassWordtext, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ScuExtext, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.ScuExAAtext, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.BtnCreate, 0);
            this.Controls.SetChildIndex(this.BtnLogOn, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogOn;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ScuExAAtext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ScuExtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CheckPassWordtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.TextBox PassWordtext;
        private System.Windows.Forms.TextBox UserNametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}
