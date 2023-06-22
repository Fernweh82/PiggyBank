namespace PiggyBank
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.ekleButon = new System.Windows.Forms.Button();
            this.cekButon = new System.Windows.Forms.Button();
            this.shakeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // balanceLabel
            // 
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.balanceLabel.Location = new System.Drawing.Point(286, 228);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(140, 34);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Toplam Tutar:";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.balanceLabel.Click += new System.EventHandler(this.balanceLabel_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(433, 237);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(105, 20);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // ekleButon
            // 
            this.ekleButon.Location = new System.Drawing.Point(267, 289);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(101, 25);
            this.ekleButon.TabIndex = 3;
            this.ekleButon.Text = "Ekle";
            this.ekleButon.UseVisualStyleBackColor = true;
            this.ekleButon.Click += new System.EventHandler(this.ekleButon_Click);
            // 
            // cekButon
            // 
            this.cekButon.Location = new System.Drawing.Point(374, 289);
            this.cekButon.Name = "cekButon";
            this.cekButon.Size = new System.Drawing.Size(104, 25);
            this.cekButon.TabIndex = 4;
            this.cekButon.Text = "Çek";
            this.cekButon.UseVisualStyleBackColor = true;
            this.cekButon.Click += new System.EventHandler(this.cekButon_Click);
            // 
            // shakeButton
            // 
            this.shakeButton.Location = new System.Drawing.Point(484, 289);
            this.shakeButton.Name = "shakeButton";
            this.shakeButton.Size = new System.Drawing.Size(96, 25);
            this.shakeButton.TabIndex = 5;
            this.shakeButton.Text = "Salla";
            this.shakeButton.UseVisualStyleBackColor = true;
            this.shakeButton.Click += new System.EventHandler(this.shakeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shakeButton);
            this.Controls.Add(this.cekButon);
            this.Controls.Add(this.ekleButon);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.Button cekButon;
        private System.Windows.Forms.Button shakeButton;
    }
}

