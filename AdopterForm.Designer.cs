namespace Pet_Adoption
{
    partial class AdopterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdopterForm));
            nameTextBox = new TextBox();
            phoneNumTextBox = new TextBox();
            addressTextBox = new TextBox();
            emailTextBox = new TextBox();
            nameLabel = new Label();
            emailLabel = new Label();
            phoneNumberLabel = new Label();
            addressLabel = new Label();
            signUpButton = new Button();
            label1 = new Label();
            label2 = new Label();
            logInEmailtextBox = new TextBox();
            LogInButton = new Button();
            label3 = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(193, 172);
            nameTextBox.Margin = new Padding(4, 4, 4, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(307, 31);
            nameTextBox.TabIndex = 0;
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.Location = new Point(193, 366);
            phoneNumTextBox.Margin = new Padding(4, 4, 4, 4);
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(307, 31);
            phoneNumTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(193, 461);
            addressTextBox.Margin = new Padding(4, 4, 4, 4);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(307, 31);
            addressTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(193, 265);
            emailTextBox.Margin = new Padding(4, 4, 4, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(307, 31);
            emailTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = SystemColors.ButtonHighlight;
            nameLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.Green;
            nameLabel.Location = new Point(193, 133);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(90, 35);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            nameLabel.Click += label1_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = SystemColors.ButtonHighlight;
            emailLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.Green;
            emailLabel.Location = new Point(193, 222);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(97, 35);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = SystemColors.ButtonHighlight;
            phoneNumberLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberLabel.ForeColor = Color.Green;
            phoneNumberLabel.Location = new Point(193, 317);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(233, 35);
            phoneNumberLabel.TabIndex = 6;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = SystemColors.ButtonHighlight;
            addressLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.ForeColor = Color.Green;
            addressLabel.Location = new Point(193, 406);
            addressLabel.Margin = new Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(137, 35);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address";
            addressLabel.Click += addressLabel_Click;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.Green;
            signUpButton.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = SystemColors.ButtonHighlight;
            signUpButton.Location = new Point(257, 500);
            signUpButton.Margin = new Padding(4, 4, 4, 4);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(138, 36);
            signUpButton.TabIndex = 8;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(513, 500);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 40);
            label1.TabIndex = 9;
            label1.Text = "OR";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(592, 328);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 35);
            label2.TabIndex = 10;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // logInEmailtextBox
            // 
            logInEmailtextBox.Location = new Point(592, 366);
            logInEmailtextBox.Margin = new Padding(4, 4, 4, 4);
            logInEmailtextBox.Name = "logInEmailtextBox";
            logInEmailtextBox.Size = new Size(296, 31);
            logInEmailtextBox.TabIndex = 11;
            logInEmailtextBox.TextChanged += logInEmailtextBox_TextChanged;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.Green;
            LogInButton.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = SystemColors.ButtonHighlight;
            LogInButton.Location = new Point(660, 500);
            LogInButton.Margin = new Padding(4, 4, 4, 4);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(142, 36);
            LogInButton.TabIndex = 12;
            LogInButton.Text = "Sign In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(578, 222);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 44);
            label3.TabIndex = 13;
            label3.Text = "Log In";
            label3.Click += label3_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Green;
            backButton.Location = new Point(483, 620);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(118, 36);
            backButton.TabIndex = 14;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += button1_Click;
            // 
            // AdopterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1081, 773);
            Controls.Add(backButton);
            Controls.Add(label3);
            Controls.Add(LogInButton);
            Controls.Add(logInEmailtextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUpButton);
            Controls.Add(addressLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(emailTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(phoneNumTextBox);
            Controls.Add(nameTextBox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdopterForm";
            Text = "Form2";
            Load += AdopterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox phoneNumTextBox;
        private TextBox addressTextBox;
        private TextBox emailTextBox;
        private Label nameLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label addressLabel;
        private Button signUpButton;
        private Label label1;
        private Label label2;
        private TextBox logInEmailtextBox;
        private Button LogInButton;
        private Label label3;
        private Button backButton;
    }
}