namespace SmoothArc
{
    partial class form_loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_loading));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_questions = new System.Windows.Forms.Button();
            this.button_calendar = new System.Windows.Forms.Button();
            this.panel_profile_logo = new System.Windows.Forms.Panel();
            this.Picture_profile = new SmoothArc.CirclePicturebox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_lessons = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_profile_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_profile)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_questions
            // 
            this.button_questions.BackColor = System.Drawing.Color.Transparent;
            this.button_questions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_questions.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_questions.FlatAppearance.BorderSize = 0;
            this.button_questions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_questions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button_questions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_questions.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_questions.ForeColor = System.Drawing.Color.White;
            this.button_questions.Image = ((System.Drawing.Image)(resources.GetObject("button_questions.Image")));
            this.button_questions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_questions.Location = new System.Drawing.Point(580, 333);
            this.button_questions.Name = "button_questions";
            this.button_questions.Size = new System.Drawing.Size(74, 74);
            this.button_questions.TabIndex = 15;
            this.button_questions.Text = "SORULAR";
            this.button_questions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_questions.UseVisualStyleBackColor = false;
            this.button_questions.Visible = false;
            this.button_questions.Click += new System.EventHandler(this.button_questions_Click);
            // 
            // button_calendar
            // 
            this.button_calendar.BackColor = System.Drawing.Color.Transparent;
            this.button_calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_calendar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_calendar.FlatAppearance.BorderSize = 0;
            this.button_calendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_calendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button_calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_calendar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_calendar.ForeColor = System.Drawing.Color.White;
            this.button_calendar.Image = ((System.Drawing.Image)(resources.GetObject("button_calendar.Image")));
            this.button_calendar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_calendar.Location = new System.Drawing.Point(500, 333);
            this.button_calendar.Name = "button_calendar";
            this.button_calendar.Size = new System.Drawing.Size(74, 74);
            this.button_calendar.TabIndex = 14;
            this.button_calendar.Text = "TAKVİM";
            this.button_calendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_calendar.UseVisualStyleBackColor = false;
            this.button_calendar.Visible = false;
            this.button_calendar.Click += new System.EventHandler(this.button_calendar_Click);
            // 
            // panel_profile_logo
            // 
            this.panel_profile_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_profile_logo.Controls.Add(this.Picture_profile);
            this.panel_profile_logo.Controls.Add(this.label1);
            this.panel_profile_logo.Location = new System.Drawing.Point(340, 333);
            this.panel_profile_logo.Name = "panel_profile_logo";
            this.panel_profile_logo.Size = new System.Drawing.Size(74, 74);
            this.panel_profile_logo.TabIndex = 12;
            this.panel_profile_logo.Visible = false;
            this.panel_profile_logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_profile_logo_MouseClick);
            this.panel_profile_logo.MouseLeave += new System.EventHandler(this.panel_profile_MouseLeave);
            this.panel_profile_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_profile_MouseMove);
            // 
            // Picture_profile
            // 
            this.Picture_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Picture_profile.Image = ((System.Drawing.Image)(resources.GetObject("Picture_profile.Image")));
            this.Picture_profile.Location = new System.Drawing.Point(20, 5);
            this.Picture_profile.Name = "Picture_profile";
            this.Picture_profile.Size = new System.Drawing.Size(35, 35);
            this.Picture_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_profile.TabIndex = 48;
            this.Picture_profile.TabStop = false;
            this.Picture_profile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Picture_profile_MouseClick);
            this.Picture_profile.MouseLeave += new System.EventHandler(this.Picture_profile_MouseLeave);
            this.Picture_profile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_profile_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // button_lessons
            // 
            this.button_lessons.BackColor = System.Drawing.Color.Transparent;
            this.button_lessons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_lessons.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_lessons.FlatAppearance.BorderSize = 0;
            this.button_lessons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_lessons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button_lessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lessons.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_lessons.ForeColor = System.Drawing.Color.White;
            this.button_lessons.Image = ((System.Drawing.Image)(resources.GetObject("button_lessons.Image")));
            this.button_lessons.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_lessons.Location = new System.Drawing.Point(420, 333);
            this.button_lessons.Name = "button_lessons";
            this.button_lessons.Size = new System.Drawing.Size(74, 74);
            this.button_lessons.TabIndex = 13;
            this.button_lessons.Text = "DERSLER";
            this.button_lessons.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_lessons.UseVisualStyleBackColor = false;
            this.button_lessons.Visible = false;
            this.button_lessons.Click += new System.EventHandler(this.button_lessons_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(-1, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(60, 60);
            this.button_exit.TabIndex = 16;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Visible = false;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            this.button_exit.MouseHover += new System.EventHandler(this.button_exit_MouseHover);
            this.button_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_exit_MouseMove);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.button_exit);
            this.guna2Panel1.Location = new System.Drawing.Point(929, 524);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(72, 77);
            this.guna2Panel1.TabIndex = 17;
            this.guna2Panel1.Visible = false;
            this.guna2Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseClick);
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.guna2Panel1_MouseLeave);
            this.guna2Panel1.MouseHover += new System.EventHandler(this.guna2Panel1_MouseHover);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.button1);
            this.guna2Panel2.Location = new System.Drawing.Point(2, 524);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(72, 77);
            this.guna2Panel2.TabIndex = 18;
            this.guna2Panel2.Visible = false;
            this.guna2Panel2.Click += new System.EventHandler(this.guna2Panel2_Click);
            this.guna2Panel2.MouseLeave += new System.EventHandler(this.guna2Panel2_MouseLeave);
            this.guna2Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 16;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.Interval = 250;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // form_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.button_questions);
            this.Controls.Add(this.button_calendar);
            this.Controls.Add(this.panel_profile_logo);
            this.Controls.Add(this.button_lessons);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smooth Academy";
            this.Load += new System.EventHandler(this.form_loading_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_loading_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_profile_logo.ResumeLayout(false);
            this.panel_profile_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_profile)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_questions;
        private System.Windows.Forms.Button button_calendar;
        private System.Windows.Forms.Panel panel_profile_logo;
        private System.Windows.Forms.Button button_lessons;
        private System.Windows.Forms.Button button_exit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button button1;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private CirclePicturebox Picture_profile;
        public System.Windows.Forms.Label label1;
    }
}