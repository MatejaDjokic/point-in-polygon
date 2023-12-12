namespace point_in_polygon
{
    partial class Form1
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
            tb_points = new TextBox();
            square = new Button();
            triangle = new Button();
            pentagon = new Button();
            hexagon = new Button();
            octagon = new Button();
            SuspendLayout();
            // 
            // tb_points
            // 
            tb_points.Location = new Point(12, 12);
            tb_points.Multiline = true;
            tb_points.Name = "tb_points";
            tb_points.Size = new Size(227, 281);
            tb_points.TabIndex = 2;
            tb_points.TextChanged += tb_points_TextChanged;
            // 
            // square
            // 
            square.Location = new Point(12, 415);
            square.Name = "square";
            square.Size = new Size(227, 23);
            square.TabIndex = 3;
            square.Text = "Square";
            square.UseVisualStyleBackColor = true;
            square.Click += Square;
            // 
            // triangle
            // 
            triangle.Location = new Point(12, 386);
            triangle.Name = "triangle";
            triangle.Size = new Size(227, 23);
            triangle.TabIndex = 4;
            triangle.Text = "Triangle";
            triangle.UseVisualStyleBackColor = true;
            triangle.Click += Triangle;
            // 
            // pentagon
            // 
            pentagon.Location = new Point(12, 357);
            pentagon.Name = "pentagon";
            pentagon.Size = new Size(227, 23);
            pentagon.TabIndex = 5;
            pentagon.Text = "Pentagon";
            pentagon.UseVisualStyleBackColor = true;
            pentagon.Click += Pentagon;
            // 
            // hexagon
            // 
            hexagon.Location = new Point(12, 328);
            hexagon.Name = "hexagon";
            hexagon.Size = new Size(227, 23);
            hexagon.TabIndex = 6;
            hexagon.Text = "Hexagon";
            hexagon.UseVisualStyleBackColor = true;
            hexagon.Click += Hexagon;
            // 
            // octagon
            // 
            octagon.Location = new Point(12, 299);
            octagon.Name = "octagon";
            octagon.Size = new Size(227, 23);
            octagon.TabIndex = 7;
            octagon.Text = "Octagon";
            octagon.Click += Octagon;
            octagon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(octagon);
            Controls.Add(hexagon);
            Controls.Add(pentagon);
            Controls.Add(triangle);
            Controls.Add(square);
            Controls.Add(tb_points);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Point In Polygon";
            Load += Form1Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_points;
        private Button square;
        private Button triangle;
        private Button pentagon;
        private Button hexagon;
        private Button octagon;
    }
}