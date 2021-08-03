namespace WindowsFormsApp1
{
    partial class EquilateralTriangle
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
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.btnDescribe = new System.Windows.Forms.Button();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.btnCalcPerimeter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblCalcArea = new System.Windows.Forms.Label();
            this.lblCalcPerimeter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(71, 191);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxA.TabIndex = 0;
            this.txtBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxA_KeyPress);
            // 
            // btnDescribe
            // 
            this.btnDescribe.Location = new System.Drawing.Point(71, 370);
            this.btnDescribe.Name = "btnDescribe";
            this.btnDescribe.Size = new System.Drawing.Size(100, 45);
            this.btnDescribe.TabIndex = 1;
            this.btnDescribe.Text = "Describe";
            this.btnDescribe.UseVisualStyleBackColor = true;
            this.btnDescribe.Click += new System.EventHandler(this.btnDescribe_Click);
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.Location = new System.Drawing.Point(235, 370);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(100, 45);
            this.btnCalcArea.TabIndex = 2;
            this.btnCalcArea.Text = "Calculate Area";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click);
            // 
            // btnCalcPerimeter
            // 
            this.btnCalcPerimeter.Location = new System.Drawing.Point(391, 370);
            this.btnCalcPerimeter.Name = "btnCalcPerimeter";
            this.btnCalcPerimeter.Size = new System.Drawing.Size(107, 45);
            this.btnCalcPerimeter.TabIndex = 3;
            this.btnCalcPerimeter.Text = "Calculate Perimeter";
            this.btnCalcPerimeter.UseVisualStyleBackColor = true;
            this.btnCalcPerimeter.Click += new System.EventHandler(this.btnCalcPerimeter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(579, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(68, 162);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(38, 13);
            this.lblSideA.TabIndex = 6;
            this.lblSideA.Text = "Side A";
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescribe.Location = new System.Drawing.Point(222, 137);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(0, 24);
            this.lblDescribe.TabIndex = 7;
            // 
            // lblCalcArea
            // 
            this.lblCalcArea.AutoSize = true;
            this.lblCalcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcArea.Location = new System.Drawing.Point(222, 203);
            this.lblCalcArea.Name = "lblCalcArea";
            this.lblCalcArea.Size = new System.Drawing.Size(0, 24);
            this.lblCalcArea.TabIndex = 8;
            // 
            // lblCalcPerimeter
            // 
            this.lblCalcPerimeter.AutoSize = true;
            this.lblCalcPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcPerimeter.Location = new System.Drawing.Point(222, 273);
            this.lblCalcPerimeter.Name = "lblCalcPerimeter";
            this.lblCalcPerimeter.Size = new System.Drawing.Size(0, 24);
            this.lblCalcPerimeter.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDrawing
            // 
            this.btnDrawing.Location = new System.Drawing.Point(684, 262);
            this.btnDrawing.Name = "btnDrawing";
            this.btnDrawing.Size = new System.Drawing.Size(94, 35);
            this.btnDrawing.TabIndex = 25;
            this.btnDrawing.Text = "Draw";
            this.btnDrawing.UseVisualStyleBackColor = true;
            this.btnDrawing.Click += new System.EventHandler(this.btnDrawing_Click);
            // 
            // EquilateralTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrawing);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCalcPerimeter);
            this.Controls.Add(this.lblCalcArea);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalcPerimeter);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.btnDescribe);
            this.Controls.Add(this.txtBoxA);
            this.Name = "EquilateralTriangle";
            this.Text = "EquilateralTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.Button btnDescribe;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Button btnCalcPerimeter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblCalcArea;
        private System.Windows.Forms.Label lblCalcPerimeter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDrawing;
    }
}