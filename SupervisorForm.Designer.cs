namespace Pet_Adoption
{
    partial class SupervisorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupervisorForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(228, 161);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(236, 91);
            button1.TabIndex = 0;
            button1.Text = "Add employee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("Bernard MT Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(546, 158);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(229, 94);
            button2.TabIndex = 1;
            button2.Text = "retrieve employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Coral;
            button3.Font = new Font("Bernard MT Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(228, 294);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(236, 90);
            button3.TabIndex = 2;
            button3.Text = "update employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Coral;
            button4.Font = new Font("Bernard MT Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(546, 298);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(229, 86);
            button4.TabIndex = 3;
            button4.Text = "Delete employee";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Bernard MT Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Coral;
            button5.Location = new Point(863, 658);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(118, 36);
            button5.TabIndex = 4;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // SupervisorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 707);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "SupervisorForm";
            Text = "SupervisorForm";
            Load += SupervisorForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}