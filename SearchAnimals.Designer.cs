namespace Pet_Adoption
{
    partial class SearchAnimals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAnimals));
            searchBox = new TextBox();
            searchButton = new Button();
            flowLayoutPanelResults = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.IndianRed;
            searchBox.Location = new Point(475, 34);
            searchBox.Margin = new Padding(4, 4, 4, 4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(442, 40);
            searchBox.TabIndex = 0;
            searchBox.Text = "search by breed or species";
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.IndianRed;
            searchButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.WhiteSmoke;
            searchButton.Location = new Point(967, 34);
            searchButton.Margin = new Padding(4, 4, 4, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(179, 46);
            searchButton.TabIndex = 1;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // flowLayoutPanelResults
            // 
            flowLayoutPanelResults.AutoScroll = true;
            flowLayoutPanelResults.Location = new Point(144, 88);
            flowLayoutPanelResults.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            flowLayoutPanelResults.Size = new Size(1267, 601);
            flowLayoutPanelResults.TabIndex = 2;
            flowLayoutPanelResults.Paint += flowLayoutPanelResults_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(16, 731);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchAnimals
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1541, 779);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelResults);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "SearchAnimals";
            Text = "Form2";
            Load += SearchAnimals_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Button searchButton;
        private FlowLayoutPanel flowLayoutPanelResults;
        private Button button1;
    }
}