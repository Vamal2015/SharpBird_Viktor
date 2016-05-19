namespace SharpBird
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tube3 = new System.Windows.Forms.PictureBox();
            this.tube4 = new System.Windows.Forms.PictureBox();
            this.tube2 = new System.Windows.Forms.PictureBox();
            this.tube1 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.fon1 = new System.Windows.Forms.PictureBox();
            this.fon2 = new System.Windows.Forms.PictureBox();
            this.numPoints1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPoints2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tube3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tube3
            // 
            this.tube3.Image = global::SharpBird.Properties.Resources.block_21;
            this.tube3.Location = new System.Drawing.Point(257, 137);
            this.tube3.Name = "tube3";
            this.tube3.Size = new System.Drawing.Size(100, 50);
            this.tube3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube3.TabIndex = 5;
            this.tube3.TabStop = false;
            // 
            // tube4
            // 
            this.tube4.Image = global::SharpBird.Properties.Resources.block_211;
            this.tube4.Location = new System.Drawing.Point(257, 311);
            this.tube4.Name = "tube4";
            this.tube4.Size = new System.Drawing.Size(100, 50);
            this.tube4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube4.TabIndex = 4;
            this.tube4.TabStop = false;
            // 
            // tube2
            // 
            this.tube2.Image = global::SharpBird.Properties.Resources.block_22;
            this.tube2.Location = new System.Drawing.Point(257, -331);
            this.tube2.Name = "tube2";
            this.tube2.Size = new System.Drawing.Size(100, 500);
            this.tube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube2.TabIndex = 3;
            this.tube2.TabStop = false;
            this.tube2.Click += new System.EventHandler(this.tube2_Click);
            // 
            // tube1
            // 
            this.tube1.Image = global::SharpBird.Properties.Resources.block_22;
            this.tube1.Location = new System.Drawing.Point(257, 335);
            this.tube1.Name = "tube1";
            this.tube1.Size = new System.Drawing.Size(100, 500);
            this.tube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube1.TabIndex = 2;
            this.tube1.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::SharpBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(12, 204);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(50, 50);
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // fon1
            // 
            this.fon1.Image = global::SharpBird.Properties.Resources.background2_35;
            this.fon1.Location = new System.Drawing.Point(-249, -10);
            this.fon1.MaximumSize = new System.Drawing.Size(500, 500);
            this.fon1.MinimumSize = new System.Drawing.Size(500, 500);
            this.fon1.Name = "fon1";
            this.fon1.Size = new System.Drawing.Size(500, 500);
            this.fon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon1.TabIndex = 0;
            this.fon1.TabStop = false;
            // 
            // fon2
            // 
            this.fon2.BackgroundImage = global::SharpBird.Properties.Resources.background2_35;
            this.fon2.Location = new System.Drawing.Point(244, -10);
            this.fon2.Name = "fon2";
            this.fon2.Size = new System.Drawing.Size(500, 500);
            this.fon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon2.TabIndex = 6;
            this.fon2.TabStop = false;
            // 
            // numPoints1
            // 
            this.numPoints1.AutoSize = true;
            this.numPoints1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.numPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPoints1.Location = new System.Drawing.Point(80, 432);
            this.numPoints1.Name = "numPoints1";
            this.numPoints1.Size = new System.Drawing.Size(29, 31);
            this.numPoints1.TabIndex = 7;
            this.numPoints1.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 31);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-3, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Очки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вы набрали:";
            this.label2.Visible = false;
            // 
            // numPoints2
            // 
            this.numPoints2.AutoSize = true;
            this.numPoints2.BackColor = System.Drawing.Color.DarkOrange;
            this.numPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPoints2.ForeColor = System.Drawing.Color.Black;
            this.numPoints2.Location = new System.Drawing.Point(249, 199);
            this.numPoints2.Name = "numPoints2";
            this.numPoints2.Size = new System.Drawing.Size(39, 42);
            this.numPoints2.TabIndex = 11;
            this.numPoints2.Text = "0";
            this.numPoints2.Visible = false;
            this.numPoints2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(294, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "очков";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 55);
            this.label4.TabIndex = 13;
            this.label4.Text = "продолжить";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Location = new System.Drawing.Point(12, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 97);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(303, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 55);
            this.label5.TabIndex = 15;
            this.label5.Text = "выйти";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPoints2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPoints1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tube3);
            this.Controls.Add(this.tube4);
            this.Controls.Add(this.tube2);
            this.Controls.Add(this.tube1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.fon1);
            this.Controls.Add(this.fon2);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tube3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fon1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox tube1;
        private System.Windows.Forms.PictureBox tube2;
        private System.Windows.Forms.PictureBox tube4;
        private System.Windows.Forms.PictureBox tube3;
        private System.Windows.Forms.PictureBox fon2;
        private System.Windows.Forms.Label numPoints1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numPoints2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}

