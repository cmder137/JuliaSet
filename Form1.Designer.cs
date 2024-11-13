namespace JuliaSet
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
            splitContainer1 = new SplitContainer();
            pictureBoxField = new PictureBox();
            buttonExit = new Button();
            buttonSave = new Button();
            buttonStart = new Button();
            numericUpDownScale = new NumericUpDown();
            labelScale = new Label();
            numericUpDownIterations = new NumericUpDown();
            labelIterations = new Label();
            numericUpDownIm = new NumericUpDown();
            labelIm = new Label();
            numericUpDownRe = new NumericUpDown();
            labelRe = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIterations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRe).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBoxField);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonExit);
            splitContainer1.Panel2.Controls.Add(buttonSave);
            splitContainer1.Panel2.Controls.Add(buttonStart);
            splitContainer1.Panel2.Controls.Add(numericUpDownScale);
            splitContainer1.Panel2.Controls.Add(labelScale);
            splitContainer1.Panel2.Controls.Add(numericUpDownIterations);
            splitContainer1.Panel2.Controls.Add(labelIterations);
            splitContainer1.Panel2.Controls.Add(numericUpDownIm);
            splitContainer1.Panel2.Controls.Add(labelIm);
            splitContainer1.Panel2.Controls.Add(numericUpDownRe);
            splitContainer1.Panel2.Controls.Add(labelRe);
            splitContainer1.Size = new Size(883, 591);
            splitContainer1.SplitterDistance = 674;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBoxField
            // 
            pictureBoxField.BackColor = Color.Transparent;
            pictureBoxField.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxField.Dock = DockStyle.Fill;
            pictureBoxField.Location = new Point(0, 0);
            pictureBoxField.Name = "pictureBoxField";
            pictureBoxField.Size = new Size(670, 587);
            pictureBoxField.TabIndex = 0;
            pictureBoxField.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Bottom;
            buttonExit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(0, 536);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(201, 51);
            buttonExit.TabIndex = 14;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Top;
            buttonSave.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(0, 455);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(201, 51);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonStart
            // 
            buttonStart.Dock = DockStyle.Top;
            buttonStart.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(0, 404);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(201, 51);
            buttonStart.TabIndex = 12;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // numericUpDownScale
            // 
            numericUpDownScale.DecimalPlaces = 1;
            numericUpDownScale.Dock = DockStyle.Top;
            numericUpDownScale.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownScale.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownScale.Location = new Point(0, 353);
            numericUpDownScale.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownScale.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownScale.Name = "numericUpDownScale";
            numericUpDownScale.RightToLeft = RightToLeft.No;
            numericUpDownScale.Size = new Size(201, 51);
            numericUpDownScale.TabIndex = 11;
            numericUpDownScale.TextAlign = HorizontalAlignment.Center;
            numericUpDownScale.Value = new decimal(new int[] { 25, 0, 0, 65536 });
            // 
            // labelScale
            // 
            labelScale.BackColor = SystemColors.Control;
            labelScale.Dock = DockStyle.Top;
            labelScale.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelScale.Location = new Point(0, 303);
            labelScale.Name = "labelScale";
            labelScale.Size = new Size(201, 50);
            labelScale.TabIndex = 10;
            labelScale.Text = "Масштаб";
            labelScale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownIterations
            // 
            numericUpDownIterations.Dock = DockStyle.Top;
            numericUpDownIterations.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownIterations.Location = new Point(0, 252);
            numericUpDownIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownIterations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownIterations.Name = "numericUpDownIterations";
            numericUpDownIterations.RightToLeft = RightToLeft.No;
            numericUpDownIterations.Size = new Size(201, 51);
            numericUpDownIterations.TabIndex = 9;
            numericUpDownIterations.TextAlign = HorizontalAlignment.Center;
            numericUpDownIterations.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelIterations
            // 
            labelIterations.BackColor = SystemColors.Control;
            labelIterations.Dock = DockStyle.Top;
            labelIterations.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelIterations.Location = new Point(0, 202);
            labelIterations.Name = "labelIterations";
            labelIterations.Size = new Size(201, 50);
            labelIterations.TabIndex = 8;
            labelIterations.Text = "Итерации";
            labelIterations.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownIm
            // 
            numericUpDownIm.DecimalPlaces = 5;
            numericUpDownIm.Dock = DockStyle.Top;
            numericUpDownIm.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownIm.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownIm.Location = new Point(0, 151);
            numericUpDownIm.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownIm.Minimum = new decimal(new int[] { 2, 0, 0, int.MinValue });
            numericUpDownIm.Name = "numericUpDownIm";
            numericUpDownIm.RightToLeft = RightToLeft.No;
            numericUpDownIm.Size = new Size(201, 51);
            numericUpDownIm.TabIndex = 7;
            numericUpDownIm.TextAlign = HorizontalAlignment.Center;
            // 
            // labelIm
            // 
            labelIm.BackColor = SystemColors.Control;
            labelIm.Dock = DockStyle.Top;
            labelIm.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIm.Location = new Point(0, 101);
            labelIm.Name = "labelIm";
            labelIm.Size = new Size(201, 50);
            labelIm.TabIndex = 6;
            labelIm.Text = "Im";
            labelIm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownRe
            // 
            numericUpDownRe.DecimalPlaces = 5;
            numericUpDownRe.Dock = DockStyle.Top;
            numericUpDownRe.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownRe.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownRe.Location = new Point(0, 50);
            numericUpDownRe.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownRe.Minimum = new decimal(new int[] { 2, 0, 0, int.MinValue });
            numericUpDownRe.Name = "numericUpDownRe";
            numericUpDownRe.Size = new Size(201, 51);
            numericUpDownRe.TabIndex = 5;
            numericUpDownRe.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRe
            // 
            labelRe.BackColor = SystemColors.Control;
            labelRe.Dock = DockStyle.Top;
            labelRe.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelRe.Location = new Point(0, 0);
            labelRe.Name = "labelRe";
            labelRe.Size = new Size(201, 50);
            labelRe.TabIndex = 1;
            labelRe.Text = "Re";
            labelRe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 591);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Julia Set";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxField).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIterations).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBoxField;
        private Label labelRe;
        private Label labelIm;
        public NumericUpDown numericUpDownRe;
        public NumericUpDown numericUpDownIm;
        private Label labelIterations;
        public NumericUpDown numericUpDownIterations;
        public NumericUpDown numericUpDownScale;
        private Label labelScale;
        private Button buttonStart;
        private Button buttonSave;
        private Button buttonExit;
    }
}