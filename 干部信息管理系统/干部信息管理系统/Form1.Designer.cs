namespace 干部信息管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rdo_CityLevel = new System.Windows.Forms.RadioButton();
            this.rdo_CountyLevel = new System.Windows.Forms.RadioButton();
            this.rdo_CountryLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdo_CityLevel
            // 
            this.rdo_CityLevel.AutoSize = true;
            this.rdo_CityLevel.Location = new System.Drawing.Point(198, 38);
            this.rdo_CityLevel.Name = "rdo_CityLevel";
            this.rdo_CityLevel.Size = new System.Drawing.Size(83, 16);
            this.rdo_CityLevel.TabIndex = 0;
            this.rdo_CityLevel.TabStop = true;
            this.rdo_CityLevel.Text = "市（厅）级";
            this.rdo_CityLevel.UseVisualStyleBackColor = true;
            // 
            // rdo_CountyLevel
            // 
            this.rdo_CountyLevel.AutoSize = true;
            this.rdo_CountyLevel.Location = new System.Drawing.Point(332, 37);
            this.rdo_CountyLevel.Name = "rdo_CountyLevel";
            this.rdo_CountyLevel.Size = new System.Drawing.Size(83, 16);
            this.rdo_CountyLevel.TabIndex = 1;
            this.rdo_CountyLevel.TabStop = true;
            this.rdo_CountyLevel.Text = "县（处）级";
            this.rdo_CountyLevel.UseVisualStyleBackColor = true;
            // 
            // rdo_CountryLevel
            // 
            this.rdo_CountryLevel.AutoSize = true;
            this.rdo_CountryLevel.Location = new System.Drawing.Point(477, 38);
            this.rdo_CountryLevel.Name = "rdo_CountryLevel";
            this.rdo_CountryLevel.Size = new System.Drawing.Size(83, 16);
            this.rdo_CountryLevel.TabIndex = 2;
            this.rdo_CountryLevel.TabStop = true;
            this.rdo_CountryLevel.Text = "乡（科）级";
            this.rdo_CountryLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(234, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "干部信息管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(211, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "口令";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(257, 149);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(275, 21);
            this.tb_Password.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(332, 190);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_CountryLevel);
            this.Controls.Add(this.rdo_CountyLevel);
            this.Controls.Add(this.rdo_CityLevel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_CityLevel;
        private System.Windows.Forms.RadioButton rdo_CountyLevel;
        private System.Windows.Forms.RadioButton rdo_CountryLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}

