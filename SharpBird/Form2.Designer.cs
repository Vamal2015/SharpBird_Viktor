namespace SharpBird
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fon2 = new System.Windows.Forms.PictureBox();
            this.fon1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon1)).BeginInit();
            this.SuspendLayout();
            // 
            // fon2
            // 
            this.fon2.Image = ((System.Drawing.Image)(resources.GetObject("fon2.Image")));
            this.fon2.Location = new System.Drawing.Point(149, -1);
            this.fon2.Name = "fon2";
            this.fon2.Size = new System.Drawing.Size(500, 500);
            this.fon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon2.TabIndex = 3;
            this.fon2.TabStop = false;
            // 
            // fon1
            // 
            this.fon1.Image = ((System.Drawing.Image)(resources.GetObject("fon1.Image")));
            this.fon1.Location = new System.Drawing.Point(-347, -1);
            this.fon1.Name = "fon1";
            this.fon1.Size = new System.Drawing.Size(500, 500);
            this.fon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon1.TabIndex = 2;
            this.fon1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "НАЧАТЬ ИГРУ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fon2);
            this.Controls.Add(this.fon1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.fon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fon2;
        private System.Windows.Forms.PictureBox fon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}