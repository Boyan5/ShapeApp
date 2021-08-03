namespace WindowsFormsApp1
{
    partial class Shapes
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.colorDialog5 = new System.Windows.Forms.ColorDialog();
            this.colorDialog6 = new System.Windows.Forms.ColorDialog();
            this.DialogColor = new System.Windows.Forms.ColorDialog();
            this.radbutTriangle = new System.Windows.Forms.RadioButton();
            this.radbutQuadrilateral = new System.Windows.Forms.RadioButton();
            this.radbutCircle = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontDialog2
            // 
            this.fontDialog2.Color = System.Drawing.Color.DarkRed;
            // 
            // radbutTriangle
            // 
            this.radbutTriangle.AutoSize = true;
            this.radbutTriangle.Location = new System.Drawing.Point(52, 101);
            this.radbutTriangle.Name = "radbutTriangle";
            this.radbutTriangle.Size = new System.Drawing.Size(63, 17);
            this.radbutTriangle.TabIndex = 0;
            this.radbutTriangle.TabStop = true;
            this.radbutTriangle.Text = "Triangle";
            this.radbutTriangle.UseVisualStyleBackColor = true;
            // 
            // radbutQuadrilateral
            // 
            this.radbutQuadrilateral.AutoSize = true;
            this.radbutQuadrilateral.Location = new System.Drawing.Point(52, 151);
            this.radbutQuadrilateral.Name = "radbutQuadrilateral";
            this.radbutQuadrilateral.Size = new System.Drawing.Size(84, 17);
            this.radbutQuadrilateral.TabIndex = 1;
            this.radbutQuadrilateral.TabStop = true;
            this.radbutQuadrilateral.Text = "Quadrilateral";
            this.radbutQuadrilateral.UseVisualStyleBackColor = true;
            // 
            // radbutCircle
            // 
            this.radbutCircle.AutoSize = true;
            this.radbutCircle.Location = new System.Drawing.Point(52, 202);
            this.radbutCircle.Name = "radbutCircle";
            this.radbutCircle.Size = new System.Drawing.Size(51, 17);
            this.radbutCircle.TabIndex = 2;
            this.radbutCircle.TabStop = true;
            this.radbutCircle.Text = "Circle";
            this.radbutCircle.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(90, 384);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.radbutCircle);
            this.Controls.Add(this.radbutQuadrilateral);
            this.Controls.Add(this.radbutTriangle);
            this.Name = "Shapes";
            this.Text = "Shapes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.ColorDialog colorDialog5;
        private System.Windows.Forms.ColorDialog colorDialog6;
        private System.Windows.Forms.ColorDialog DialogColor;
        private System.Windows.Forms.RadioButton radbutTriangle;
        private System.Windows.Forms.RadioButton radbutQuadrilateral;
        private System.Windows.Forms.RadioButton radbutCircle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
    }
}

