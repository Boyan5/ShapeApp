namespace WindowsFormsApp1
{
    partial class Triangle
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
            this.radbutScalTriag = new System.Windows.Forms.RadioButton();
            this.radbutIsoTriag = new System.Windows.Forms.RadioButton();
            this.radbutEquilTriag = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radbutScalTriag
            // 
            this.radbutScalTriag.AutoSize = true;
            this.radbutScalTriag.Location = new System.Drawing.Point(115, 92);
            this.radbutScalTriag.Name = "radbutScalTriag";
            this.radbutScalTriag.Size = new System.Drawing.Size(105, 17);
            this.radbutScalTriag.TabIndex = 1;
            this.radbutScalTriag.TabStop = true;
            this.radbutScalTriag.Text = "Scalene Triangle";
            this.radbutScalTriag.UseVisualStyleBackColor = true;
            // 
            // radbutIsoTriag
            // 
            this.radbutIsoTriag.AutoSize = true;
            this.radbutIsoTriag.Location = new System.Drawing.Point(110, 180);
            this.radbutIsoTriag.Name = "radbutIsoTriag";
            this.radbutIsoTriag.Size = new System.Drawing.Size(110, 17);
            this.radbutIsoTriag.TabIndex = 2;
            this.radbutIsoTriag.TabStop = true;
            this.radbutIsoTriag.Text = "Isosceles Triangle";
            this.radbutIsoTriag.UseVisualStyleBackColor = true;
            // 
            // radbutEquilTriag
            // 
            this.radbutEquilTriag.AutoSize = true;
            this.radbutEquilTriag.Location = new System.Drawing.Point(115, 269);
            this.radbutEquilTriag.Name = "radbutEquilTriag";
            this.radbutEquilTriag.Size = new System.Drawing.Size(115, 17);
            this.radbutEquilTriag.TabIndex = 3;
            this.radbutEquilTriag.TabStop = true;
            this.radbutEquilTriag.Text = "Equilateral Triangle";
            this.radbutEquilTriag.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(115, 359);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(91, 39);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(577, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.radbutEquilTriag);
            this.Controls.Add(this.radbutIsoTriag);
            this.Controls.Add(this.radbutScalTriag);
            this.Name = "Triangle";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radbutScalTriag;
        private System.Windows.Forms.RadioButton radbutIsoTriag;
        private System.Windows.Forms.RadioButton radbutEquilTriag;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}