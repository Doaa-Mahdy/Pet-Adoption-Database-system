namespace Pet_Adoption
{
    partial class RetrieveAdopter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrieveAdopter));
            textBox1 = new TextBox();
            searchButton = new Button();
            resultsPanel = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 88);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.DarkOrange;
            searchButton.Location = new Point(422, 88);
            searchButton.Margin = new Padding(4, 4, 4, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(133, 36);
            searchButton.TabIndex = 1;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resultsPanel
            // 
            resultsPanel.Location = new Point(71, 141);
            resultsPanel.Margin = new Padding(4, 4, 4, 4);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(913, 441);
            resultsPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(32, 610);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 42);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RetrieveAdopter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 684);
            Controls.Add(button1);
            Controls.Add(resultsPanel);
            Controls.Add(searchButton);
            Controls.Add(textBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RetrieveAdopter";
            Text = "Form1";
            Load += RetrieveAdopter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button searchButton;
        private FlowLayoutPanel resultsPanel;
        private Button button1;
    }
}