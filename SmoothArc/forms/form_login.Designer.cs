namespace SmoothArc
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.linkLabel_forgotPass = new System.Windows.Forms.LinkLabel();
            this.check_remember = new System.Windows.Forms.CheckBox();
            this.linkLabel_exit = new System.Windows.Forms.LinkLabel();
            this.linkLabel_signup = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_forgotPass
            // 
            this.linkLabel_forgotPass.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_forgotPass.AutoSize = true;
            this.linkLabel_forgotPass.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_forgotPass.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel_forgotPass.ForeColor = System.Drawing.Color.Black;
            this.linkLabel_forgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_forgotPass.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_forgotPass.Location = new System.Drawing.Point(317, 405);
            this.linkLabel_forgotPass.Name = "linkLabel_forgotPass";
            this.linkLabel_forgotPass.Size = new System.Drawing.Size(93, 15);
            this.linkLabel_forgotPass.TabIndex = 4;
            this.linkLabel_forgotPass.TabStop = true;
            this.linkLabel_forgotPass.Text = "Şifremi Unuttum";
            this.linkLabel_forgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgotPass_LinkClicked);
            // 
            // check_remember
            // 
            this.check_remember.AutoSize = true;
            this.check_remember.BackColor = System.Drawing.Color.Transparent;
            this.check_remember.FlatAppearance.BorderSize = 0;
            this.check_remember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_remember.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_remember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.check_remember.Location = new System.Drawing.Point(69, 404);
            this.check_remember.Name = "check_remember";
            this.check_remember.Size = new System.Drawing.Size(83, 19);
            this.check_remember.TabIndex = 3;
            this.check_remember.Text = "Beni Hatırla";
            this.check_remember.UseVisualStyleBackColor = false;
            // 
            // linkLabel_exit
            // 
            this.linkLabel_exit.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel_exit.AutoSize = true;
            this.linkLabel_exit.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_exit.Font = new System.Drawing.Font("Open Sans SemiBold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel_exit.ForeColor = System.Drawing.Color.Black;
            this.linkLabel_exit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_exit.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_exit.Location = new System.Drawing.Point(216, 548);
            this.linkLabel_exit.Name = "linkLabel_exit";
            this.linkLabel_exit.Size = new System.Drawing.Size(49, 23);
            this.linkLabel_exit.TabIndex = 6;
            this.linkLabel_exit.TabStop = true;
            this.linkLabel_exit.Text = "Çıkış";
            this.linkLabel_exit.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_exit_LinkClicked);
            // 
            // linkLabel_signup
            // 
            this.linkLabel_signup.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_signup.AutoSize = true;
            this.linkLabel_signup.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_signup.Font = new System.Drawing.Font("Open Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel_signup.ForeColor = System.Drawing.Color.Black;
            this.linkLabel_signup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_signup.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_signup.Location = new System.Drawing.Point(276, 511);
            this.linkLabel_signup.Name = "linkLabel_signup";
            this.linkLabel_signup.Size = new System.Drawing.Size(64, 23);
            this.linkLabel_signup.TabIndex = 5;
            this.linkLabel_signup.TabStop = true;
            this.linkLabel_signup.Text = "Üye Ol";
            this.linkLabel_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_signup_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(135, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hesabın Yok Mu ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(154, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giriş Yap";
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.textbox_pass);
            this.panel_login.Controls.Add(this.textbox_username);
            this.panel_login.Controls.Add(this.panel1);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.pictureBox2);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.linkLabel_signup);
            this.panel_login.Controls.Add(this.linkLabel_exit);
            this.panel_login.Controls.Add(this.check_remember);
            this.panel_login.Controls.Add(this.linkLabel_forgotPass);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(1000, 600);
            this.panel_login.TabIndex = 0;
            this.panel_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_login_MouseDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(168, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail veya Şifre Yanlış!!";
            this.label3.Visible = false;
            // 
            // btn_login
            // 
            this.btn_login.Animated = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_login.BorderRadius = 20;
            this.btn_login.BorderThickness = 2;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_login.Font = new System.Drawing.Font("Open Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(151, 455);
            this.btn_login.Name = "btn_login";
            this.btn_login.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_login.ShadowDecoration.BorderRadius = 25;
            this.btn_login.ShadowDecoration.Depth = 70;
            this.btn_login.ShadowDecoration.Enabled = true;
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_login.Size = new System.Drawing.Size(170, 45);
            this.btn_login.TabIndex = 39;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // textbox_pass
            // 
            this.textbox_pass.Animated = true;
            this.textbox_pass.AutoRoundedCorners = true;
            this.textbox_pass.BackColor = System.Drawing.Color.Transparent;
            this.textbox_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_pass.BorderRadius = 19;
            this.textbox_pass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.textbox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_pass.DefaultText = "";
            this.textbox_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_pass.DisabledState.Parent = this.textbox_pass;
            this.textbox_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_pass.FocusedState.Parent = this.textbox_pass;
            this.textbox_pass.Font = new System.Drawing.Font("Open Sans", 12F);
            this.textbox_pass.ForeColor = System.Drawing.Color.Black;
            this.textbox_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_pass.HoverState.Parent = this.textbox_pass;
            this.textbox_pass.IconLeft = ((System.Drawing.Image)(resources.GetObject("textbox_pass.IconLeft")));
            this.textbox_pass.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.textbox_pass.IconLeftSize = new System.Drawing.Size(16, 20);
            this.textbox_pass.IconRight = global::SmoothArc.Properties.Resources.göz_closed;
            this.textbox_pass.IconRightOffset = new System.Drawing.Point(10, 0);
            this.textbox_pass.IconRightSize = new System.Drawing.Size(20, 9);
            this.textbox_pass.Location = new System.Drawing.Point(55, 358);
            this.textbox_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_pass.Name = "textbox_pass";
            this.textbox_pass.PasswordChar = '\0';
            this.textbox_pass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textbox_pass.PlaceholderText = "Şifre";
            this.textbox_pass.SelectedText = "";
            this.textbox_pass.ShadowDecoration.BorderRadius = 19;
            this.textbox_pass.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.textbox_pass.ShadowDecoration.Enabled = true;
            this.textbox_pass.ShadowDecoration.Parent = this.textbox_pass;
            this.textbox_pass.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 4, 4, 5);
            this.textbox_pass.Size = new System.Drawing.Size(369, 41);
            this.textbox_pass.TabIndex = 38;
            this.textbox_pass.TextOffset = new System.Drawing.Point(5, 0);
            this.textbox_pass.UseSystemPasswordChar = true;
            this.textbox_pass.IconRightClick += new System.EventHandler(this.textbox_pass_IconRightClick);
            this.textbox_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_pass_KeyDown);
            this.textbox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_pass_KeyPress);
            // 
            // textbox_username
            // 
            this.textbox_username.Animated = true;
            this.textbox_username.AutoRoundedCorners = true;
            this.textbox_username.BackColor = System.Drawing.Color.Transparent;
            this.textbox_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_username.BorderRadius = 19;
            this.textbox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_username.DefaultText = "";
            this.textbox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_username.DisabledState.Parent = this.textbox_username;
            this.textbox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_username.FocusedState.Parent = this.textbox_username;
            this.textbox_username.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_username.ForeColor = System.Drawing.Color.Black;
            this.textbox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_username.HoverState.Parent = this.textbox_username;
            this.textbox_username.IconLeft = ((System.Drawing.Image)(resources.GetObject("textbox_username.IconLeft")));
            this.textbox_username.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.textbox_username.Location = new System.Drawing.Point(55, 304);
            this.textbox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.PasswordChar = '\0';
            this.textbox_username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textbox_username.PlaceholderText = "E-mail";
            this.textbox_username.SelectedText = "";
            this.textbox_username.ShadowDecoration.BorderRadius = 19;
            this.textbox_username.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.textbox_username.ShadowDecoration.Enabled = true;
            this.textbox_username.ShadowDecoration.Parent = this.textbox_username;
            this.textbox_username.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 4, 4, 5);
            this.textbox_username.Size = new System.Drawing.Size(369, 41);
            this.textbox_username.TabIndex = 37;
            this.textbox_username.TextOffset = new System.Drawing.Point(5, 0);
            this.textbox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_username_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(188, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smooth Academy";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_login_MouseDown);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_forgotPass;
        private System.Windows.Forms.CheckBox check_remember;
        private System.Windows.Forms.LinkLabel linkLabel_exit;
        private System.Windows.Forms.LinkLabel linkLabel_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_username;
        private Guna.UI2.WinForms.Guna2TextBox textbox_pass;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.Label label3;
    }
}

