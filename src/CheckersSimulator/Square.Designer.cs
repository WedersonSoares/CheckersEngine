namespace CheckersSimulator
{
    partial class Square
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.Label();
            this.CheckerContainer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckerContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckerContainer);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.ForeColor = System.Drawing.Color.White;
            this.Id.Location = new System.Drawing.Point(23, 30);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 13);
            this.Id.TabIndex = 0;
            // 
            // CheckerContainer
            // 
            this.CheckerContainer.Location = new System.Drawing.Point(13, 13);
            this.CheckerContainer.Name = "CheckerContainer";
            this.CheckerContainer.Size = new System.Drawing.Size(54, 54);
            this.CheckerContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckerContainer.TabIndex = 1;
            this.CheckerContainer.TabStop = false;
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Square";
            this.Size = new System.Drawing.Size(80, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckerContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Id;
        private System.Windows.Forms.PictureBox CheckerContainer;
    }
}
