namespace WindowsFormsApplication1
{
    partial class SharpBird_Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpBird_Menu));
            this.fon1 = new System.Windows.Forms.PictureBox();
            this.fon2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fon1
            // 
            this.fon1.Image = ((System.Drawing.Image)(resources.GetObject("fon1.Image")));
            this.fon1.Location = new System.Drawing.Point(-197, 0);
            this.fon1.Name = "fon1";
            this.fon1.Size = new System.Drawing.Size(500, 500);
            this.fon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon1.TabIndex = 0;
            this.fon1.TabStop = false;
            // 
            // fon2
            // 
            this.fon2.Image = ((System.Drawing.Image)(resources.GetObject("fon2.Image")));
            this.fon2.Location = new System.Drawing.Point(299, 0);
            this.fon2.Name = "fon2";
            this.fon2.Size = new System.Drawing.Size(500, 500);
            this.fon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon2.TabIndex = 1;
            this.fon2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "НАЧАТЬ ИГРУ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Location = new System.Drawing.Point(110, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 49);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // SharpBird_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fon2);
            this.Controls.Add(this.fon1);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SharpBird_Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fon1;
        private System.Windows.Forms.PictureBox fon2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

