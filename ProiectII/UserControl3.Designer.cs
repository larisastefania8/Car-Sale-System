namespace ProiectII
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            this.Mark = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Part1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mark
            // 
            this.Mark.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mark.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mark.FormattingEnabled = true;
            this.Mark.Location = new System.Drawing.Point(48, 69);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(138, 21);
            this.Mark.TabIndex = 0;
            this.Mark.SelectedIndexChanged += new System.EventHandler(this.Mark_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mark";
            // 
            // Part1
            // 
            this.Part1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Part1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Part1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Part1.FormattingEnabled = true;
            this.Part1.Location = new System.Drawing.Point(48, 174);
            this.Part1.Name = "Part1";
            this.Part1.Size = new System.Drawing.Size(138, 21);
            this.Part1.TabIndex = 0;
            this.Part1.SelectedIndexChanged += new System.EventHandler(this.Part1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(48, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price\r\n";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(48, 227);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(138, 20);
            this.Price.TabIndex = 2;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(48, 122);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(138, 20);
            this.Code.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Code";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.Control;
            this.Add.Location = new System.Drawing.Point(48, 371);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(138, 44);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Part1);
            this.Controls.Add(this.Mark);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(851, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Mark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Part1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
    }
}
