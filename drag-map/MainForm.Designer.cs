
namespace drag_map
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countryMapImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countryMapImage
            // 
            this.countryMapImage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.countryMapImage.Location = new System.Drawing.Point(27, 39);
            this.countryMapImage.Name = "countryMapImage";
            this.countryMapImage.Size = new System.Drawing.Size(100, 100);
            this.countryMapImage.TabIndex = 0;
            this.countryMapImage.Text = "Map";
            this.countryMapImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryMapImage);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label countryMapImage;
    }
}

