namespace WindowsFormsApp1
{
    partial class ScaleneTriangle
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
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.btnCalcPerimeter = new System.Windows.Forms.Button();
            this.btnDescribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblCalcArea = new System.Windows.Forms.Label();
            this.lblCalcPerimeter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(49, 87);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxA.TabIndex = 0;
            this.txtBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxA_KeyPress);
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(49, 182);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxB.TabIndex = 1;
            this.txtBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxB_KeyPress);
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(49, 276);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(100, 20);
            this.txtBoxC.TabIndex = 2;
            this.txtBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxC_KeyPress);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(49, 50);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(38, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Side A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(49, 141);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(38, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Side B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(52, 242);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(38, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Side C";
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.Location = new System.Drawing.Point(274, 370);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(102, 42);
            this.btnCalcArea.TabIndex = 6;
            this.btnCalcArea.Text = "Calculate Area";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click);
            // 
            // btnCalcPerimeter
            // 
            this.btnCalcPerimeter.Location = new System.Drawing.Point(467, 370);
            this.btnCalcPerimeter.Name = "btnCalcPerimeter";
            this.btnCalcPerimeter.Size = new System.Drawing.Size(106, 42);
            this.btnCalcPerimeter.TabIndex = 7;
            this.btnCalcPerimeter.Text = "Calculate Perimeter";
            this.btnCalcPerimeter.UseVisualStyleBackColor = true;
            this.btnCalcPerimeter.Click += new System.EventHandler(this.btnCalcPerimeter_Click);
            // 
            // btnDescribe
            // 
            this.btnDescribe.Location = new System.Drawing.Point(55, 370);
            this.btnDescribe.Name = "btnDescribe";
            this.btnDescribe.Size = new System.Drawing.Size(100, 42);
            this.btnDescribe.TabIndex = 8;
            this.btnDescribe.Text = "Describe";
            this.btnDescribe.UseVisualStyleBackColor = true;
            this.btnDescribe.Click += new System.EventHandler(this.btnDescribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(678, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 42);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescribe.Location = new System.Drawing.Point(215, 71);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(0, 24);
            this.lblDescribe.TabIndex = 11;
            // 
            // lblCalcArea
            // 
            this.lblCalcArea.AutoSize = true;
            this.lblCalcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcArea.Location = new System.Drawing.Point(216, 172);
            this.lblCalcArea.Name = "lblCalcArea";
            this.lblCalcArea.Size = new System.Drawing.Size(0, 24);
            this.lblCalcArea.TabIndex = 12;
            // 
            // lblCalcPerimeter
            // 
            this.lblCalcPerimeter.AutoSize = true;
            this.lblCalcPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcPerimeter.Location = new System.Drawing.Point(215, 260);
            this.lblCalcPerimeter.Name = "lblCalcPerimeter";
            this.lblCalcPerimeter.Size = new System.Drawing.Size(0, 24);
            this.lblCalcPerimeter.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(678, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 39);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDrawing
            // 
            this.btnDrawing.Location = new System.Drawing.Point(678, 243);
            this.btnDrawing.Name = "btnDrawing";
            this.btnDrawing.Size = new System.Drawing.Size(82, 41);
            this.btnDrawing.TabIndex = 25;
            this.btnDrawing.Text = "Draw";
            this.btnDrawing.UseVisualStyleBackColor = true;
            this.btnDrawing.Click += new System.EventHandler(this.btnDrawing_Click);
            // 
            // ScaleneTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrawing);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCalcPerimeter);
            this.Controls.Add(this.lblCalcArea);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDescribe);
            this.Controls.Add(this.btnCalcPerimeter);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtBoxC);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxA);
            this.Name = "ScaleneTriangle";
            this.Text = "ScaleneTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Button btnCalcPerimeter;
        private System.Windows.Forms.Button btnDescribe;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblCalcArea;
        private System.Windows.Forms.Label lblCalcPerimeter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDrawing;
    }
}