namespace WindowsFormsApp1
{
    partial class Circle
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
            this.txtBoxR = new System.Windows.Forms.TextBox();
            this.btnDescribe = new System.Windows.Forms.Button();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.btnCalcPerimeter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.lblCalcArea = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblCalcPerimeter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxR
            // 
            this.txtBoxR.Location = new System.Drawing.Point(91, 172);
            this.txtBoxR.Name = "txtBoxR";
            this.txtBoxR.Size = new System.Drawing.Size(100, 20);
            this.txtBoxR.TabIndex = 0;
            this.txtBoxR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxR_KeyPress);
            // 
            // btnDescribe
            // 
            this.btnDescribe.Location = new System.Drawing.Point(91, 357);
            this.btnDescribe.Name = "btnDescribe";
            this.btnDescribe.Size = new System.Drawing.Size(100, 44);
            this.btnDescribe.TabIndex = 1;
            this.btnDescribe.Text = "Describe";
            this.btnDescribe.UseVisualStyleBackColor = true;
            this.btnDescribe.Click += new System.EventHandler(this.btnDescribe_Click);
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.Location = new System.Drawing.Point(276, 357);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(112, 44);
            this.btnCalcArea.TabIndex = 2;
            this.btnCalcArea.Text = "Calculate Area";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click);
            // 
            // btnCalcPerimeter
            // 
            this.btnCalcPerimeter.Location = new System.Drawing.Point(481, 357);
            this.btnCalcPerimeter.Name = "btnCalcPerimeter";
            this.btnCalcPerimeter.Size = new System.Drawing.Size(115, 44);
            this.btnCalcPerimeter.TabIndex = 3;
            this.btnCalcPerimeter.Text = "Calculate Perimeter";
            this.btnCalcPerimeter.UseVisualStyleBackColor = true;
            this.btnCalcPerimeter.Click += new System.EventHandler(this.btnCalcPerimeter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(651, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(88, 144);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(40, 13);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "Radius";
            // 
            // lblCalcArea
            // 
            this.lblCalcArea.AutoSize = true;
            this.lblCalcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcArea.Location = new System.Drawing.Point(258, 179);
            this.lblCalcArea.Name = "lblCalcArea";
            this.lblCalcArea.Size = new System.Drawing.Size(0, 24);
            this.lblCalcArea.TabIndex = 8;
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescribe.Location = new System.Drawing.Point(258, 93);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(0, 24);
            this.lblDescribe.TabIndex = 9;
            // 
            // lblCalcPerimeter
            // 
            this.lblCalcPerimeter.AutoSize = true;
            this.lblCalcPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcPerimeter.Location = new System.Drawing.Point(258, 261);
            this.lblCalcPerimeter.Name = "lblCalcPerimeter";
            this.lblCalcPerimeter.Size = new System.Drawing.Size(0, 24);
            this.lblCalcPerimeter.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(686, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(686, 74);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(92, 43);
            this.btnDraw.TabIndex = 11;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblCalcPerimeter);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblCalcArea);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalcPerimeter);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.btnDescribe);
            this.Controls.Add(this.txtBoxR);
            this.Name = "Circle";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxR;
        private System.Windows.Forms.Button btnDescribe;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Button btnCalcPerimeter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblCalcArea;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblCalcPerimeter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDraw;
    }
}