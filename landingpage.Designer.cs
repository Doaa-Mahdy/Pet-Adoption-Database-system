namespace Pet_Adoption
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            employeebutton = new Button();
            adopter = new Button();
            AboutUsButton = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            SuspendLayout();
            // 
            // employeebutton
            // 
            employeebutton.BackColor = Color.OldLace;
            employeebutton.BackgroundImageLayout = ImageLayout.Stretch;
            employeebutton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeebutton.ForeColor = Color.Tomato;
            employeebutton.Location = new Point(433, 384);
            employeebutton.Margin = new Padding(4);
            employeebutton.Name = "employeebutton";
            employeebutton.Size = new Size(299, 98);
            employeebutton.TabIndex = 0;
            employeebutton.Text = "Shelter Employee";
            employeebutton.TextImageRelation = TextImageRelation.TextAboveImage;
            employeebutton.UseVisualStyleBackColor = false;
            employeebutton.UseWaitCursor = true;
            employeebutton.Click += employeebutton_Click;
            // 
            // adopter
            // 
            adopter.BackColor = Color.OldLace;
            adopter.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adopter.ForeColor = Color.Tomato;
            adopter.Location = new Point(433, 512);
            adopter.Margin = new Padding(4);
            adopter.Name = "adopter";
            adopter.Size = new Size(299, 98);
            adopter.TabIndex = 1;
            adopter.Text = "Adopter";
            adopter.UseVisualStyleBackColor = false;
            adopter.Click += adopter_Click_1;
            // 
            // AboutUsButton
            // 
            AboutUsButton.BackColor = Color.OldLace;
            AboutUsButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutUsButton.ForeColor = Color.Tomato;
            AboutUsButton.Location = new Point(433, 659);
            AboutUsButton.Margin = new Padding(4);
            AboutUsButton.Name = "AboutUsButton";
            AboutUsButton.Size = new Size(299, 98);
            AboutUsButton.TabIndex = 2;
            AboutUsButton.Text = "About Us";
            AboutUsButton.UseVisualStyleBackColor = false;
            AboutUsButton.Click += AboutUsButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 1073);
            Controls.Add(AboutUsButton);
            Controls.Add(adopter);
            Controls.Add(employeebutton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LandingPage";
            Text = "Pet Adoption system";
            Load += landingpage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button employeebutton;
        private Button adopter;
        private Button AboutUsButton;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}