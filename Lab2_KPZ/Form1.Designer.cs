namespace Lab2_KPZ
{
    partial class Form1
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
            this.CircleBtn = new System.Windows.Forms.Button();
            this.TriangleBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CircleBtn
            // 
            this.CircleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CircleBtn.Location = new System.Drawing.Point(320, 64);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(105, 55);
            this.CircleBtn.TabIndex = 0;
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TriangleBtn.Location = new System.Drawing.Point(320, 125);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(105, 55);
            this.TriangleBtn.TabIndex = 1;
            this.TriangleBtn.Text = "Triangle";
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.SquareBtn.Location = new System.Drawing.Point(320, 186);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(105, 55);
            this.SquareBtn.TabIndex = 2;
            this.SquareBtn.Text = "Square";
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.RectangleBtn.Location = new System.Drawing.Point(320, 247);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(105, 55);
            this.RectangleBtn.TabIndex = 3;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Controls.Add(this.CircleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button RectangleBtn;
    }
}

