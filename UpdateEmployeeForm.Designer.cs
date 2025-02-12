namespace Pet_Adoption
{
    partial class UpdateEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeForm));
            textBoxEmployeeID = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Email = new Label();
            label4 = new Label();
            textBoxEmail = new TextBox();
            textBoxSalary = new TextBox();
            buttonRetrieve = new Button();
            buttonUpdate = new Button();
            label3 = new Label();
            textBoxSupervisorID = new TextBox();
            SuspendLayout();
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.Location = new Point(232, 132);
            textBoxEmployeeID.Margin = new Padding(2);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.Size = new Size(358, 31);
            textBoxEmployeeID.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(232, 368);
            textBoxName.Margin = new Padding(2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(358, 31);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PapayaWhip;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(232, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 35);
            label1.TabIndex = 2;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkKhaki;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(232, 336);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.DarkKhaki;
            Email.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = SystemColors.Window;
            Email.Location = new Point(232, 401);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(83, 30);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkKhaki;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(232, 466);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 5;
            label4.Text = "Salary";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(232, 433);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(358, 31);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(232, 498);
            textBoxSalary.Margin = new Padding(2);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(358, 31);
            textBoxSalary.TabIndex = 8;
            // 
            // buttonRetrieve
            // 
            buttonRetrieve.Location = new Point(371, 184);
            buttonRetrieve.Margin = new Padding(2);
            buttonRetrieve.Name = "buttonRetrieve";
            buttonRetrieve.Size = new Size(112, 34);
            buttonRetrieve.TabIndex = 10;
            buttonRetrieve.Text = "Retrieve";
            buttonRetrieve.UseVisualStyleBackColor = true;
            buttonRetrieve.Click += buttonRetrieve_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.DarkKhaki;
            buttonUpdate.Location = new Point(464, 533);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(126, 39);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkKhaki;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(232, 267);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 30);
            label3.TabIndex = 12;
            label3.Text = "Supervisor ID";
            label3.Click += label3_Click;
            // 
            // textBoxSupervisorID
            // 
            textBoxSupervisorID.Location = new Point(232, 301);
            textBoxSupervisorID.Margin = new Padding(4, 4, 4, 4);
            textBoxSupervisorID.Name = "textBoxSupervisorID";
            textBoxSupervisorID.Size = new Size(358, 31);
            textBoxSupervisorID.TabIndex = 13;
            // 
            // UpdateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(824, 773);
            Controls.Add(textBoxSupervisorID);
            Controls.Add(label3);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRetrieve);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmployeeID);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "UpdateEmployeeForm";
            Text = "UpdateEmployeeForm";
            Load += UpdateEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmployeeID;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Label Email;
        private Label label4;
        private TextBox textBoxEmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxSalary;
        private Button buttonRetrieve;
        private Button buttonUpdate;
        private Label label3;
        private TextBox textBoxSupervisorID;
    }
}