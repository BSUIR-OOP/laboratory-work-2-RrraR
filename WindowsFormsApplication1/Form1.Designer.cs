namespace WindowsFormsApplication1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawCombo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drawPolygon = new System.Windows.Forms.Button();
            this.drawEllipse = new System.Windows.Forms.Button();
            this.drawRectangle = new System.Windows.Forms.Button();
            this.drawTriangle = new System.Windows.Forms.Button();
            this.drawLine = new System.Windows.Forms.Button();
            this.drawDot = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDrawCombo);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.openButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.drawPolygon);
            this.panel1.Controls.Add(this.drawEllipse);
            this.panel1.Controls.Add(this.drawRectangle);
            this.panel1.Controls.Add(this.drawTriangle);
            this.panel1.Controls.Add(this.drawLine);
            this.panel1.Controls.Add(this.drawDot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1338, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1211);
            this.panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(48, 1104);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 78);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDrawCombo
            // 
            this.btnDrawCombo.Location = new System.Drawing.Point(48, 649);
            this.btnDrawCombo.Margin = new System.Windows.Forms.Padding(6);
            this.btnDrawCombo.Name = "btnDrawCombo";
            this.btnDrawCombo.Size = new System.Drawing.Size(250, 79);
            this.btnDrawCombo.TabIndex = 12;
            this.btnDrawCombo.Text = "Draw selected";
            this.btnDrawCombo.UseVisualStyleBackColor = true;
            this.btnDrawCombo.Click += new System.EventHandler(this.btnDrawCombo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 587);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 39);
            this.comboBox1.TabIndex = 11;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(48, 1015);
            this.openButton.Margin = new System.Windows.Forms.Padding(6);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(250, 78);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(48, 926);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(250, 78);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(34, 740);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(304, 171);
            this.textBox1.TabIndex = 7;
            // 
            // drawPolygon
            // 
            this.drawPolygon.Enabled = false;
            this.drawPolygon.Location = new System.Drawing.Point(48, 487);
            this.drawPolygon.Margin = new System.Windows.Forms.Padding(6);
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.Size = new System.Drawing.Size(250, 79);
            this.drawPolygon.TabIndex = 5;
            this.drawPolygon.Text = "Polygon";
            this.drawPolygon.UseVisualStyleBackColor = true;
            this.drawPolygon.Click += new System.EventHandler(this.drawPolygon_Click);
            // 
            // drawEllipse
            // 
            this.drawEllipse.Enabled = false;
            this.drawEllipse.Location = new System.Drawing.Point(48, 396);
            this.drawEllipse.Margin = new System.Windows.Forms.Padding(6);
            this.drawEllipse.Name = "drawEllipse";
            this.drawEllipse.Size = new System.Drawing.Size(250, 79);
            this.drawEllipse.TabIndex = 4;
            this.drawEllipse.Text = "Ellipse";
            this.drawEllipse.UseVisualStyleBackColor = true;
            this.drawEllipse.Click += new System.EventHandler(this.button5_Click);
            // 
            // drawRectangle
            // 
            this.drawRectangle.Enabled = false;
            this.drawRectangle.Location = new System.Drawing.Point(48, 305);
            this.drawRectangle.Margin = new System.Windows.Forms.Padding(6);
            this.drawRectangle.Name = "drawRectangle";
            this.drawRectangle.Size = new System.Drawing.Size(250, 79);
            this.drawRectangle.TabIndex = 3;
            this.drawRectangle.Text = "Rectangle";
            this.drawRectangle.UseVisualStyleBackColor = true;
            this.drawRectangle.Click += new System.EventHandler(this.button4_Click);
            // 
            // drawTriangle
            // 
            this.drawTriangle.Enabled = false;
            this.drawTriangle.Location = new System.Drawing.Point(48, 214);
            this.drawTriangle.Margin = new System.Windows.Forms.Padding(6);
            this.drawTriangle.Name = "drawTriangle";
            this.drawTriangle.Size = new System.Drawing.Size(250, 79);
            this.drawTriangle.TabIndex = 2;
            this.drawTriangle.Text = "Triangle";
            this.drawTriangle.UseVisualStyleBackColor = true;
            this.drawTriangle.Click += new System.EventHandler(this.button3_Click);
            // 
            // drawLine
            // 
            this.drawLine.Enabled = false;
            this.drawLine.Location = new System.Drawing.Point(48, 123);
            this.drawLine.Margin = new System.Windows.Forms.Padding(6);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(250, 79);
            this.drawLine.TabIndex = 1;
            this.drawLine.Text = "Line";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.button2_Click);
            // 
            // drawDot
            // 
            this.drawDot.Enabled = false;
            this.drawDot.Location = new System.Drawing.Point(48, 37);
            this.drawDot.Margin = new System.Windows.Forms.Padding(6);
            this.drawDot.Name = "drawDot";
            this.drawDot.Size = new System.Drawing.Size(250, 74);
            this.drawDot.TabIndex = 0;
            this.drawDot.Text = "Dot";
            this.drawDot.UseVisualStyleBackColor = true;
            this.drawDot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 1211);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button drawDot;
        private System.Windows.Forms.Button drawPolygon;
        private System.Windows.Forms.Button drawEllipse;
        private System.Windows.Forms.Button drawRectangle;
        private System.Windows.Forms.Button drawTriangle;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDrawCombo;
        private System.Windows.Forms.Button btnClear;
    }
}

