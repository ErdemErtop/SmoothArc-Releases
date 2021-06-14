namespace SmoothArc
{
    partial class form_questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_questions));
            this.listbox_panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new SmoothArc.tools.ListBoxMultiline();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_questions = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_teachermode = new Guna.UI2.WinForms.Guna2TextBox();
            this.listbox_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_panel
            // 
            this.listbox_panel.BackColor = System.Drawing.Color.Transparent;
            this.listbox_panel.BorderRadius = 50;
            this.listbox_panel.Controls.Add(this.panel1);
            this.listbox_panel.Controls.Add(this.listBox1);
            this.listbox_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.listbox_panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.listbox_panel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.listbox_panel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.listbox_panel.Location = new System.Drawing.Point(26, 58);
            this.listbox_panel.Name = "listbox_panel";
            this.listbox_panel.ShadowDecoration.BorderRadius = 50;
            this.listbox_panel.ShadowDecoration.Depth = 10;
            this.listbox_panel.ShadowDecoration.Enabled = true;
            this.listbox_panel.ShadowDecoration.Parent = this.listbox_panel;
            this.listbox_panel.Size = new System.Drawing.Size(597, 328);
            this.listbox_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(84, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(241, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 22);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "tıklayınız.";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru ve cevapları görmek için derse sahip olmalısnız.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(79, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ders satın almak için ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 8;
            this.listBox1.Location = new System.Drawing.Point(14, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(565, 291);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Animated = true;
            this.btn_save.AutoRoundedCorners = true;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_save.BorderRadius = 19;
            this.btn_save.BorderThickness = 2;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_save.Font = new System.Drawing.Font("Open Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(509, 395);
            this.btn_save.Name = "btn_save";
            this.btn_save.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_save.ShadowDecoration.BorderRadius = 25;
            this.btn_save.ShadowDecoration.Depth = 70;
            this.btn_save.ShadowDecoration.Enabled = true;
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_save.Size = new System.Drawing.Size(114, 40);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "Gönder";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textbox_questions
            // 
            this.textbox_questions.Animated = true;
            this.textbox_questions.AutoRoundedCorners = true;
            this.textbox_questions.BackColor = System.Drawing.Color.Transparent;
            this.textbox_questions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_questions.BorderRadius = 19;
            this.textbox_questions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_questions.DefaultText = "";
            this.textbox_questions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_questions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_questions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_questions.DisabledState.Parent = this.textbox_questions;
            this.textbox_questions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_questions.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_questions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_questions.FocusedState.Parent = this.textbox_questions;
            this.textbox_questions.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_questions.ForeColor = System.Drawing.Color.Black;
            this.textbox_questions.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textbox_questions.HoverState.Parent = this.textbox_questions;
            this.textbox_questions.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.textbox_questions.Location = new System.Drawing.Point(26, 395);
            this.textbox_questions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_questions.Multiline = true;
            this.textbox_questions.Name = "textbox_questions";
            this.textbox_questions.PasswordChar = '\0';
            this.textbox_questions.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textbox_questions.PlaceholderText = "Soru...";
            this.textbox_questions.SelectedText = "";
            this.textbox_questions.ShadowDecoration.BorderRadius = 35;
            this.textbox_questions.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.textbox_questions.ShadowDecoration.Enabled = true;
            this.textbox_questions.ShadowDecoration.Parent = this.textbox_questions;
            this.textbox_questions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 4, 4, 5);
            this.textbox_questions.Size = new System.Drawing.Size(476, 40);
            this.textbox_questions.TabIndex = 41;
            this.textbox_questions.TextOffset = new System.Drawing.Point(20, 0);
            this.textbox_questions.TextChanged += new System.EventHandler(this.textbox_question_TextChanged);
            // 
            // ComboBox
            // 
            this.ComboBox.AutoRoundedCorners = true;
            this.ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBox.BorderRadius = 17;
            this.ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBox.FocusedState.Parent = this.ComboBox;
            this.ComboBox.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBox.ForeColor = System.Drawing.Color.Black;
            this.ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBox.HoverState.Parent = this.ComboBox;
            this.ComboBox.ItemHeight = 30;
            this.ComboBox.ItemsAppearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBox.ItemsAppearance.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.ComboBox.ItemsAppearance.Parent = this.ComboBox;
            this.ComboBox.Location = new System.Drawing.Point(381, 9);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.ShadowDecoration.BorderRadius = 19;
            this.ComboBox.ShadowDecoration.Enabled = true;
            this.ComboBox.ShadowDecoration.Parent = this.ComboBox;
            this.ComboBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ComboBox.Size = new System.Drawing.Size(242, 36);
            this.ComboBox.TabIndex = 42;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // textbox_search
            // 
            this.textbox_search.Animated = true;
            this.textbox_search.AutoRoundedCorners = true;
            this.textbox_search.BackColor = System.Drawing.Color.Transparent;
            this.textbox_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_search.BorderRadius = 17;
            this.textbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_search.DefaultText = "";
            this.textbox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_search.DisabledState.Parent = this.textbox_search;
            this.textbox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_search.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_search.FocusedState.Parent = this.textbox_search;
            this.textbox_search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_search.ForeColor = System.Drawing.Color.Black;
            this.textbox_search.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textbox_search.HoverState.Parent = this.textbox_search;
            this.textbox_search.IconLeft = ((System.Drawing.Image)(resources.GetObject("textbox_search.IconLeft")));
            this.textbox_search.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.textbox_search.Location = new System.Drawing.Point(26, 9);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_search.Multiline = true;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.PasswordChar = '\0';
            this.textbox_search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textbox_search.PlaceholderText = "Arama...";
            this.textbox_search.SelectedText = "";
            this.textbox_search.ShadowDecoration.BorderRadius = 35;
            this.textbox_search.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.textbox_search.ShadowDecoration.Enabled = true;
            this.textbox_search.ShadowDecoration.Parent = this.textbox_search;
            this.textbox_search.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 4, 4, 5);
            this.textbox_search.Size = new System.Drawing.Size(348, 36);
            this.textbox_search.TabIndex = 43;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            // 
            // textbox_teachermode
            // 
            this.textbox_teachermode.Animated = true;
            this.textbox_teachermode.AutoRoundedCorners = true;
            this.textbox_teachermode.BackColor = System.Drawing.Color.Transparent;
            this.textbox_teachermode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_teachermode.BorderRadius = 19;
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
            this.textbox_teachermode.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_teachermode.ForeColor = System.Drawing.Color.Black;
            this.textbox_teachermode.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textbox_teachermode.HoverState.Parent = this.textbox_teachermode;
            this.textbox_teachermode.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.textbox_teachermode.Location = new System.Drawing.Point(26, 345);
            this.textbox_teachermode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_teachermode.Multiline = true;
            this.textbox_teachermode.Name = "textbox_teachermode";
            this.textbox_teachermode.PasswordChar = '\0';
            this.textbox_teachermode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textbox_teachermode.PlaceholderText = "Soru...";
            this.textbox_teachermode.SelectedText = "";
            this.textbox_teachermode.ShadowDecoration.BorderRadius = 35;
            this.textbox_teachermode.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.textbox_teachermode.ShadowDecoration.Enabled = true;
            this.textbox_teachermode.ShadowDecoration.Parent = this.textbox_teachermode;
            this.textbox_teachermode.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 4, 4, 5);
            this.textbox_teachermode.Size = new System.Drawing.Size(476, 40);
            this.textbox_teachermode.TabIndex = 44;
            this.textbox_teachermode.TextOffset = new System.Drawing.Point(20, 0);
            this.textbox_teachermode.Visible = false;
            this.textbox_teachermode.TextChanged += new System.EventHandler(this.textbox_teachermode_TextChanged);
            // 
            // form_questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(659, 449);
            this.Controls.Add(this.textbox_teachermode);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.textbox_questions);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.listbox_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_questions";
            this.Text = "Sorular";
            this.listbox_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel listbox_panel;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2TextBox textbox_questions;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox;
        private Guna.UI2.WinForms.Guna2TextBox textbox_search;
        private Guna.UI2.WinForms.Guna2TextBox textbox_teachermode;
        private tools.ListBoxMultiline listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}