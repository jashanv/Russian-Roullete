namespace Russian_Roullete
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
            this.Playbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playbt
            // 
            this.Playbt.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playbt.Location = new System.Drawing.Point(446, 374);
            this.Playbt.Name = "Playbt";
            this.Playbt.Size = new System.Drawing.Size(240, 50);
            this.Playbt.TabIndex = 0;
            this.Playbt.Text = "Play";
            this.Playbt.UseVisualStyleBackColor = true;
            this.Playbt.Click += new System.EventHandler(this.Playbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_Roullete.Properties.Resources._192439;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.Playbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Playbt;
    }
}

