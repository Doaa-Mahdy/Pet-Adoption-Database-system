namespace Pet_Adoption
{
    partial class AddTreatmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTreatmentForm));
            textBoxTreatmentName = new MaskedTextBox();
            label1 = new Label();
            label3 = new Label();
            textBoxAnimalName = new TextBox();
            label4 = new Label();
            buttonAddTreatment = new Button();
            dateTimePickerTreatmentDate = new DateTimePicker();
            textBoxShelterName = new TextBox();
            AnimalName = new Label();
            SuspendLayout();
            // 
            // textBoxTreatmentName
            // 
            textBoxTreatmentName.Location = new Point(348, 157);
            textBoxTreatmentName.Name = "textBoxTreatmentName";
            textBoxTreatmentName.Size = new Size(336, 31);
            textBoxTreatmentName.TabIndex = 0;
            textBoxTreatmentName.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(65, 157);
            label1.Name = "label1";
            label1.Size = new Size(257, 35);
            label1.TabIndex = 1;
            label1.Text = "Treatment Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Green;
            label3.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Bisque;
            label3.Location = new Point(69, 254);
            label3.Name = "label3";
            label3.Size = new Size(253, 35);
            label3.TabIndex = 5;
            label3.Text = "Treatment Date";
            // 
            // textBoxAnimalName
            // 
            textBoxAnimalName.Location = new Point(348, 356);
            textBoxAnimalName.Name = "textBoxAnimalName";
            textBoxAnimalName.Size = new Size(336, 31);
            textBoxAnimalName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Green;
            label4.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Bisque;
            label4.Location = new Point(98, 453);
            label4.Name = "label4";
            label4.Size = new Size(215, 35);
            label4.TabIndex = 7;
            label4.Text = "Shelter Name";
            // 
            // buttonAddTreatment
            // 
            buttonAddTreatment.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddTreatment.ForeColor = Color.Green;
            buttonAddTreatment.Location = new Point(393, 542);
            buttonAddTreatment.Name = "buttonAddTreatment";
            buttonAddTreatment.Size = new Size(207, 45);
            buttonAddTreatment.TabIndex = 8;
            buttonAddTreatment.Text = "Add Treatment";
            buttonAddTreatment.UseVisualStyleBackColor = true;
            buttonAddTreatment.Click += buttonAddTreatment_Click;
            // 
            // dateTimePickerTreatmentDate
            // 
            dateTimePickerTreatmentDate.Location = new Point(348, 258);
            dateTimePickerTreatmentDate.Name = "dateTimePickerTreatmentDate";
            dateTimePickerTreatmentDate.Size = new Size(336, 31);
            dateTimePickerTreatmentDate.TabIndex = 10;
            // 
            // textBoxShelterName
            // 
            textBoxShelterName.Location = new Point(348, 453);
            textBoxShelterName.Name = "textBoxShelterName";
            textBoxShelterName.Size = new Size(336, 31);
            textBoxShelterName.TabIndex = 11;
            // 
            // AnimalName
            // 
            AnimalName.AutoSize = true;
            AnimalName.BackColor = Color.Green;
            AnimalName.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalName.ForeColor = Color.Bisque;
            AnimalName.Location = new Point(109, 356);
            AnimalName.Name = "AnimalName";
            AnimalName.Size = new Size(204, 35);
            AnimalName.TabIndex = 12;
            AnimalName.Text = "Aminal Name ";
            // 
            // AddTreatmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 752);
            Controls.Add(AnimalName);
            Controls.Add(textBoxShelterName);
            Controls.Add(dateTimePickerTreatmentDate);
            Controls.Add(buttonAddTreatment);
            Controls.Add(label4);
            Controls.Add(textBoxAnimalName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxTreatmentName);
            DoubleBuffered = true;
            Name = "AddTreatmentForm";
            Text = "AddTreatmentForm";
            Load += AddTreatmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox textBoxTreatmentName;
        private Label label1;
        private Label label3;
        private TextBox textBoxAnimalName;
        private Label label4;
        private Button buttonAddTreatment;
        private Label label2;
        private ComboBox comboBoxTreatmentType;
        private DateTimePicker dateTimePickerTreatmentDate;
        private TextBox textBoxShelterName;
        private Label AnimalName;
    }
}