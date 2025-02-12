namespace Pet_Adoption
{
    partial class RetrieveFollowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrieveFollowUp));
            searchBox = new TextBox();
            searchButton = new Button();
            resultsPanel = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(418, 97);
            searchBox.Margin = new Padding(4, 4, 4, 4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(360, 31);
            searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.Pink;
            searchButton.Location = new Point(786, 97);
            searchButton.Margin = new Padding(4, 4, 4, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(118, 36);
            searchButton.TabIndex = 1;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resultsPanel
            // 
            resultsPanel.AutoScroll = true;
            resultsPanel.Location = new Point(87, 141);
            resultsPanel.Margin = new Padding(4, 4, 4, 4);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(886, 406);
            resultsPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(459, 555);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RetrieveFollowUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 674);
            Controls.Add(button1);
            Controls.Add(resultsPanel);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            DoubleBuffered = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "RetrieveFollowUp";
            Text = "Form1";
            Load += RetrieveFollowUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Button searchButton;
        private FlowLayoutPanel resultsPanel;
        private Button button1;
    }
}