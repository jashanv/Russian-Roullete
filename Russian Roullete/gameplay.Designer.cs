namespace Russian_Roullete
{
    partial class gameplay
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
            this.bulleteloadbtn = new System.Windows.Forms.Button();
            this.bulletespinbt = new System.Windows.Forms.Button();
            this.Bulleteshotbt = new System.Windows.Forms.Button();
            this.shootawaybt = new System.Windows.Forms.Button();
            this.retrybt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bulleteloadbtn
            // 
            this.bulleteloadbtn.Location = new System.Drawing.Point(110, 89);
            this.bulleteloadbtn.Name = "bulleteloadbtn";
            this.bulleteloadbtn.Size = new System.Drawing.Size(102, 23);
            this.bulleteloadbtn.TabIndex = 0;
            this.bulleteloadbtn.Text = "Bullete Load";
            this.bulleteloadbtn.UseVisualStyleBackColor = true;
            this.bulleteloadbtn.Click += new System.EventHandler(this.bulleteloadbtn_Click);
            // 
            // bulletespinbt
            // 
            this.bulletespinbt.Location = new System.Drawing.Point(229, 89);
            this.bulletespinbt.Name = "bulletespinbt";
            this.bulletespinbt.Size = new System.Drawing.Size(102, 23);
            this.bulletespinbt.TabIndex = 1;
            this.bulletespinbt.Text = "Bullete Spin";
            this.bulletespinbt.UseVisualStyleBackColor = true;
            this.bulletespinbt.Click += new System.EventHandler(this.bulletespinbt_Click);
            // 
            // Bulleteshotbt
            // 
            this.Bulleteshotbt.Location = new System.Drawing.Point(337, 89);
            this.Bulleteshotbt.Name = "Bulleteshotbt";
            this.Bulleteshotbt.Size = new System.Drawing.Size(102, 23);
            this.Bulleteshotbt.TabIndex = 2;
            this.Bulleteshotbt.Text = "Shoot";
            this.Bulleteshotbt.UseVisualStyleBackColor = true;
            this.Bulleteshotbt.Click += new System.EventHandler(this.Bulleteshotbt_Click);
            // 
            // shootawaybt
            // 
            this.shootawaybt.Location = new System.Drawing.Point(445, 89);
            this.shootawaybt.Name = "shootawaybt";
            this.shootawaybt.Size = new System.Drawing.Size(102, 23);
            this.shootawaybt.TabIndex = 3;
            this.shootawaybt.Text = "Shoot Away";
            this.shootawaybt.UseVisualStyleBackColor = true;
            this.shootawaybt.Click += new System.EventHandler(this.shootawaybt_Click);
            // 
            // retrybt
            // 
            this.retrybt.Location = new System.Drawing.Point(563, 89);
            this.retrybt.Name = "retrybt";
            this.retrybt.Size = new System.Drawing.Size(102, 23);
            this.retrybt.TabIndex = 4;
            this.retrybt.Text = "Retry";
            this.retrybt.UseVisualStyleBackColor = true;
            this.retrybt.Click += new System.EventHandler(this.retrybt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Russian Roullete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(142, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 242);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retrybt);
            this.Controls.Add(this.shootawaybt);
            this.Controls.Add(this.Bulleteshotbt);
            this.Controls.Add(this.bulletespinbt);
            this.Controls.Add(this.bulleteloadbtn);
            this.Name = "gameplay";
            this.Text = "gameplay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bulleteloadbtn;
        private System.Windows.Forms.Button bulletespinbt;
        private System.Windows.Forms.Button Bulleteshotbt;
        private System.Windows.Forms.Button shootawaybt;
        private System.Windows.Forms.Button retrybt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}