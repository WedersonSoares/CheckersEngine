namespace CheckersSimulator
{
    partial class frmCheckersSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckersSimulator));
            this.pbxWhiteChecker = new System.Windows.Forms.PictureBox();
            this.pbxRedChecker = new System.Windows.Forms.PictureBox();
            this.squareTemplate = new CheckersSimulator.Square();
            this.checker = new CheckersSimulator.Checker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWhiteChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxWhiteChecker
            // 
            this.pbxWhiteChecker.Image = ((System.Drawing.Image)(resources.GetObject("pbxWhiteChecker.Image")));
            this.pbxWhiteChecker.Location = new System.Drawing.Point(12, 121);
            this.pbxWhiteChecker.Name = "pbxWhiteChecker";
            this.pbxWhiteChecker.Size = new System.Drawing.Size(54, 54);
            this.pbxWhiteChecker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWhiteChecker.TabIndex = 3;
            this.pbxWhiteChecker.TabStop = false;
            // 
            // pbxRedChecker
            // 
            this.pbxRedChecker.Image = ((System.Drawing.Image)(resources.GetObject("pbxRedChecker.Image")));
            this.pbxRedChecker.Location = new System.Drawing.Point(12, 181);
            this.pbxRedChecker.Name = "pbxRedChecker";
            this.pbxRedChecker.Size = new System.Drawing.Size(54, 54);
            this.pbxRedChecker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRedChecker.TabIndex = 4;
            this.pbxRedChecker.TabStop = false;
            // 
            // squareTemplate
            // 
            this.squareTemplate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.squareTemplate.Location = new System.Drawing.Point(12, 12);
            this.squareTemplate.Name = "squareTemplate";
            this.squareTemplate.Size = new System.Drawing.Size(80, 80);
            this.squareTemplate.TabIndex = 2;
            this.squareTemplate.Visible = false;
            this.squareTemplate.Load += new System.EventHandler(this.squareTemplate_Load);
            // 
            // checker
            // 
            this.checker.AutoSize = true;
            this.checker.BackColor = System.Drawing.Color.Transparent;
            this.checker.Location = new System.Drawing.Point(12, 241);
            this.checker.Name = "checker";
            this.checker.Size = new System.Drawing.Size(57, 57);
            this.checker.TabIndex = 3;
            // 
            // frmCheckersSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(834, 514);
            this.Controls.Add(this.pbxRedChecker);
            this.Controls.Add(this.pbxWhiteChecker);
            this.Controls.Add(this.squareTemplate);
            this.Controls.Add(this.checker);
            this.Name = "frmCheckersSimulator";
            this.Text = "Checkers Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckersSimulator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWhiteChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckersSimulator.Checker checker;
        private CheckersSimulator.Square squareTemplate;
        private System.Windows.Forms.PictureBox pbxWhiteChecker;
        private System.Windows.Forms.PictureBox pbxRedChecker;
    }
}

