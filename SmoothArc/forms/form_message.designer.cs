namespace SmoothArc.forms
{
    partial class form_message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_message));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_teachermode = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(205, -2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(40, 36);
            this.button_exit.TabIndex = 17;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mesaj";
            // 
            // btn_save
            // 
            this.btn_save.Animated = true;
            this.btn_save.AutoRoundedCorners = true;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_save.BorderRadius = 10;
            this.btn_save.BorderThickness = 2;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(147, 109);
            this.btn_save.Name = "btn_save";
            this.btn_save.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_save.ShadowDecoration.BorderRadius = 25;
            this.btn_save.ShadowDecoration.Depth = 70;
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_save.Size = new System.Drawing.Size(77, 23);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Tamam";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mesaj";
            // 
            // textbox_teachermode
            // 
            this.textbox_teachermode.Animated = true;
            this.textbox_teachermode.AutoRoundedCorners = true;
            this.textbox_teachermode.BackColor = System.Drawing.Color.Transparent;
            this.textbox_teachermode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_teachermode.BorderRadius = 16;
            this.textbox_teachermode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_teachermode.DefaultText = "";
            this.textbox_teachermode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_teachermode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_teachermode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_teachermode.DisabledState.Parent = this.textbox_teachermode;
            this.textbox_teachermode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_teachermode.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_teachermode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_teachermode.FocusedState.Parent = this.textbox_teachermode;
            this.textbox_teachermode.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_teachermode.ForeColor = System.Drawing.Color.Black;
            this.textbox_teachermode.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textbox_teachermode.HoverState.Parent = this.textbox_teachermode;
            this.textbox_teachermode.Location = new System.Drawing.Point(13, 68);
            this.textbox_teachermode.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_teachermode.Multiline = true;
            this.textbox_teachermode.Name = "textbox_teachermode";
            this.textbox_teachermode.PasswordChar = '\0';
            this.textbox_teachermode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textbox_teachermode.PlaceholderText = "";
            this.textbox_teachermode.SelectedText = "";
            this.textbox_teachermode.ShadowDecoration.BorderRadius = 35;
            this.textbox_teachermode.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.textbox_teachermode.ShadowDecoration.Enabled = true;
            this.textbox_teachermode.ShadowDecoration.Parent = this.textbox_teachermode;
            this.textbox_teachermode.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 4, 4, 5);
            this.textbox_teachermode.Size = new System.Drawing.Size(219, 35);
            this.textbox_teachermode.TabIndex = 55;
            this.textbox_teachermode.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // form_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(245, 144);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textbox_teachermode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_message_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textbox_teachermode;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}