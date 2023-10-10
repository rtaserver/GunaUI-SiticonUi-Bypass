namespace Bypass_GunaUI___Siticon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.startButton = new Guna.UI2.WinForms.Guna2Button();
            this.hideButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Log = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnJoinTele = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mainNotifyIcon.BalloonTipText = "Made by RizkiKotet";
            this.mainNotifyIcon.BalloonTipTitle = "RTA CODE TEAM";
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "RTA CODE TEAM";
            // 
            // startButton
            // 
            this.startButton.Animated = true;
            this.startButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startButton.FillColor = System.Drawing.Color.Crimson;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(102, 142);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(339, 37);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start Bypass";
            // 
            // hideButton
            // 
            this.hideButton.Animated = true;
            this.hideButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hideButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hideButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hideButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hideButton.FillColor = System.Drawing.Color.Crimson;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.Location = new System.Drawing.Point(360, 12);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(78, 21);
            this.hideButton.TabIndex = 10;
            this.hideButton.Text = "Hide Me";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(490, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 21);
            this.btnClose.TabIndex = 11;
            this.btnClose.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.Crimson;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(444, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 21);
            this.btnMinimize.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "RTA CODE TEAM";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Crimson;
            this.guna2Separator1.Location = new System.Drawing.Point(32, 59);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(479, 11);
            this.guna2Separator1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(143, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "GunaUI And SiticonUI Bypass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(179, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Created By RizkiKotet";
            // 
            // Log
            // 
            this.Log.BorderColor = System.Drawing.Color.Crimson;
            this.Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Log.DefaultText = "Waiting";
            this.Log.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Log.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Log.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Log.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Log.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Log.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.Location = new System.Drawing.Point(102, 185);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.PasswordChar = '\0';
            this.Log.PlaceholderText = "";
            this.Log.ReadOnly = true;
            this.Log.SelectedText = "";
            this.Log.Size = new System.Drawing.Size(339, 40);
            this.Log.TabIndex = 17;
            this.Log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnJoinTele
            // 
            this.btnJoinTele.Animated = true;
            this.btnJoinTele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJoinTele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJoinTele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJoinTele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJoinTele.FillColor = System.Drawing.Color.Crimson;
            this.btnJoinTele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinTele.ForeColor = System.Drawing.Color.White;
            this.btnJoinTele.Location = new System.Drawing.Point(102, 231);
            this.btnJoinTele.Name = "btnJoinTele";
            this.btnJoinTele.Size = new System.Drawing.Size(166, 37);
            this.btnJoinTele.TabIndex = 18;
            this.btnJoinTele.Text = "Join Telegram";
            this.btnJoinTele.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.Animated = true;
            this.btnDonate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonate.FillColor = System.Drawing.Color.Crimson;
            this.btnDonate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.ForeColor = System.Drawing.Color.White;
            this.btnDonate.Location = new System.Drawing.Point(274, 231);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(167, 37);
            this.btnDonate.TabIndex = 19;
            this.btnDonate.Text = "Donate Me";
            this.btnDonate.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(542, 303);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnJoinTele);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTA CODE TEAM | Bypass GunaUI - SiticonUI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private Guna.UI2.WinForms.Guna2Button startButton;
        private Guna.UI2.WinForms.Guna2Button hideButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox Log;
        private Guna.UI2.WinForms.Guna2Button btnDonate;
        private Guna.UI2.WinForms.Guna2Button btnJoinTele;
    }
}

