namespace Mart_Management_System
{
    partial class Login_Form
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
            this.Content_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.warning1_txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showPassword_box = new System.Windows.Forms.CheckBox();
            this.login_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.password_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.userName_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.shop_logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.app_logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.close_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.signup_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Content_Panel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shop_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Content_Panel
            // 
            this.Content_Panel.BackColor = System.Drawing.Color.White;
            this.Content_Panel.Controls.Add(this.signup_btn);
            this.Content_Panel.Controls.Add(this.flowLayoutPanel2);
            this.Content_Panel.Controls.Add(this.label2);
            this.Content_Panel.Controls.Add(this.showPassword_box);
            this.Content_Panel.Controls.Add(this.login_btn);
            this.Content_Panel.Controls.Add(this.password_box);
            this.Content_Panel.Controls.Add(this.userName_box);
            this.Content_Panel.Controls.Add(this.shop_logo);
            this.Content_Panel.Controls.Add(this.label1);
            this.Content_Panel.Controls.Add(this.app_logo);
            this.Content_Panel.Controls.Add(this.close_btn);
            this.Content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_Panel.Location = new System.Drawing.Point(10, 10);
            this.Content_Panel.Name = "Content_Panel";
            this.Content_Panel.ShadowDecoration.Parent = this.Content_Panel;
            this.Content_Panel.Size = new System.Drawing.Size(797, 448);
            this.Content_Panel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.warning1_txt);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(401, 302);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(324, 44);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // warning1_txt
            // 
            this.warning1_txt.AutoSize = true;
            this.warning1_txt.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning1_txt.ForeColor = System.Drawing.Color.Red;
            this.warning1_txt.Location = new System.Drawing.Point(3, 0);
            this.warning1_txt.Name = "warning1_txt";
            this.warning1_txt.Size = new System.Drawing.Size(79, 19);
            this.warning1_txt.TabIndex = 11;
            this.warning1_txt.Text = "warning 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(72, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mart Management System";
            // 
            // showPassword_box
            // 
            this.showPassword_box.AutoSize = true;
            this.showPassword_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword_box.ForeColor = System.Drawing.Color.RoyalBlue;
            this.showPassword_box.Location = new System.Drawing.Point(599, 273);
            this.showPassword_box.Name = "showPassword_box";
            this.showPassword_box.Size = new System.Drawing.Size(126, 23);
            this.showPassword_box.TabIndex = 10;
            this.showPassword_box.Text = "Show Password";
            this.showPassword_box.UseVisualStyleBackColor = true;
            this.showPassword_box.CheckedChanged += new System.EventHandler(this.showPassword_box_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.login_btn.BorderRadius = 20;
            this.login_btn.BorderThickness = 1;
            this.login_btn.CheckedState.Parent = this.login_btn;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.CustomImages.Parent = this.login_btn;
            this.login_btn.FillColor = System.Drawing.Color.RoyalBlue;
            this.login_btn.FillColor2 = System.Drawing.Color.DarkBlue;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.login_btn.HoverState.FillColor2 = System.Drawing.Color.DarkBlue;
            this.login_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.Parent = this.login_btn;
            this.login_btn.Location = new System.Drawing.Point(599, 367);
            this.login_btn.Name = "login_btn";
            this.login_btn.ShadowDecoration.Parent = this.login_btn;
            this.login_btn.Size = new System.Drawing.Size(126, 45);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_box
            // 
            this.password_box.BorderColor = System.Drawing.Color.RoyalBlue;
            this.password_box.BorderRadius = 20;
            this.password_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_box.DefaultText = "";
            this.password_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_box.DisabledState.Parent = this.password_box;
            this.password_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_box.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.password_box.FocusedState.FillColor = System.Drawing.Color.White;
            this.password_box.FocusedState.ForeColor = System.Drawing.Color.White;
            this.password_box.FocusedState.Parent = this.password_box;
            this.password_box.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.password_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.ForeColor = System.Drawing.Color.RoyalBlue;
            this.password_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_box.HoverState.Parent = this.password_box;
            this.password_box.Location = new System.Drawing.Point(401, 219);
            this.password_box.Margin = new System.Windows.Forms.Padding(4);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '\0';
            this.password_box.PlaceholderForeColor = System.Drawing.Color.RoyalBlue;
            this.password_box.PlaceholderText = "Password";
            this.password_box.SelectedText = "";
            this.password_box.ShadowDecoration.Parent = this.password_box;
            this.password_box.Size = new System.Drawing.Size(324, 47);
            this.password_box.TabIndex = 8;
            this.password_box.UseSystemPasswordChar = true;
            // 
            // userName_box
            // 
            this.userName_box.BorderColor = System.Drawing.Color.RoyalBlue;
            this.userName_box.BorderRadius = 20;
            this.userName_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_box.DefaultText = "";
            this.userName_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userName_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userName_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName_box.DisabledState.Parent = this.userName_box;
            this.userName_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName_box.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.userName_box.FocusedState.FillColor = System.Drawing.Color.White;
            this.userName_box.FocusedState.ForeColor = System.Drawing.Color.White;
            this.userName_box.FocusedState.Parent = this.userName_box;
            this.userName_box.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.userName_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_box.ForeColor = System.Drawing.Color.RoyalBlue;
            this.userName_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userName_box.HoverState.Parent = this.userName_box;
            this.userName_box.Location = new System.Drawing.Point(401, 157);
            this.userName_box.Margin = new System.Windows.Forms.Padding(4);
            this.userName_box.Name = "userName_box";
            this.userName_box.PasswordChar = '\0';
            this.userName_box.PlaceholderForeColor = System.Drawing.Color.RoyalBlue;
            this.userName_box.PlaceholderText = "Username";
            this.userName_box.SelectedText = "";
            this.userName_box.ShadowDecoration.Parent = this.userName_box;
            this.userName_box.Size = new System.Drawing.Size(324, 44);
            this.userName_box.TabIndex = 7;
            // 
            // shop_logo
            // 
            this.shop_logo.BackColor = System.Drawing.Color.Transparent;
            this.shop_logo.FillColor = System.Drawing.Color.RoyalBlue;
            this.shop_logo.Location = new System.Drawing.Point(65, 124);
            this.shop_logo.Name = "shop_logo";
            this.shop_logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.shop_logo.ShadowDecoration.Parent = this.shop_logo;
            this.shop_logo.Size = new System.Drawing.Size(250, 250);
            this.shop_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shop_logo.TabIndex = 5;
            this.shop_logo.TabStop = false;
            this.shop_logo.Click += new System.EventHandler(this.shop_logo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(400, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // app_logo
            // 
            this.app_logo.BackColor = System.Drawing.Color.Transparent;
            this.app_logo.FillColor = System.Drawing.Color.RoyalBlue;
            this.app_logo.Location = new System.Drawing.Point(10, 3);
            this.app_logo.Name = "app_logo";
            this.app_logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.app_logo.ShadowDecoration.Parent = this.app_logo;
            this.app_logo.Size = new System.Drawing.Size(55, 55);
            this.app_logo.TabIndex = 2;
            this.app_logo.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.CustomIconSize = 12F;
            this.close_btn.FillColor = System.Drawing.Color.Transparent;
            this.close_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.close_btn.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_btn.HoverState.Parent = this.close_btn;
            this.close_btn.IconColor = System.Drawing.Color.Red;
            this.close_btn.Location = new System.Drawing.Point(734, 10);
            this.close_btn.Name = "close_btn";
            this.close_btn.ShadowDecoration.Parent = this.close_btn;
            this.close_btn.Size = new System.Drawing.Size(60, 40);
            this.close_btn.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.Content_Panel;
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Transparent;
            this.signup_btn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.signup_btn.BorderRadius = 20;
            this.signup_btn.BorderThickness = 1;
            this.signup_btn.CheckedState.Parent = this.signup_btn;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.CustomImages.Parent = this.signup_btn;
            this.signup_btn.FillColor = System.Drawing.Color.Transparent;
            this.signup_btn.FillColor2 = System.Drawing.Color.Transparent;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signup_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.signup_btn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.signup_btn.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.signup_btn.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.signup_btn.HoverState.Parent = this.signup_btn;
            this.signup_btn.Location = new System.Drawing.Point(401, 367);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.ShadowDecoration.Parent = this.signup_btn;
            this.signup_btn.Size = new System.Drawing.Size(126, 45);
            this.signup_btn.TabIndex = 13;
            this.signup_btn.Text = "Sign up";
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(817, 468);
            this.ControlBox = false;
            this.Controls.Add(this.Content_Panel);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Form";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.Content_Panel.ResumeLayout(false);
            this.Content_Panel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shop_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Content_Panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox app_logo;
        private Guna.UI2.WinForms.Guna2ControlBox close_btn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox shop_logo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton login_btn;
        private Guna.UI2.WinForms.Guna2TextBox password_box;
        private Guna.UI2.WinForms.Guna2TextBox userName_box;
        private System.Windows.Forms.CheckBox showPassword_box;
        private System.Windows.Forms.Label warning1_txt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton signup_btn;
    }
}

