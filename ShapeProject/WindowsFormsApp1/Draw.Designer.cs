namespace WindowsFormsApp1
{
    partial class Draw
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
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnLINQ = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.drawCircle = new System.Windows.Forms.Button();
            this.btnTriag = new System.Windows.Forms.Button();
            this.btnDrawIsoscelesTriag = new System.Windows.Forms.Button();
            this.btnDrawScaleneTriag = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(515, 529);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(75, 23);
            this.btnSquare.TabIndex = 0;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(378, 529);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(110, 23);
            this.btnRect.TabIndex = 1;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(770, 529);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 7;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(770, 472);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnLINQ
            // 
            this.btnLINQ.Location = new System.Drawing.Point(770, 362);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(75, 23);
            this.btnLINQ.TabIndex = 9;
            this.btnLINQ.Text = "LINQ";
            this.btnLINQ.UseVisualStyleBackColor = true;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(450, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 95);
            this.listBox1.TabIndex = 10;
            // 
            // drawCircle
            // 
            this.drawCircle.Location = new System.Drawing.Point(621, 529);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(75, 23);
            this.drawCircle.TabIndex = 11;
            this.drawCircle.Text = "Circle";
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // btnTriag
            // 
            this.btnTriag.Location = new System.Drawing.Point(250, 529);
            this.btnTriag.Name = "btnTriag";
            this.btnTriag.Size = new System.Drawing.Size(105, 23);
            this.btnTriag.TabIndex = 12;
            this.btnTriag.Text = "Equilateral Triangle";
            this.btnTriag.UseVisualStyleBackColor = true;
            this.btnTriag.Click += new System.EventHandler(this.btnTriag_Click);
            // 
            // btnDrawIsoscelesTriag
            // 
            this.btnDrawIsoscelesTriag.Location = new System.Drawing.Point(127, 529);
            this.btnDrawIsoscelesTriag.Name = "btnDrawIsoscelesTriag";
            this.btnDrawIsoscelesTriag.Size = new System.Drawing.Size(101, 23);
            this.btnDrawIsoscelesTriag.TabIndex = 13;
            this.btnDrawIsoscelesTriag.Text = "Isosceles Triangle";
            this.btnDrawIsoscelesTriag.UseVisualStyleBackColor = true;
            this.btnDrawIsoscelesTriag.Click += new System.EventHandler(this.btnDrawIsoscelesTriag_Click);
            // 
            // btnDrawScaleneTriag
            // 
            this.btnDrawScaleneTriag.Location = new System.Drawing.Point(12, 529);
            this.btnDrawScaleneTriag.Name = "btnDrawScaleneTriag";
            this.btnDrawScaleneTriag.Size = new System.Drawing.Size(95, 23);
            this.btnDrawScaleneTriag.TabIndex = 14;
            this.btnDrawScaleneTriag.Text = "Scalene Triangle";
            this.btnDrawScaleneTriag.UseVisualStyleBackColor = true;
            this.btnDrawScaleneTriag.Click += new System.EventHandler(this.btnDrawScaleneTriag_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(770, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(770, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.Filter = "\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(770, 182);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 564);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDrawScaleneTriag);
            this.Controls.Add(this.btnDrawIsoscelesTriag);
            this.Controls.Add(this.btnTriag);
            this.Controls.Add(this.drawCircle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLINQ);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnSquare);
            this.Name = "Draw";
            this.Text = "Draw";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawQuadrilateral_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.Button btnTriag;
        private System.Windows.Forms.Button btnDrawIsoscelesTriag;
        private System.Windows.Forms.Button btnDrawScaleneTriag;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpen;
    }
}