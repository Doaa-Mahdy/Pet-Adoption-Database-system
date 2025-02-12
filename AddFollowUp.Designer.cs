namespace Pet_Adoption
{
    partial class AddFollowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFollowUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            employeeIDTextBox = new TextBox();
            adopterIDTextBox = new TextBox();
            followUpDatePicker = new DateTimePicker();
            notesTextBox = new TextBox();
            addButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(261, 234);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 35);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(261, 316);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 35);
            label2.TabIndex = 1;
            label2.Text = "AdopterID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(261, 395);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(252, 35);
            label3.TabIndex = 2;
            label3.Text = "Follow Up Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(261, 469);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 35);
            label4.TabIndex = 3;
            label4.Text = "Notes";
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(261, 273);
            employeeIDTextBox.Margin = new Padding(4, 4, 4, 4);
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.Size = new Size(450, 31);
            employeeIDTextBox.TabIndex = 4;
            // 
            // adopterIDTextBox
            // 
            adopterIDTextBox.Location = new Point(261, 357);
            adopterIDTextBox.Margin = new Padding(4, 4, 4, 4);
            adopterIDTextBox.Name = "adopterIDTextBox";
            adopterIDTextBox.Size = new Size(450, 31);
            adopterIDTextBox.TabIndex = 5;
            // 
            // followUpDatePicker
            // 
            followUpDatePicker.Location = new Point(261, 434);
            followUpDatePicker.Margin = new Padding(4, 4, 4, 4);
            followUpDatePicker.Name = "followUpDatePicker";
            followUpDatePicker.Size = new Size(450, 31);
            followUpDatePicker.TabIndex = 6;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(261, 508);
            notesTextBox.Margin = new Padding(4, 4, 4, 4);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(656, 31);
            notesTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ActiveCaption;
            addButton.Location = new Point(593, 548);
            addButton.Margin = new Padding(4, 4, 4, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(118, 43);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(261, 547);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 43);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddFollowUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 827);
            Controls.Add(button1);
            Controls.Add(addButton);
            Controls.Add(notesTextBox);
            Controls.Add(followUpDatePicker);
            Controls.Add(adopterIDTextBox);
            Controls.Add(employeeIDTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddFollowUp";
            Text = "Form1";
            Load += AddFollowUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox employeeIDTextBox;
        private TextBox adopterIDTextBox;
        private DateTimePicker followUpDatePicker;
        private TextBox notesTextBox;
        private Button addButton;
        private Button button1;
    }
}