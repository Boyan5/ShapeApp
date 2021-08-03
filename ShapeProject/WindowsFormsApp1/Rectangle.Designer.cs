namespace WindowsFormsApp1
{
    partial class Rectangle
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
            this.btnDescribe = new System.Windows.Forms.Button();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.btnCalcPerimeter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblCalcArea = new System.Windows.Forms.Label();
            this.lblCalcPerimeter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(84, 111);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxA.TabIndex = 0;
            this.txtBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxA_KeyPress);
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(84, 215);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxB.TabIndex = 1;
            this.txtBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxB_KeyPress);
            // 
            // btnDescribe
            // 
            this.btnDescribe.Location = new System.Drawing.Point(84, 350);
            this.btnDescribe.Name = "btnDescribe";
            this.btnDescribe.Size = new System.Drawing.Size(100, 41);
            this.btnDescribe.TabIndex = 2;
            this.btnDescribe.Text = "Describe";
            this.btnDescribe.UseVisualStyleBackColor = true;
            this.btnDescribe.Click += new System.EventHandler(this.btnDescribe_Click);
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.Location = new System.Drawing.Point(282, 350);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(102, 41);
            this.btnCalcArea.TabIndex = 3;
            this.btnCalcArea.Text = "Calculate Area";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click);
            // 
            // btnCalcPerimeter
            // 
            this.btnCalcPerimeter.Location = new System.Drawing.Point(471, 350);
            this.btnCalcPerimeter.Name = "btnCalcPerimeter";
            this.btnCalcPerimeter.Size = new System.Drawing.Size(109, 41);
            this.btnCalcPerimeter.TabIndex = 4;
            this.btnCalcPerimeter.Text = "Calculate Perimeter";
            this.btnCalcPerimeter.UseVisualStyleBackColor = true;
            this.btnCalcPerimeter.Click += new System.EventHandler(this.btnCalcPerimeter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(680, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(81, 82);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(38, 13);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "Side A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(81, 183);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(38, 13);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "Side B";
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescribe.Location = new System.Drawing.Point(258, 82);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(0, 24);
            this.lblDescribe.TabIndex = 9;
            // 
            // lblCalcArea
            // 
            this.lblCalcArea.AutoSize = true;
            this.lblCalcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcArea.Location = new System.Drawing.Point(258, 169);
            this.lblCalcArea.Name = "lblCalcArea";
            this.lblCalcArea.Size = new System.Drawing.Size(0, 24);
            this.lblCalcArea.TabIndex = 10;
            // 
            // lblCalcPerimeter
            // 
            this.lblCalcPerimeter.AutoSize = true;
            this.lblCalcPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalcPerimeter.Location = new System.Drawing.Point(258, 257);
            this.lblCalcPerimeter.Name = "lblCalcPerimeter";
            this.lblCalcPerimeter.Size = new System.Drawing.Size(0, 24);
            this.lblCalcPerimeter.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(680, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDrawing
            // 
            this.btnDrawing.Location = new System.Drawing.Point(680, 215);
            this.btnDrawing.Name = "btnDrawing";
            this.btnDrawing.Size = new System.Drawing.Size(93, 42);
            this.btnDrawing.TabIndex = 25;
            this.btnDrawing.Text = "Draw";
            this.btnDrawing.UseVisualStyleBackColor = true;
            this.btnDrawing.Click += new System.EventHandler(this.btnDrawing_Click);
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrawing);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCalcPerimeter);
            this.Controls.Add(this.lblCalcArea);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalcPerimeter);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.btnDescribe);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxA);
            this.Name = "Rectangle";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Button btnDescribe;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Button btnCalcPerimeter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblCalcArea;
        private System.Windows.Forms.Label lblCalcPerimeter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDrawing;
    }
}