namespace Resala_HR
{
    partial class F_Login
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
            this.B_SignIn = new System.Windows.Forms.Button();
            this.CB_RememberMe = new System.Windows.Forms.CheckBox();
            this.HLB_ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.L_FailLog = new System.Windows.Forms.Label();
            this.TB_Password = new Resala_HR.PlaceholderTextBox();
            this.TB_Username = new Resala_HR.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // B_SignIn
            // 
            this.B_SignIn.Location = new System.Drawing.Point(123, 189);
            this.B_SignIn.Name = "B_SignIn";
            this.B_SignIn.Size = new System.Drawing.Size(100, 23);
            this.B_SignIn.TabIndex = 2;
            this.B_SignIn.Text = "دخول";
            this.B_SignIn.UseVisualStyleBackColor = true;
            this.B_SignIn.Click += new System.EventHandler(this.B_login_Click);
            // 
            // CB_RememberMe
            // 
            this.CB_RememberMe.AutoSize = true;
            this.CB_RememberMe.Location = new System.Drawing.Point(123, 114);
            this.CB_RememberMe.Name = "CB_RememberMe";
            this.CB_RememberMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_RememberMe.Size = new System.Drawing.Size(100, 17);
            this.CB_RememberMe.TabIndex = 5;
            this.CB_RememberMe.Text = "تذكر كلمة المرور";
            this.CB_RememberMe.UseVisualStyleBackColor = true;
            // 
            // HLB_ForgetPassword
            // 
            this.HLB_ForgetPassword.AutoSize = true;
            this.HLB_ForgetPassword.LinkColor = System.Drawing.Color.Black;
            this.HLB_ForgetPassword.Location = new System.Drawing.Point(129, 134);
            this.HLB_ForgetPassword.Name = "HLB_ForgetPassword";
            this.HLB_ForgetPassword.Size = new System.Drawing.Size(85, 13);
            this.HLB_ForgetPassword.TabIndex = 6;
            this.HLB_ForgetPassword.TabStop = true;
            this.HLB_ForgetPassword.Text = "نسيت كلمة المرور";
            // 
            // L_FailLog
            // 
            this.L_FailLog.ForeColor = System.Drawing.Color.Red;
            this.L_FailLog.Location = new System.Drawing.Point(41, 147);
            this.L_FailLog.Name = "L_FailLog";
            this.L_FailLog.Size = new System.Drawing.Size(235, 39);
            this.L_FailLog.TabIndex = 8;
            this.L_FailLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(96, 78);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PlaceholderText = "كلمة المرور";
            this.TB_Password.Size = new System.Drawing.Size(140, 20);
            this.TB_Password.TabIndex = 10;
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(96, 52);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.PlaceholderText = "اسم المستخدم ";
            this.TB_Username.Size = new System.Drawing.Size(140, 20);
            this.TB_Username.TabIndex = 9;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 252);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.L_FailLog);
            this.Controls.Add(this.HLB_ForgetPassword);
            this.Controls.Add(this.CB_RememberMe);
            this.Controls.Add(this.B_SignIn);
            this.Name = "F_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رسالة - قوافل داخلية ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_SignIn;
        private System.Windows.Forms.CheckBox CB_RememberMe;
        private System.Windows.Forms.LinkLabel HLB_ForgetPassword;
        private System.Windows.Forms.Label L_FailLog;
        private PlaceholderTextBox TB_Username;
        private PlaceholderTextBox TB_Password;
    }
}

