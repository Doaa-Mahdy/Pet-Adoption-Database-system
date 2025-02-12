namespace Pet_Adoption
{
    partial class EmployeeLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLoginForm));
            EmployeeLogInButton = new Button();
            EmployeeLogInLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // EmployeeLogInButton
            // 
            EmployeeLogInButton.BackColor = Color.DarkOrange;
            EmployeeLogInButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeLogInButton.ForeColor = SystemColors.Window;
            EmployeeLogInButton.Location = new Point(533, 371);
            EmployeeLogInButton.Name = "EmployeeLogInButton";
            EmployeeLogInButton.Size = new Size(127, 49);
            EmployeeLogInButton.TabIndex = 0;
            EmployeeLogInButton.Text = "Log in ";
            EmployeeLogInButton.UseVisualStyleBackColor = false;
            EmployeeLogInButton.Click += EmployeeLogInButton_Click;
            // 
            // EmployeeLogInLabel
            // 
            EmployeeLogInLabel.AutoSize = true;
            EmployeeLogInLabel.BackColor = SystemColors.Window;
            EmployeeLogInLabel.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeLogInLabel.ForeColor = Color.DarkOrange;
            EmployeeLogInLabel.Location = new Point(50, 18);
            EmployeeLogInLabel.Name = "EmployeeLogInLabel";
            EmployeeLogInLabel.Size = new Size(166, 60);
            EmployeeLogInLabel.TabIndex = 1;
            EmployeeLogInLabel.Text = "login";
            EmployeeLogInLabel.TextAlign = ContentAlignment.TopCenter;
            EmployeeLogInLabel.Click += EmployeeLogInLabel_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.DarkOrange;
            textBox1.Location = new Point(409, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 31);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Stencil", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(409, 247);
            label1.Name = "label1";
            label1.Size = new Size(388, 47);
            label1.TabIndex = 3;
            label1.Text = "Enter your name:";
            // 
            // EmployeeLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(861, 638);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(EmployeeLogInLabel);
            Controls.Add(EmployeeLogInButton);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeLoginForm";
            Text = "EmployeeLoginForm";
            Load += EmployeeLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmployeeLogInButton;
        private Label EmployeeLogInLabel;
        private TextBox textBox1;
        private Label label1;
    }
}