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
            text = new TextBox();
            ngone = new TextBox();
            generate = new Button();
            rad = new TextBox();
            SuspendLayout();
            // 
            // tb_points
            // 
            tb_points.Location = new Point(12, 12);
            tb_points.Multiline = true;
            tb_points.Name = "tb_points";
            tb_points.Size = new Size(227, 195);
            tb_points.TabIndex = 2;
            tb_points.TextAlign = HorizontalAlignment.Center;
            tb_points.TextChanged += tb_points_TextChanged;
            // 
            // square
            // 
            square.Location = new Point(12, 329);
            square.Name = "square";
            square.Size = new Size(227, 23);
            square.TabIndex = 3;
            square.Text = "Square";
            square.UseVisualStyleBackColor = true;
            square.Click += Square;
            // 
            // triangle
            // 
            triangle.Location = new Point(12, 300);
            triangle.Name = "triangle";
            triangle.Size = new Size(227, 23);
            triangle.TabIndex = 4;
            triangle.Text = "Triangle";
            triangle.UseVisualStyleBackColor = true;
            triangle.Click += Triangle;
            // 
            // pentagon
            // 
            pentagon.Location = new Point(12, 271);
            pentagon.Name = "pentagon";
            pentagon.Size = new Size(227, 23);
            pentagon.TabIndex = 5;
            pentagon.Text = "Pentagon";
            pentagon.UseVisualStyleBackColor = true;
            pentagon.Click += Pentagon;
            // 
            // hexagon
            // 
            hexagon.Location = new Point(12, 242);
            hexagon.Name = "hexagon";
            hexagon.Size = new Size(227, 23);
            hexagon.TabIndex = 6;
            hexagon.Text = "Hexagon";
            hexagon.UseVisualStyleBackColor = true;
            hexagon.Click += Hexagon;
            // 
            // octagon
            // 
            octagon.Location = new Point(12, 213);
            octagon.Name = "octagon";
            octagon.Size = new Size(227, 23);
            octagon.TabIndex = 7;
            octagon.Text = "Octagon";
            octagon.UseVisualStyleBackColor = true;
            octagon.Click += Octagon;
            // 
            // text
            // 
            text.Location = new Point(12, 415);
            text.Name = "text";
            text.ReadOnly = true;
            text.Size = new Size(227, 23);
            text.TabIndex = 8;
            // 
            // ngone
            // 
            ngone.Location = new Point(12, 357);
            ngone.Name = "ngone";
            ngone.Size = new Size(108, 23);
            ngone.TabIndex = 9;
            ngone.Text = "N = 0";
            ngone.TextAlign = HorizontalAlignment.Center;
            ngone.TextChanged += ngone_TextChanged;
            // 
            // generate
            // 
            generate.Location = new Point(12, 386);
            generate.Name = "generate";
            generate.Size = new Size(227, 23);
            generate.TabIndex = 10;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // rad
            // 
            rad.Location = new Point(131, 357);
            rad.Name = "rad";
            rad.Size = new Size(108, 23);
            rad.TabIndex = 11;
            rad.Text = "R = 0";
            rad.TextAlign = HorizontalAlignment.Center;
            rad.TextChanged += rad_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rad);
            Controls.Add(generate);
            Controls.Add(ngone);
            Controls.Add(text);
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
        private TextBox text;
        private TextBox ngone;
        private Button generate;
        private TextBox rad;
    }
}