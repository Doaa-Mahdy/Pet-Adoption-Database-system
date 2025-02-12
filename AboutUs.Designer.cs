namespace Pet_Adoption
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            sheltNumLabel = new Label();
            animalNumLabel = new Label();
            adoptSuccLabel = new Label();
            availableAnimalsLabel = new Label();
            popularBreedLabel = new Label();
            mostPopSpeciesLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // sheltNumLabel
            // 
            sheltNumLabel.AutoSize = true;
            sheltNumLabel.BackColor = Color.AntiqueWhite;
            sheltNumLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sheltNumLabel.ForeColor = Color.Orange;
            sheltNumLabel.Location = new Point(133, 298);
            sheltNumLabel.Margin = new Padding(4, 0, 4, 0);
            sheltNumLabel.Name = "sheltNumLabel";
            sheltNumLabel.Size = new Size(206, 23);
            sheltNumLabel.TabIndex = 1;
            sheltNumLabel.Text = "Number of Shelters:";
            // 
            // animalNumLabel
            // 
            animalNumLabel.AutoSize = true;
            animalNumLabel.BackColor = Color.AntiqueWhite;
            animalNumLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            animalNumLabel.ForeColor = Color.Orange;
            animalNumLabel.Location = new Point(133, 394);
            animalNumLabel.Margin = new Padding(4, 0, 4, 0);
            animalNumLabel.Name = "animalNumLabel";
            animalNumLabel.Size = new Size(195, 23);
            animalNumLabel.TabIndex = 2;
            animalNumLabel.Text = "Number of Animals:";
            // 
            // adoptSuccLabel
            // 
            adoptSuccLabel.AutoSize = true;
            adoptSuccLabel.BackColor = Color.AntiqueWhite;
            adoptSuccLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adoptSuccLabel.ForeColor = Color.Orange;
            adoptSuccLabel.Location = new Point(506, 298);
            adoptSuccLabel.Margin = new Padding(4, 0, 4, 0);
            adoptSuccLabel.Name = "adoptSuccLabel";
            adoptSuccLabel.Size = new Size(231, 23);
            adoptSuccLabel.TabIndex = 3;
            adoptSuccLabel.Text = "Adoption Success Rate:";
            // 
            // availableAnimalsLabel
            // 
            availableAnimalsLabel.AutoSize = true;
            availableAnimalsLabel.BackColor = Color.AntiqueWhite;
            availableAnimalsLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availableAnimalsLabel.ForeColor = Color.Orange;
            availableAnimalsLabel.Location = new Point(132, 481);
            availableAnimalsLabel.Margin = new Padding(4, 0, 4, 0);
            availableAnimalsLabel.Name = "availableAnimalsLabel";
            availableAnimalsLabel.Size = new Size(291, 23);
            availableAnimalsLabel.TabIndex = 4;
            availableAnimalsLabel.Text = "Number of Available Animals:";
            // 
            // popularBreedLabel
            // 
            popularBreedLabel.AutoSize = true;
            popularBreedLabel.BackColor = Color.AntiqueWhite;
            popularBreedLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            popularBreedLabel.ForeColor = Color.Orange;
            popularBreedLabel.Location = new Point(506, 394);
            popularBreedLabel.Margin = new Padding(4, 0, 4, 0);
            popularBreedLabel.Name = "popularBreedLabel";
            popularBreedLabel.Size = new Size(212, 23);
            popularBreedLabel.TabIndex = 5;
            popularBreedLabel.Text = "Most Popular Breed:";
            // 
            // mostPopSpeciesLabel
            // 
            mostPopSpeciesLabel.AutoSize = true;
            mostPopSpeciesLabel.BackColor = Color.AntiqueWhite;
            mostPopSpeciesLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mostPopSpeciesLabel.ForeColor = Color.Orange;
            mostPopSpeciesLabel.Location = new Point(506, 481);
            mostPopSpeciesLabel.Margin = new Padding(4, 0, 4, 0);
            mostPopSpeciesLabel.Name = "mostPopSpeciesLabel";
            mostPopSpeciesLabel.Size = new Size(222, 23);
            mostPopSpeciesLabel.TabIndex = 6;
            mostPopSpeciesLabel.Text = "Most Popular Species:";
            // 
            // backButton
            // 
            backButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.DarkOrange;
            backButton.Location = new Point(437, 583);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(118, 36);
            backButton.TabIndex = 7;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1014, 739);
            Controls.Add(backButton);
            Controls.Add(mostPopSpeciesLabel);
            Controls.Add(popularBreedLabel);
            Controls.Add(availableAnimalsLabel);
            Controls.Add(adoptSuccLabel);
            Controls.Add(animalNumLabel);
            Controls.Add(sheltNumLabel);
            DoubleBuffered = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "AboutUs";
            Text = "Form2";
            Load += AboutUs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label sheltNumLabel;
        private Label animalNumLabel;
        private Label adoptSuccLabel;
        private Label availableAnimalsLabel;
        private Label popularBreedLabel;
        private Label mostPopSpeciesLabel;
        private Button backButton;
    }
}