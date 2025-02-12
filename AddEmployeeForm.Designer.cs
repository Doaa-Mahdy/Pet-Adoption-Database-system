using System.Xml.Linq;

namespace Pet_Adoption
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtSalary = new TextBox();
            button1 = new Button();
            lblEmailError = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(41, 228);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(384, 31);
            txtName.TabIndex = 0;
            txtName.Text = "Name";
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 307);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(384, 31);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "Email";
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(41, 397);
            txtSalary.Margin = new Padding(2);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(384, 31);
            txtSalary.TabIndex = 2;
            txtSalary.Text = "salary ";
            txtSalary.TextChanged += txtSalary_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(149, 472);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(158, 71);
            button1.TabIndex = 3;
            button1.Text = "enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Firebrick;
            lblEmailError.Location = new Point(166, 280);
            lblEmailError.Margin = new Padding(2, 0, 2, 0);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(111, 25);
            lblEmailError.TabIndex = 4;
            lblEmailError.Text = "lblEmailError";
            lblEmailError.Visible = false;
            lblEmailError.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSalmon;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(39, 172);
            label1.Name = "label1";
            label1.Size = new Size(113, 44);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSalmon;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(39, 261);
            label2.Name = "label2";
            label2.Size = new Size(122, 44);
            label2.TabIndex = 6;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSalmon;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(41, 340);
            label3.Name = "label3";
            label3.Size = new Size(158, 44);
            label3.TabIndex = 7;
            label3.Text = "Salary ";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 656);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEmailError);
            Controls.Add(button1);
            Controls.Add(txtSalary);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            Load += AddEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtSalary;
        private Button button1;
        private Label lblEmailError;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}