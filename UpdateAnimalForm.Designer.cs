namespace Pet_Adoption
{
    partial class UpdateAnimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAnimalForm));
            textBoxSearchAnimalName = new TextBox();
            label1 = new Label();
            textBoxSearchShelterName = new TextBox();
            label2 = new Label();
            buttonSearch = new Button();
            textBoxSpecies = new TextBox();
            label3 = new Label();
            textBoxBreed = new TextBox();
            label4 = new Label();
            textBoxHealthStatus = new TextBox();
            label5 = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            label6 = new Label();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // textBoxSearchAnimalName
            // 
            textBoxSearchAnimalName.Location = new Point(192, 134);
            textBoxSearchAnimalName.Margin = new Padding(2);
            textBoxSearchAnimalName.Name = "textBoxSearchAnimalName";
            textBoxSearchAnimalName.Size = new Size(423, 31);
            textBoxSearchAnimalName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PapayaWhip;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(192, 97);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 30);
            label1.TabIndex = 1;
            label1.Text = "Search Animal Name";
            label1.Click += label1_Click;
            // 
            // textBoxSearchShelterName
            // 
            textBoxSearchShelterName.Location = new Point(192, 199);
            textBoxSearchShelterName.Margin = new Padding(2);
            textBoxSearchShelterName.Name = "textBoxSearchShelterName";
            textBoxSearchShelterName.Size = new Size(423, 31);
            textBoxSearchShelterName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PapayaWhip;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkKhaki;
            label2.Location = new Point(192, 167);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(278, 30);
            label2.TabIndex = 3;
            label2.Text = "Search Shelter Name";
            label2.Click += label2_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.DarkKhaki;
            buttonSearch.Location = new Point(541, 234);
            buttonSearch.Margin = new Padding(2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 38);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSpecies
            // 
            textBoxSpecies.Location = new Point(192, 318);
            textBoxSpecies.Margin = new Padding(2);
            textBoxSpecies.Name = "textBoxSpecies";
            textBoxSpecies.Size = new Size(423, 31);
            textBoxSpecies.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkKhaki;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PapayaWhip;
            label3.Location = new Point(192, 277);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 30);
            label3.TabIndex = 6;
            label3.Text = "Animal Species";
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(192, 387);
            textBoxBreed.Margin = new Padding(2);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(412, 31);
            textBoxBreed.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkKhaki;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PapayaWhip;
            label4.Location = new Point(192, 355);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 30);
            label4.TabIndex = 8;
            label4.Text = "Animal Breed";
            label4.Click += label4_Click;
            // 
            // textBoxHealthStatus
            // 
            textBoxHealthStatus.Location = new Point(192, 454);
            textBoxHealthStatus.Margin = new Padding(2);
            textBoxHealthStatus.Name = "textBoxHealthStatus";
            textBoxHealthStatus.Size = new Size(412, 31);
            textBoxHealthStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkKhaki;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PapayaWhip;
            label5.Location = new Point(192, 420);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 30);
            label5.TabIndex = 10;
            label5.Text = "Health Status";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(192, 524);
            dateTimePickerDateOfBirth.Margin = new Padding(2);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(412, 31);
            dateTimePickerDateOfBirth.TabIndex = 11;
            dateTimePickerDateOfBirth.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkKhaki;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PapayaWhip;
            label6.Location = new Point(192, 492);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(189, 30);
            label6.TabIndex = 12;
            label6.Text = "Date of Birth";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.DarkKhaki;
            buttonUpdate.Location = new Point(541, 579);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(130, 43);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // UpdateAnimalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 819);
            Controls.Add(buttonUpdate);
            Controls.Add(label6);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(label5);
            Controls.Add(textBoxHealthStatus);
            Controls.Add(label4);
            Controls.Add(textBoxBreed);
            Controls.Add(label3);
            Controls.Add(textBoxSpecies);
            Controls.Add(buttonSearch);
            Controls.Add(label2);
            Controls.Add(textBoxSearchShelterName);
            Controls.Add(label1);
            Controls.Add(textBoxSearchAnimalName);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "UpdateAnimalForm";
            Text = "UpdateAnimalForm";
            Load += UpdateAnimalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchAnimalName;
        private Label label1;
        private TextBox textBoxSearchShelterName;
        private Label label2;
        private Button buttonSearch;
        private TextBox textBoxSpecies;
        private Label label3;
        private TextBox textBoxBreed;
        private Label label4;
        private TextBox textBoxHealthStatus;
        private Label label5;
        private DateTimePicker dateTimePickerDateOfBirth;
        private Label label6;
        private Button buttonUpdate;
    }
}