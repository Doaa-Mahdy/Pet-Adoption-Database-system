namespace Pet_Adoption
{
    partial class AddAnimalForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnimalForm));
            AnimalSpeciesLabel = new Label();
            AnimalDateOfBirthPicker = new DateTimePicker();
            AnimalNameTextBox = new TextBox();
            AnimalBreedLabel = new Label();
            DateOfBirthLabel = new Label();
            AnimalSpeciesTextBox = new TextBox();
            AddAnimalButton = new Button();
            AnimalNameLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShelterIDTextBox = new TextBox();
            AnimalBreedTextBox = new TextBox();
            AnimalHealthStatusTextBox = new TextBox();
            AnimalHealthStatusLabel = new Label();
            ShelterIDLabel = new Label();
            SuspendLayout();
            // 
            // AnimalSpeciesLabel
            // 
            AnimalSpeciesLabel.AutoSize = true;
            AnimalSpeciesLabel.BackColor = Color.BlanchedAlmond;
            AnimalSpeciesLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalSpeciesLabel.ForeColor = Color.IndianRed;
            AnimalSpeciesLabel.Location = new Point(273, 162);
            AnimalSpeciesLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalSpeciesLabel.Name = "AnimalSpeciesLabel";
            AnimalSpeciesLabel.Size = new Size(236, 35);
            AnimalSpeciesLabel.TabIndex = 1;
            AnimalSpeciesLabel.Text = "Animal Species ";
            // 
            // AnimalDateOfBirthPicker
            // 
            AnimalDateOfBirthPicker.Location = new Point(275, 446);
            AnimalDateOfBirthPicker.Margin = new Padding(2);
            AnimalDateOfBirthPicker.Name = "AnimalDateOfBirthPicker";
            AnimalDateOfBirthPicker.Size = new Size(328, 31);
            AnimalDateOfBirthPicker.TabIndex = 2;
            // 
            // AnimalNameTextBox
            // 
            AnimalNameTextBox.Location = new Point(273, 129);
            AnimalNameTextBox.Margin = new Padding(2);
            AnimalNameTextBox.Name = "AnimalNameTextBox";
            AnimalNameTextBox.Size = new Size(328, 31);
            AnimalNameTextBox.TabIndex = 3;
            AnimalNameTextBox.TextChanged += AnimalNameTextBox_TextChanged;
            // 
            // AnimalBreedLabel
            // 
            AnimalBreedLabel.AutoSize = true;
            AnimalBreedLabel.BackColor = Color.AntiqueWhite;
            AnimalBreedLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalBreedLabel.ForeColor = Color.IndianRed;
            AnimalBreedLabel.Location = new Point(273, 241);
            AnimalBreedLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalBreedLabel.Name = "AnimalBreedLabel";
            AnimalBreedLabel.Size = new Size(220, 35);
            AnimalBreedLabel.TabIndex = 4;
            AnimalBreedLabel.Text = "Animal Breed ";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.BackColor = Color.AntiqueWhite;
            DateOfBirthLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateOfBirthLabel.ForeColor = Color.IndianRed;
            DateOfBirthLabel.Location = new Point(273, 397);
            DateOfBirthLabel.Margin = new Padding(2, 0, 2, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(227, 35);
            DateOfBirthLabel.TabIndex = 5;
            DateOfBirthLabel.Text = "Date of birth ";
            // 
            // AnimalSpeciesTextBox
            // 
            AnimalSpeciesTextBox.Location = new Point(273, 208);
            AnimalSpeciesTextBox.Margin = new Padding(2);
            AnimalSpeciesTextBox.Name = "AnimalSpeciesTextBox";
            AnimalSpeciesTextBox.Size = new Size(328, 31);
            AnimalSpeciesTextBox.TabIndex = 6;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.BackColor = Color.IndianRed;
            AddAnimalButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAnimalButton.ForeColor = Color.MidnightBlue;
            AddAnimalButton.Location = new Point(330, 585);
            AddAnimalButton.Margin = new Padding(2);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(217, 45);
            AddAnimalButton.TabIndex = 7;
            AddAnimalButton.Text = "Add Animal";
            AddAnimalButton.UseVisualStyleBackColor = false;
            AddAnimalButton.Click += AddAnimalButton_Click_1;
            // 
            // AnimalNameLabel
            // 
            AnimalNameLabel.AutoSize = true;
            AnimalNameLabel.BackColor = Color.BlanchedAlmond;
            AnimalNameLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalNameLabel.ForeColor = Color.IndianRed;
            AnimalNameLabel.Location = new Point(273, 92);
            AnimalNameLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalNameLabel.Name = "AnimalNameLabel";
            AnimalNameLabel.Size = new Size(198, 35);
            AnimalNameLabel.TabIndex = 8;
            AnimalNameLabel.Text = "Animal Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ShelterIDTextBox
            // 
            ShelterIDTextBox.Location = new Point(273, 364);
            ShelterIDTextBox.Margin = new Padding(2);
            ShelterIDTextBox.Name = "ShelterIDTextBox";
            ShelterIDTextBox.Size = new Size(330, 31);
            ShelterIDTextBox.TabIndex = 10;
            // 
            // AnimalBreedTextBox
            // 
            AnimalBreedTextBox.Location = new Point(273, 289);
            AnimalBreedTextBox.Margin = new Padding(2);
            AnimalBreedTextBox.Name = "AnimalBreedTextBox";
            AnimalBreedTextBox.Size = new Size(328, 31);
            AnimalBreedTextBox.TabIndex = 11;
            // 
            // AnimalHealthStatusTextBox
            // 
            AnimalHealthStatusTextBox.Location = new Point(275, 531);
            AnimalHealthStatusTextBox.Margin = new Padding(2);
            AnimalHealthStatusTextBox.Name = "AnimalHealthStatusTextBox";
            AnimalHealthStatusTextBox.Size = new Size(328, 31);
            AnimalHealthStatusTextBox.TabIndex = 12;
            // 
            // AnimalHealthStatusLabel
            // 
            AnimalHealthStatusLabel.AutoSize = true;
            AnimalHealthStatusLabel.BackColor = Color.AntiqueWhite;
            AnimalHealthStatusLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalHealthStatusLabel.ForeColor = Color.IndianRed;
            AnimalHealthStatusLabel.Location = new Point(273, 479);
            AnimalHealthStatusLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalHealthStatusLabel.Name = "AnimalHealthStatusLabel";
            AnimalHealthStatusLabel.Size = new Size(229, 35);
            AnimalHealthStatusLabel.TabIndex = 13;
            AnimalHealthStatusLabel.Text = "Health Status";
            // 
            // ShelterIDLabel
            // 
            ShelterIDLabel.AutoSize = true;
            ShelterIDLabel.BackColor = Color.AntiqueWhite;
            ShelterIDLabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShelterIDLabel.ForeColor = Color.IndianRed;
            ShelterIDLabel.Location = new Point(274, 322);
            ShelterIDLabel.Margin = new Padding(2, 0, 2, 0);
            ShelterIDLabel.Name = "ShelterIDLabel";
            ShelterIDLabel.Size = new Size(172, 35);
            ShelterIDLabel.TabIndex = 14;
            ShelterIDLabel.Text = "Shelter ID";
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(927, 776);
            Controls.Add(ShelterIDLabel);
            Controls.Add(AnimalHealthStatusLabel);
            Controls.Add(AnimalHealthStatusTextBox);
            Controls.Add(AnimalBreedTextBox);
            Controls.Add(ShelterIDTextBox);
            Controls.Add(AnimalNameLabel);
            Controls.Add(AddAnimalButton);
            Controls.Add(AnimalSpeciesTextBox);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(AnimalBreedLabel);
            Controls.Add(AnimalNameTextBox);
            Controls.Add(AnimalDateOfBirthPicker);
            Controls.Add(AnimalSpeciesLabel);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            Load += AddAnimalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AnimalSpeciesLabel;
        private DateTimePicker AnimalDateOfBirthPicker;
        private TextBox AnimalNameTextBox;
        private Label AnimalBreedLabel;
        private Label DateOfBirthLabel;
        private TextBox AnimalSpeciesTextBox;
        private Button AddAnimalButton;
        private Label AnimalNameLabel;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox ShelterIDTextBox;
        private TextBox AnimalBreedTextBox;
        private TextBox AnimalHealthStatusTextBox;
        private Label AnimalHealthStatusLabel;
        private Label ShelterIDLabel;
    }
}