namespace Pet_Adoption
{
    partial class RetrieveEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrieveEmployeeForm));
            Refresh = new Button();
            txtSearchName = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refresh.ForeColor = Color.Coral;
            Refresh.Location = new Point(396, 243);
            Refresh.Margin = new Padding(2);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(143, 55);
            Refresh.TabIndex = 1;
            Refresh.Text = "Submit";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += button1_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(281, 208);
            txtSearchName.Margin = new Padding(2);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(365, 31);
            txtSearchName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 314);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(787, 314);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BlanchedAlmond;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(281, 160);
            label1.Name = "label1";
            label1.Size = new Size(277, 35);
            label1.TabIndex = 4;
            label1.Text = "Enter Your Name:";
            // 
            // RetrieveEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 705);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchName);
            Controls.Add(Refresh);
            Margin = new Padding(2);
            Name = "RetrieveEmployeeForm";
            Text = "RetrieveEmployeeForm";
            Load += RetrieveEmployeeForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Refresh;
        private TextBox txtSearchName;
        private DataGridView dataGridView1;
        private Label label1;
    }
}