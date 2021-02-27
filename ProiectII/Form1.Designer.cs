namespace ProiectII
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Parts = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Parts);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.Cars);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 553);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Parts
            // 
            this.Parts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Parts.FlatAppearance.BorderSize = 0;
            this.Parts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Parts.Image = ((System.Drawing.Image)(resources.GetObject("Parts.Image")));
            this.Parts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Parts.Location = new System.Drawing.Point(4, 239);
            this.Parts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(177, 57);
            this.Parts.TabIndex = 1;
            this.Parts.Text = "Parts";
            this.Parts.UseVisualStyleBackColor = true;
            this.Parts.Click += new System.EventHandler(this.Parts_Click);
            // 
            // Home
            // 
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(4, 111);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(180, 57);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Cars
            // 
            this.Cars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cars.FlatAppearance.BorderSize = 0;
            this.Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cars.Image = ((System.Drawing.Image)(resources.GetObject("Cars.Image")));
            this.Cars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cars.Location = new System.Drawing.Point(4, 175);
            this.Cars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(177, 57);
            this.Cars.TabIndex = 1;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = false;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 587);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1315, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Parts;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel2;
    }
}

