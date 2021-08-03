namespace WindowsFormsApp1
{
    partial class Quadrialateral
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
            this.radButRectangle = new System.Windows.Forms.RadioButton();
            this.radButSquare = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radButRectangle
            // 
            this.radButRectangle.AutoSize = true;
            this.radButRectangle.Location = new System.Drawing.Point(134, 104);
            this.radButRectangle.Name = "radButRectangle";
            this.radButRectangle.Size = new System.Drawing.Size(74, 17);
            this.radButRectangle.TabIndex = 1;
            this.radButRectangle.TabStop = true;
            this.radButRectangle.Text = "Rectangle";
            this.radButRectangle.UseVisualStyleBackColor = true;
            // 
            // radButSquare
            // 
            this.radButSquare.AutoSize = true;
            this.radButSquare.Location = new System.Drawing.Point(134, 226);
            this.radButSquare.Name = "radButSquare";
            this.radButSquare.Size = new System.Drawing.Size(59, 17);
            this.radButSquare.TabIndex = 3;
            this.radButSquare.TabStop = true;
            this.radButSquare.Text = "Square";
            this.radButSquare.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(134, 347);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 42);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Quadrialateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.radButSquare);
            this.Controls.Add(this.radButRectangle);
            this.Name = "Quadrialateral";
            this.Text = "Quadrilateral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radButRectangle;
        private System.Windows.Forms.RadioButton radButSquare;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}