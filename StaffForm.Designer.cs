namespace Pet_Adoption
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            AddAnimalButton = new Button();
            RetrieveAnimalsButton = new Button();
            DeleteAnimalButton = new Button();
            UpdateAnimalButton = new Button();
            AddTreatementButton = new Button();
            RetrieveMedicalHistoryButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.BackColor = Color.SteelBlue;
            AddAnimalButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAnimalButton.ForeColor = SystemColors.Info;
            AddAnimalButton.Location = new Point(351, 166);
            AddAnimalButton.Margin = new Padding(2);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(276, 47);
            AddAnimalButton.TabIndex = 0;
            AddAnimalButton.Text = "Add Animal";
            AddAnimalButton.UseVisualStyleBackColor = false;
            AddAnimalButton.Click += AddAnimalButton_Click;
            // 
            // RetrieveAnimalsButton
            // 
            RetrieveAnimalsButton.BackColor = Color.SteelBlue;
            RetrieveAnimalsButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RetrieveAnimalsButton.ForeColor = SystemColors.Info;
            RetrieveAnimalsButton.Location = new Point(351, 244);
            RetrieveAnimalsButton.Margin = new Padding(2);
            RetrieveAnimalsButton.Name = "RetrieveAnimalsButton";
            RetrieveAnimalsButton.Size = new Size(276, 47);
            RetrieveAnimalsButton.TabIndex = 1;
            RetrieveAnimalsButton.Text = "Retrieve Animal ";
            RetrieveAnimalsButton.UseVisualStyleBackColor = false;
            RetrieveAnimalsButton.Click += RetrieveAnimalsButton_Click;
            // 
            // DeleteAnimalButton
            // 
            DeleteAnimalButton.BackColor = Color.SteelBlue;
            DeleteAnimalButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteAnimalButton.ForeColor = SystemColors.Info;
            DeleteAnimalButton.Location = new Point(351, 325);
            DeleteAnimalButton.Margin = new Padding(2);
            DeleteAnimalButton.Name = "DeleteAnimalButton";
            DeleteAnimalButton.Size = new Size(276, 43);
            DeleteAnimalButton.TabIndex = 2;
            DeleteAnimalButton.Text = "Delete Animal";
            DeleteAnimalButton.UseVisualStyleBackColor = false;
            DeleteAnimalButton.Click += DeleteAnimalButton_Click_1;
            // 
            // UpdateAnimalButton
            // 
            UpdateAnimalButton.BackColor = Color.SteelBlue;
            UpdateAnimalButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateAnimalButton.ForeColor = SystemColors.Info;
            UpdateAnimalButton.Location = new Point(351, 409);
            UpdateAnimalButton.Margin = new Padding(2);
            UpdateAnimalButton.Name = "UpdateAnimalButton";
            UpdateAnimalButton.Size = new Size(276, 42);
            UpdateAnimalButton.TabIndex = 3;
            UpdateAnimalButton.Text = "Update Animal";
            UpdateAnimalButton.UseVisualStyleBackColor = false;
            UpdateAnimalButton.Click += UpdateAnimalButton_Click;
            // 
            // AddTreatementButton
            // 
            AddTreatementButton.BackColor = Color.SteelBlue;
            AddTreatementButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddTreatementButton.ForeColor = SystemColors.Info;
            AddTreatementButton.Location = new Point(351, 494);
            AddTreatementButton.Margin = new Padding(2);
            AddTreatementButton.Name = "AddTreatementButton";
            AddTreatementButton.Size = new Size(276, 49);
            AddTreatementButton.TabIndex = 4;
            AddTreatementButton.Text = "Add Treatment ";
            AddTreatementButton.UseVisualStyleBackColor = false;
            AddTreatementButton.Click += AddTreatementButton_Click;
            // 
            // RetrieveMedicalHistoryButton
            // 
            RetrieveMedicalHistoryButton.BackColor = Color.SteelBlue;
            RetrieveMedicalHistoryButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RetrieveMedicalHistoryButton.ForeColor = SystemColors.Info;
            RetrieveMedicalHistoryButton.Location = new Point(351, 585);
            RetrieveMedicalHistoryButton.Margin = new Padding(2);
            RetrieveMedicalHistoryButton.Name = "RetrieveMedicalHistoryButton";
            RetrieveMedicalHistoryButton.Size = new Size(276, 43);
            RetrieveMedicalHistoryButton.TabIndex = 5;
            RetrieveMedicalHistoryButton.Text = "Retrieve Medical History ";
            RetrieveMedicalHistoryButton.UseVisualStyleBackColor = false;
            RetrieveMedicalHistoryButton.Click += RetrieveMedicalHistoryButton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(139, 646);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1077, 781);
            Controls.Add(button1);
            Controls.Add(RetrieveMedicalHistoryButton);
            Controls.Add(AddTreatementButton);
            Controls.Add(UpdateAnimalButton);
            Controls.Add(DeleteAnimalButton);
            Controls.Add(RetrieveAnimalsButton);
            Controls.Add(AddAnimalButton);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "StaffForm";
            Text = "StaffForm";
            Load += StaffForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button AddAnimalButton;
        private Button RetrieveAnimalsButton;
        private Button DeleteAnimalButton;
        private Button UpdateAnimalButton;
        private Button AddTreatementButton;
        private Button RetrieveMedicalHistoryButton;
        private Button button1;
    }
}