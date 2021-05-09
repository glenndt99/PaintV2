
namespace PaintV2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_paste = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_text = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_size_number = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.label_color = new System.Windows.Forms.Label();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_fill = new System.Windows.Forms.Button();
            this.button_polygon = new System.Windows.Forms.Button();
            this.button_circle = new System.Windows.Forms.Button();
            this.button_triangle = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_textDialog = new System.Windows.Forms.Button();
            this.textBox_texto = new System.Windows.Forms.TextBox();
            this.label_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_paste);
            this.panel1.Controls.Add(this.button_copy);
            this.panel1.Controls.Add(this.button_text);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.label_size_number);
            this.panel1.Controls.Add(this.label_size);
            this.panel1.Controls.Add(this.button_plus);
            this.panel1.Controls.Add(this.button_minus);
            this.panel1.Controls.Add(this.pictureBox_color);
            this.panel1.Controls.Add(this.label_color);
            this.panel1.Controls.Add(this.button_eraser);
            this.panel1.Controls.Add(this.button_fill);
            this.panel1.Controls.Add(this.button_polygon);
            this.panel1.Controls.Add(this.button_circle);
            this.panel1.Controls.Add(this.button_triangle);
            this.panel1.Controls.Add(this.button_rectangle);
            this.panel1.Controls.Add(this.button_line);
            this.panel1.Controls.Add(this.button_pencil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 737);
            this.panel1.TabIndex = 1;
            // 
            // button_paste
            // 
            this.button_paste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_paste.Image = global::PaintV2.Properties.Resources.paste;
            this.button_paste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_paste.Location = new System.Drawing.Point(6, 506);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(127, 43);
            this.button_paste.TabIndex = 17;
            this.button_paste.Text = "Paste";
            this.button_paste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // button_copy
            // 
            this.button_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_copy.Image = global::PaintV2.Properties.Resources.copy;
            this.button_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_copy.Location = new System.Drawing.Point(6, 457);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(127, 43);
            this.button_copy.TabIndex = 16;
            this.button_copy.Text = "Copy";
            this.button_copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_text
            // 
            this.button_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_text.Image = global::PaintV2.Properties.Resources.Text;
            this.button_text.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_text.Location = new System.Drawing.Point(6, 408);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(127, 43);
            this.button_text.TabIndex = 15;
            this.button_text.Text = "Text";
            this.button_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button_text_Click);
            // 
            // button_clear
            // 
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.Image = global::PaintV2.Properties.Resources.clear;
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clear.Location = new System.Drawing.Point(6, 562);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(127, 43);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Clear";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_size_number
            // 
            this.label_size_number.AutoSize = true;
            this.label_size_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_size_number.Location = new System.Drawing.Point(56, 699);
            this.label_size_number.Name = "label_size_number";
            this.label_size_number.Size = new System.Drawing.Size(18, 20);
            this.label_size_number.TabIndex = 13;
            this.label_size_number.Text = "5";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_size.Location = new System.Drawing.Point(38, 676);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(59, 16);
            this.label_size.TabIndex = 12;
            this.label_size.Text = "Tamaño";
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(90, 693);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(32, 32);
            this.button_plus.TabIndex = 11;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(9, 693);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(32, 32);
            this.button_minus.TabIndex = 10;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.BackColor = System.Drawing.Color.Black;
            this.pictureBox_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_color.Location = new System.Drawing.Point(90, 637);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_color.TabIndex = 9;
            this.pictureBox_color.TabStop = false;
            this.pictureBox_color.Click += new System.EventHandler(this.pictureBox_color_Click);
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_color.Location = new System.Drawing.Point(12, 637);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(40, 16);
            this.label_color.TabIndex = 8;
            this.label_color.Text = "Color";
            // 
            // button_eraser
            // 
            this.button_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eraser.Image = global::PaintV2.Properties.Resources.Borrador;
            this.button_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_eraser.Location = new System.Drawing.Point(6, 359);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(127, 43);
            this.button_eraser.TabIndex = 7;
            this.button_eraser.Text = "Eraser";
            this.button_eraser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_eraser.UseVisualStyleBackColor = true;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // button_fill
            // 
            this.button_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fill.Image = global::PaintV2.Properties.Resources.Fill;
            this.button_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_fill.Location = new System.Drawing.Point(6, 310);
            this.button_fill.Name = "button_fill";
            this.button_fill.Size = new System.Drawing.Size(127, 43);
            this.button_fill.TabIndex = 6;
            this.button_fill.Text = "Fill";
            this.button_fill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_fill.UseVisualStyleBackColor = true;
            this.button_fill.Click += new System.EventHandler(this.button_fill_Click);
            // 
            // button_polygon
            // 
            this.button_polygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_polygon.Image = global::PaintV2.Properties.Resources.Polygon;
            this.button_polygon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_polygon.Location = new System.Drawing.Point(6, 261);
            this.button_polygon.Name = "button_polygon";
            this.button_polygon.Size = new System.Drawing.Size(127, 43);
            this.button_polygon.TabIndex = 5;
            this.button_polygon.Text = "Polygon";
            this.button_polygon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_polygon.UseVisualStyleBackColor = true;
            this.button_polygon.Click += new System.EventHandler(this.button_polygon_Click);
            // 
            // button_circle
            // 
            this.button_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_circle.Image = global::PaintV2.Properties.Resources.Circle;
            this.button_circle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_circle.Location = new System.Drawing.Point(6, 212);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(127, 43);
            this.button_circle.TabIndex = 4;
            this.button_circle.Text = "Circle";
            this.button_circle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_circle.UseVisualStyleBackColor = true;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // button_triangle
            // 
            this.button_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_triangle.Image = global::PaintV2.Properties.Resources.Triangle;
            this.button_triangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_triangle.Location = new System.Drawing.Point(6, 163);
            this.button_triangle.Name = "button_triangle";
            this.button_triangle.Size = new System.Drawing.Size(127, 43);
            this.button_triangle.TabIndex = 3;
            this.button_triangle.Text = "Triangle";
            this.button_triangle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_triangle.UseVisualStyleBackColor = true;
            this.button_triangle.Click += new System.EventHandler(this.button_triangle_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rectangle.Image = global::PaintV2.Properties.Resources.Rectangle;
            this.button_rectangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rectangle.Location = new System.Drawing.Point(6, 114);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(127, 43);
            this.button_rectangle.TabIndex = 2;
            this.button_rectangle.Text = "Rectangle";
            this.button_rectangle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_line
            // 
            this.button_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_line.Image = global::PaintV2.Properties.Resources.Line;
            this.button_line.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_line.Location = new System.Drawing.Point(6, 65);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(127, 43);
            this.button_line.TabIndex = 1;
            this.button_line.Text = "Line";
            this.button_line.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_pencil
            // 
            this.button_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pencil.Image = global::PaintV2.Properties.Resources.pencil;
            this.button_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pencil.Location = new System.Drawing.Point(6, 16);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(127, 43);
            this.button_pencil.TabIndex = 0;
            this.button_pencil.Text = "Pencil";
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pencil.UseVisualStyleBackColor = true;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button_textDialog);
            this.panel2.Controls.Add(this.textBox_texto);
            this.panel2.Controls.Add(this.label_text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(139, 661);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 100);
            this.panel2.TabIndex = 2;
            // 
            // button_textDialog
            // 
            this.button_textDialog.Location = new System.Drawing.Point(22, 67);
            this.button_textDialog.Name = "button_textDialog";
            this.button_textDialog.Size = new System.Drawing.Size(75, 23);
            this.button_textDialog.TabIndex = 7;
            this.button_textDialog.Text = "Apariencia";
            this.button_textDialog.UseVisualStyleBackColor = true;
            this.button_textDialog.Click += new System.EventHandler(this.button_textDialog_Click);
            // 
            // textBox_texto
            // 
            this.textBox_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_texto.Location = new System.Drawing.Point(22, 39);
            this.textBox_texto.Name = "textBox_texto";
            this.textBox_texto.Size = new System.Drawing.Size(249, 22);
            this.textBox_texto.TabIndex = 6;
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.Location = new System.Drawing.Point(19, 16);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(42, 16);
            this.label_text.TabIndex = 1;
            this.label_text.Text = "Texto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(139, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1045, 637);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_pencil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_polygon;
        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.Button button_triangle;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Button button_fill;
        private System.Windows.Forms.PictureBox pictureBox_color;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Label label_size_number;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.TextBox textBox_texto;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button button_textDialog;
        private System.Windows.Forms.Button button1;
    }
}

