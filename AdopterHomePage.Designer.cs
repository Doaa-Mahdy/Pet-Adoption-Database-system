namespace Pet_Adoption
{
    partial class AdopterHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdopterHomePage));
            searchButton = new Button();
            statusButton = new Button();
            followUpButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.DarkGreen;
            searchButton.Location = new Point(394, 368);
            searchButton.Margin = new Padding(4, 4, 4, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(334, 90);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search Animals";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button1_Click;
            // 
            // statusButton
            // 
            statusButton.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusButton.ForeColor = Color.DarkGreen;
            statusButton.Location = new Point(394, 515);
            statusButton.Margin = new Padding(4, 4, 4, 4);
            statusButton.Name = "statusButton";
            statusButton.Size = new Size(334, 90);
            statusButton.TabIndex = 1;
            statusButton.Text = "Check Adoption Status";
            statusButton.UseVisualStyleBackColor = true;
            statusButton.Click += statusButton_Click;
            // 
            // followUpButton
            // 
            followUpButton.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            followUpButton.ForeColor = Color.DarkGreen;
            followUpButton.Location = new Point(394, 653);
            followUpButton.Margin = new Padding(4, 4, 4, 4);
            followUpButton.Name = "followUpButton";
            followUpButton.Size = new Size(334, 90);
            followUpButton.TabIndex = 2;
            followUpButton.Text = "Adoption FollowUp Info";
            followUpButton.UseVisualStyleBackColor = true;
            followUpButton.Click += followUpButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(49, 496);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // AdopterHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1141, 1039);
            Controls.Add(button1);
            Controls.Add(followUpButton);
            Controls.Add(statusButton);
            Controls.Add(searchButton);
            DoubleBuffered = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdopterHomePage";
            Text = "Form2";
            Load += AdopterHomePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button searchButton;
        private Button statusButton;
        private Button followUpButton;
        private Button button1;
    }
}