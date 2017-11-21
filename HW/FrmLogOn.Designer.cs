namespace HW
{
    partial class FrmLogOn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNametext = new System.Windows.Forms.TextBox();
            this.PassWordtext = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnLogOn = new System.Windows.Forms.Button();
            this.BtenExit = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "登入";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "使用者名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "密碼";
            // 
            // UserNametext
            // 
            this.UserNametext.Location = new System.Drawing.Point(192, 92);
            this.UserNametext.Name = "UserNametext";
            this.UserNametext.Size = new System.Drawing.Size(219, 22);
            this.UserNametext.TabIndex = 3;
            // 
            // PassWordtext
            // 
            this.PassWordtext.Location = new System.Drawing.Point(192, 149);
            this.PassWordtext.Name = "PassWordtext";
            this.PassWordtext.Size = new System.Drawing.Size(219, 22);
            this.PassWordtext.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(35, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(254, 28);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "記憶密碼供下次使用";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnLogOn
            // 
            this.BtnLogOn.BackColor = System.Drawing.Color.White;
            this.BtnLogOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogOn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOn.Location = new System.Drawing.Point(218, 317);
            this.BtnLogOn.Name = "BtnLogOn";
            this.BtnLogOn.Size = new System.Drawing.Size(101, 32);
            this.BtnLogOn.TabIndex = 6;
            this.BtnLogOn.Text = "登入";
            this.BtnLogOn.UseVisualStyleBackColor = false;
            this.BtnLogOn.Click += new System.EventHandler(this.BtnLogOn_Click);
            // 
            // BtenExit
            // 
            this.BtenExit.BackColor = System.Drawing.Color.White;
            this.BtenExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtenExit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtenExit.Location = new System.Drawing.Point(335, 317);
            this.BtenExit.Name = "BtenExit";
            this.BtenExit.Size = new System.Drawing.Size(101, 32);
            this.BtenExit.TabIndex = 7;
            this.BtenExit.Text = "結束";
            this.BtenExit.UseVisualStyleBackColor = false;
            this.BtenExit.Click += new System.EventHandler(this.BtenExit_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.White;
            this.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCreate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(19, 317);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(101, 32);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "建立";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLogOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 387);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtenExit);
            this.Controls.Add(this.BtnLogOn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PassWordtext);
            this.Controls.Add(this.UserNametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogOn";
            this.Text = "FrmLogOn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNametext;
        private System.Windows.Forms.TextBox PassWordtext;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnLogOn;
        private System.Windows.Forms.Button BtenExit;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}