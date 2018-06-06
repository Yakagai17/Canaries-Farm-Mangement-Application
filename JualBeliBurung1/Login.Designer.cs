namespace JualBeliBurung
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_owner = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_admin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_login_owner = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_owner = new System.Windows.Forms.Panel();
            this.box_kode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.box_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_admin = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_owner.SuspendLayout();
            this.panel_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_owner
            // 
            this.btn_owner.Active = false;
            this.btn_owner.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_owner.BackColor = System.Drawing.Color.Teal;
            this.btn_owner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_owner.BorderRadius = 0;
            this.btn_owner.ButtonText = "Login As Owner";
            this.btn_owner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_owner.DisabledColor = System.Drawing.Color.Gray;
            this.btn_owner.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_owner.Iconimage = null;
            this.btn_owner.Iconimage_right = null;
            this.btn_owner.Iconimage_right_Selected = null;
            this.btn_owner.Iconimage_Selected = null;
            this.btn_owner.IconMarginLeft = 0;
            this.btn_owner.IconMarginRight = 0;
            this.btn_owner.IconRightVisible = true;
            this.btn_owner.IconRightZoom = 0D;
            this.btn_owner.IconVisible = true;
            this.btn_owner.IconZoom = 90D;
            this.btn_owner.IsTab = false;
            this.btn_owner.Location = new System.Drawing.Point(117, 174);
            this.btn_owner.Name = "btn_owner";
            this.btn_owner.Normalcolor = System.Drawing.Color.Teal;
            this.btn_owner.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_owner.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_owner.selected = false;
            this.btn_owner.Size = new System.Drawing.Size(110, 36);
            this.btn_owner.TabIndex = 1;
            this.btn_owner.Text = "Login As Owner";
            this.btn_owner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_owner.Textcolor = System.Drawing.Color.White;
            this.btn_owner.TextFont = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_owner.Click += new System.EventHandler(this.btn_owner_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Active = false;
            this.btn_admin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_admin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_admin.BorderRadius = 0;
            this.btn_admin.ButtonText = "Login As Admin";
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_admin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_admin.Iconimage = null;
            this.btn_admin.Iconimage_right = null;
            this.btn_admin.Iconimage_right_Selected = null;
            this.btn_admin.Iconimage_Selected = null;
            this.btn_admin.IconMarginLeft = 0;
            this.btn_admin.IconMarginRight = 0;
            this.btn_admin.IconRightVisible = true;
            this.btn_admin.IconRightZoom = 0D;
            this.btn_admin.IconVisible = true;
            this.btn_admin.IconZoom = 90D;
            this.btn_admin.IsTab = false;
            this.btn_admin.Location = new System.Drawing.Point(233, 174);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btn_admin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_admin.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_admin.selected = false;
            this.btn_admin.Size = new System.Drawing.Size(110, 36);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "Login As Admin";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_admin.Textcolor = System.Drawing.Color.White;
            this.btn_admin.TextFont = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_login_owner
            // 
            this.btn_login_owner.Active = false;
            this.btn_login_owner.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login_owner.BackColor = System.Drawing.Color.Teal;
            this.btn_login_owner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login_owner.BorderRadius = 0;
            this.btn_login_owner.ButtonText = "LOGIN";
            this.btn_login_owner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_owner.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login_owner.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login_owner.Iconimage = null;
            this.btn_login_owner.Iconimage_right = null;
            this.btn_login_owner.Iconimage_right_Selected = null;
            this.btn_login_owner.Iconimage_Selected = null;
            this.btn_login_owner.IconMarginLeft = 0;
            this.btn_login_owner.IconMarginRight = 0;
            this.btn_login_owner.IconRightVisible = true;
            this.btn_login_owner.IconRightZoom = 0D;
            this.btn_login_owner.IconVisible = true;
            this.btn_login_owner.IconZoom = 90D;
            this.btn_login_owner.IsTab = false;
            this.btn_login_owner.Location = new System.Drawing.Point(7, 160);
            this.btn_login_owner.Name = "btn_login_owner";
            this.btn_login_owner.Normalcolor = System.Drawing.Color.Teal;
            this.btn_login_owner.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login_owner.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login_owner.selected = false;
            this.btn_login_owner.Size = new System.Drawing.Size(213, 33);
            this.btn_login_owner.TabIndex = 3;
            this.btn_login_owner.Text = "LOGIN";
            this.btn_login_owner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login_owner.Textcolor = System.Drawing.Color.White;
            this.btn_login_owner.TextFont = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_owner.Click += new System.EventHandler(this.btn_login_owner_Click);
            // 
            // panel_owner
            // 
            this.panel_owner.Controls.Add(this.box_kode);
            this.panel_owner.Controls.Add(this.label1);
            this.panel_owner.Controls.Add(this.btn_login_owner);
            this.panel_owner.Location = new System.Drawing.Point(2, 216);
            this.panel_owner.Name = "panel_owner";
            this.panel_owner.Size = new System.Drawing.Size(226, 197);
            this.panel_owner.TabIndex = 4;
            // 
            // box_kode
            // 
            this.box_kode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.box_kode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.box_kode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.box_kode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_kode.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_kode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_kode.HintForeColor = System.Drawing.Color.DarkSlateGray;
            this.box_kode.HintText = "";
            this.box_kode.isPassword = false;
            this.box_kode.LineFocusedColor = System.Drawing.Color.Blue;
            this.box_kode.LineIdleColor = System.Drawing.Color.DarkSlateGray;
            this.box_kode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.box_kode.LineThickness = 3;
            this.box_kode.Location = new System.Drawing.Point(40, 39);
            this.box_kode.Margin = new System.Windows.Forms.Padding(4);
            this.box_kode.MaxLength = 32767;
            this.box_kode.Name = "box_kode";
            this.box_kode.Size = new System.Drawing.Size(146, 29);
            this.box_kode.TabIndex = 1;
            this.box_kode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "VERIFICATION CODE";
            // 
            // lbl_x
            // 
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_x.Location = new System.Drawing.Point(434, 9);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(30, 17);
            this.lbl_x.TabIndex = 5;
            this.lbl_x.Text = "X";
            this.lbl_x.Click += new System.EventHandler(this.lbl_x_Click);
            // 
            // panel_admin
            // 
            this.panel_admin.Controls.Add(this.box_pass);
            this.panel_admin.Controls.Add(this.label3);
            this.panel_admin.Controls.Add(this.box_id);
            this.panel_admin.Controls.Add(this.label2);
            this.panel_admin.Controls.Add(this.btn_login_admin);
            this.panel_admin.Location = new System.Drawing.Point(234, 216);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(226, 197);
            this.panel_admin.TabIndex = 5;
            // 
            // box_pass
            // 
            this.box_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.box_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.box_pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.box_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_pass.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_pass.HintForeColor = System.Drawing.Color.DarkSlateGray;
            this.box_pass.HintText = "";
            this.box_pass.isPassword = false;
            this.box_pass.LineFocusedColor = System.Drawing.Color.Blue;
            this.box_pass.LineIdleColor = System.Drawing.Color.DarkSlateGray;
            this.box_pass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.box_pass.LineThickness = 3;
            this.box_pass.Location = new System.Drawing.Point(85, 74);
            this.box_pass.Margin = new System.Windows.Forms.Padding(4);
            this.box_pass.MaxLength = 32767;
            this.box_pass.Name = "box_pass";
            this.box_pass.Size = new System.Drawing.Size(118, 29);
            this.box_pass.TabIndex = 2;
            this.box_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // box_id
            // 
            this.box_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.box_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.box_id.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.box_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_id.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_id.HintForeColor = System.Drawing.Color.DarkSlateGray;
            this.box_id.HintText = "";
            this.box_id.isPassword = false;
            this.box_id.LineFocusedColor = System.Drawing.Color.Blue;
            this.box_id.LineIdleColor = System.Drawing.Color.DarkSlateGray;
            this.box_id.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.box_id.LineThickness = 3;
            this.box_id.Location = new System.Drawing.Point(48, 39);
            this.box_id.Margin = new System.Windows.Forms.Padding(4);
            this.box_id.MaxLength = 32767;
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(155, 29);
            this.box_id.TabIndex = 1;
            this.box_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // btn_login_admin
            // 
            this.btn_login_admin.Active = false;
            this.btn_login_admin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login_admin.BackColor = System.Drawing.Color.Teal;
            this.btn_login_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login_admin.BorderRadius = 0;
            this.btn_login_admin.ButtonText = "LOGIN";
            this.btn_login_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_admin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login_admin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login_admin.Iconimage = null;
            this.btn_login_admin.Iconimage_right = null;
            this.btn_login_admin.Iconimage_right_Selected = null;
            this.btn_login_admin.Iconimage_Selected = null;
            this.btn_login_admin.IconMarginLeft = 0;
            this.btn_login_admin.IconMarginRight = 0;
            this.btn_login_admin.IconRightVisible = true;
            this.btn_login_admin.IconRightZoom = 0D;
            this.btn_login_admin.IconVisible = true;
            this.btn_login_admin.IconZoom = 90D;
            this.btn_login_admin.IsTab = false;
            this.btn_login_admin.Location = new System.Drawing.Point(7, 160);
            this.btn_login_admin.Name = "btn_login_admin";
            this.btn_login_admin.Normalcolor = System.Drawing.Color.Teal;
            this.btn_login_admin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login_admin.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login_admin.selected = false;
            this.btn_login_admin.Size = new System.Drawing.Size(213, 33);
            this.btn_login_admin.TabIndex = 3;
            this.btn_login_admin.Text = "LOGIN";
            this.btn_login_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login_admin.Textcolor = System.Drawing.Color.White;
            this.btn_login_admin.TextFont = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_admin.Click += new System.EventHandler(this.btn_login_admin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(463, 448);
            this.Controls.Add(this.panel_admin);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.panel_owner);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_owner);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_owner.ResumeLayout(false);
            this.panel_owner.PerformLayout();
            this.panel_admin.ResumeLayout(false);
            this.panel_admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_owner;
        private Bunifu.Framework.UI.BunifuFlatButton btn_admin;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login_owner;
        private System.Windows.Forms.Panel panel_owner;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_kode;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Panel panel_admin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_pass;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_id;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login_admin;
    }
}

