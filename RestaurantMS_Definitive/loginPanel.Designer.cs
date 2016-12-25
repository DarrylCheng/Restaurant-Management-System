namespace RestaurantMS_Definitive
{
    partial class loginPanel
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
            this.passwordText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.errorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.errorIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordText
            // 
            this.passwordText.Depth = 0;
            this.passwordText.Hint = "";
            this.passwordText.Location = new System.Drawing.Point(99, 144);
            this.passwordText.MaxLength = 32767;
            this.passwordText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '\0';
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.Size = new System.Drawing.Size(278, 23);
            this.passwordText.TabIndex = 8;
            this.passwordText.TabStop = false;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Depth = 0;
            this.usernameText.Hint = "";
            this.usernameText.Location = new System.Drawing.Point(99, 94);
            this.usernameText.MaxLength = 32767;
            this.usernameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameText.Name = "usernameText";
            this.usernameText.PasswordChar = '\0';
            this.usernameText.SelectedText = "";
            this.usernameText.SelectionLength = 0;
            this.usernameText.SelectionStart = 0;
            this.usernameText.Size = new System.Drawing.Size(278, 23);
            this.usernameText.TabIndex = 7;
            this.usernameText.TabStop = false;
            this.usernameText.UseSystemPasswordChar = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(12, 144);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 19);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLabel.Location = new System.Drawing.Point(12, 98);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 19);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Depth = 0;
            this.errorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(51, 200);
            this.errorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(213, 19);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Wrong username or password!";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Image = global::RestaurantMS_Definitive.Properties.Resources.login;
            this.loginButton.Location = new System.Drawing.Point(268, 184);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(109, 57);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // errorIcon
            // 
            this.errorIcon.Image = global::RestaurantMS_Definitive.Properties.Resources.ic_error_black_48dp_2x;
            this.errorIcon.Location = new System.Drawing.Point(12, 192);
            this.errorIcon.Name = "errorIcon";
            this.errorIcon.Size = new System.Drawing.Size(33, 36);
            this.errorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIcon.TabIndex = 10;
            this.errorIcon.TabStop = false;
            // 
            // loginPanel
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 253);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.errorIcon);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.MaximizeBox = false;
            this.Name = "loginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management System";
            this.Load += new System.EventHandler(this.loginPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordText;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameText;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private System.Windows.Forms.PictureBox errorIcon;
        private MaterialSkin.Controls.MaterialLabel errorLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

