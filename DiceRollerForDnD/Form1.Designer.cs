namespace DiceRollerForDnD
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
            this.button1 = new System.Windows.Forms.Button();
            this.NumRolls = new System.Windows.Forms.TextBox();
            this.NumSides = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.Rolls = new System.Windows.Forms.Label();
            this.Sides = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumRolls
            // 
            this.NumRolls.Location = new System.Drawing.Point(6, 68);
            this.NumRolls.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NumRolls.Multiline = true;
            this.NumRolls.Name = "NumRolls";
            this.NumRolls.Size = new System.Drawing.Size(130, 38);
            this.NumRolls.TabIndex = 1;
            this.NumRolls.Tag = "";
            this.NumRolls.TextChanged += new System.EventHandler(this.NumRolls_TextChanged);
            // 
            // NumSides
            // 
            this.NumSides.Location = new System.Drawing.Point(138, 68);
            this.NumSides.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumSides.Multiline = true;
            this.NumSides.Name = "NumSides";
            this.NumSides.Size = new System.Drawing.Size(130, 38);
            this.NumSides.TabIndex = 2;
            this.NumSides.TextChanged += new System.EventHandler(this.NumSides_TextChanged);
            // 
            // Results
            // 
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(6, 179);
            this.Results.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Size = new System.Drawing.Size(264, 78);
            this.Results.TabIndex = 3;
            this.Results.Text = "Total | Results";
            this.Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Results.TextChanged += new System.EventHandler(this.Results_TextChanged);
            // 
            // Rolls
            // 
            this.Rolls.AutoSize = true;
            this.Rolls.Location = new System.Drawing.Point(6, 52);
            this.Rolls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rolls.Name = "Rolls";
            this.Rolls.Size = new System.Drawing.Size(47, 13);
            this.Rolls.TabIndex = 5;
            this.Rolls.Text = "# of rolls";
            // 
            // Sides
            // 
            this.Sides.AutoSize = true;
            this.Sides.Location = new System.Drawing.Point(138, 51);
            this.Sides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sides.Name = "Sides";
            this.Sides.Size = new System.Drawing.Size(91, 13);
            this.Sides.TabIndex = 6;
            this.Sides.Text = "# of sides on dice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(347, 261);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(118, 13);
            this.ImageLabel.TabIndex = 7;
            this.ImageLabel.Text = "Image found on Google";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 320);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.Sides);
            this.Controls.Add(this.Rolls);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.NumSides);
            this.Controls.Add(this.NumRolls);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Dungeons and Dragons Dice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumRolls;
        private System.Windows.Forms.TextBox NumSides;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Label Rolls;
        private System.Windows.Forms.Label Sides;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ImageLabel;
    }
}

