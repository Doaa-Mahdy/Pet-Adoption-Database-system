namespace Pet_Adoption
{
    partial class DeleteEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmployeeForm));
            textBoxEmployeeID = new TextBox();
            buttonDelete = new Button();
            labelEmployeeID = new Label();
            SuspendLayout();
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.Location = new Point(249, 309);
            textBoxEmployeeID.Margin = new Padding(2);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.Size = new Size(362, 31);
            textBoxEmployeeID.TabIndex = 0;
            textBoxEmployeeID.TextChanged += textBoxEmployeeID_TextChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.DarkSalmon;
            buttonDelete.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.Snow;
            buttonDelete.Location = new Point(330, 358);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(164, 49);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelEmployeeID
            // 
            labelEmployeeID.AutoSize = true;
            labelEmployeeID.BackColor = SystemColors.Window;
            labelEmployeeID.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmployeeID.ForeColor = Color.DarkSalmon;
            labelEmployeeID.Location = new Point(249, 267);
            labelEmployeeID.Margin = new Padding(2, 0, 2, 0);
            labelEmployeeID.Name = "labelEmployeeID";
            labelEmployeeID.Size = new Size(222, 40);
            labelEmployeeID.TabIndex = 2;
            labelEmployeeID.Text = "Employee ID";
            // 
            // DeleteEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(886, 619);
            Controls.Add(labelEmployeeID);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxEmployeeID);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "DeleteEmployeeForm";
            Text = "DeleteEmployeeForm";
            Load += DeleteEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmployeeID;
        private Button buttonDelete;
        private Label labelEmployeeID;
    }
}