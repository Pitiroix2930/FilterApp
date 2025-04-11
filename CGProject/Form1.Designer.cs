namespace CGProject
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            YCBCR = new Button();
            Quantizations = new GroupBox();
            Dither = new Button();
            Popularity = new Button();
            valuePop = new TextBox();
            labelKPop = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AnchorY = new NumericUpDown();
            AnchorX = new NumericUpDown();
            ApplyCustom = new Button();
            LoadCustom = new Button();
            SaveCustom = new Button();
            LoadingFilters = new ComboBox();
            KernelMaxHeight = new NumericUpDown();
            KernelMaxWidth = new NumericUpDown();
            OffsetBox = new TextBox();
            DivisorBox = new TextBox();
            AutoDivisor = new CheckBox();
            KernelTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Convolutions = new GroupBox();
            Greyscale = new Button();
            Dilution = new Button();
            Erosion = new Button();
            EmbossButton = new Button();
            EdgeDetectionButton = new Button();
            SharpenButton = new Button();
            GaussianBlurButton = new Button();
            BlurButton = new Button();
            Functions = new GroupBox();
            GammaButton = new Button();
            ContrastButton = new Button();
            BrightnessButton = new Button();
            InversionButton = new Button();
            ResetButton = new Button();
            errorNoDivisor = new ErrorProvider(components);
            errorNoOffset = new ErrorProvider(components);
            errorNoImage = new ErrorProvider(components);
            errorNoK = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Quantizations.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnchorY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnchorX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KernelMaxHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KernelMaxWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KernelTable).BeginInit();
            Convolutions.SuspendLayout();
            Functions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorNoDivisor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoK).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1539, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(125, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(125, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.PowderBlue;
            splitContainer1.Panel2.Controls.Add(YCBCR);
            splitContainer1.Panel2.Controls.Add(Quantizations);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(Convolutions);
            splitContainer1.Panel2.Controls.Add(Functions);
            splitContainer1.Panel2.Controls.Add(ResetButton);
            splitContainer1.Size = new Size(1539, 800);
            splitContainer1.SplitterDistance = 1204;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(pictureBox2);
            splitContainer2.Size = new Size(1204, 800);
            splitContainer2.SplitterDistance = 600;
            splitContainer2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 800);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(600, 800);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // YCBCR
            // 
            YCBCR.Location = new Point(121, 172);
            YCBCR.Name = "YCBCR";
            YCBCR.Size = new Size(94, 29);
            YCBCR.TabIndex = 5;
            YCBCR.Text = "RGB";
            YCBCR.UseVisualStyleBackColor = true;
            YCBCR.Click += YCBCR_Click;
            // 
            // Quantizations
            // 
            Quantizations.Controls.Add(Dither);
            Quantizations.Controls.Add(Popularity);
            Quantizations.Controls.Add(valuePop);
            Quantizations.Controls.Add(labelKPop);
            Quantizations.Location = new Point(218, 16);
            Quantizations.Name = "Quantizations";
            Quantizations.Size = new Size(100, 150);
            Quantizations.TabIndex = 4;
            Quantizations.TabStop = false;
            Quantizations.Text = "Popularity Algorithm";
            // 
            // Dither
            // 
            Dither.Location = new Point(5, 115);
            Dither.Name = "Dither";
            Dither.Size = new Size(87, 30);
            Dither.TabIndex = 3;
            Dither.Text = "Dither";
            Dither.UseVisualStyleBackColor = true;
            Dither.Click += Dither_Click;
            // 
            // Popularity
            // 
            Popularity.Location = new Point(5, 84);
            Popularity.Name = "Popularity";
            Popularity.Size = new Size(87, 30);
            Popularity.TabIndex = 2;
            Popularity.Text = "Quantize";
            Popularity.UseVisualStyleBackColor = true;
            Popularity.Click += Popularity_Click;
            // 
            // valuePop
            // 
            valuePop.Location = new Point(38, 48);
            valuePop.Name = "valuePop";
            valuePop.Size = new Size(50, 27);
            valuePop.TabIndex = 1;
            // 
            // labelKPop
            // 
            labelKPop.AutoSize = true;
            labelKPop.Location = new Point(6, 51);
            labelKPop.Name = "labelKPop";
            labelKPop.Size = new Size(32, 20);
            labelKPop.TabIndex = 0;
            labelKPop.Text = "K =";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AnchorY);
            panel1.Controls.Add(AnchorX);
            panel1.Controls.Add(ApplyCustom);
            panel1.Controls.Add(LoadCustom);
            panel1.Controls.Add(SaveCustom);
            panel1.Controls.Add(LoadingFilters);
            panel1.Controls.Add(KernelMaxHeight);
            panel1.Controls.Add(KernelMaxWidth);
            panel1.Controls.Add(OffsetBox);
            panel1.Controls.Add(DivisorBox);
            panel1.Controls.Add(AutoDivisor);
            panel1.Controls.Add(KernelTable);
            panel1.Location = new Point(12, 302);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 486);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 350);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 19;
            label5.Text = "Offset:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 317);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 18;
            label4.Text = "KernelY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 284);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 17;
            label3.Text = "KernelX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 350);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 16;
            label2.Text = "AnchorX";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 383);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 15;
            label1.Text = "AnchorY";
            // 
            // AnchorY
            // 
            AnchorY.Location = new Point(15, 381);
            AnchorY.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            AnchorY.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AnchorY.Name = "AnchorY";
            AnchorY.Size = new Size(64, 27);
            AnchorY.TabIndex = 13;
            AnchorY.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // AnchorX
            // 
            AnchorX.Location = new Point(15, 348);
            AnchorX.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            AnchorX.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AnchorX.Name = "AnchorX";
            AnchorX.Size = new Size(64, 27);
            AnchorX.TabIndex = 12;
            AnchorX.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // ApplyCustom
            // 
            ApplyCustom.Location = new Point(187, 448);
            ApplyCustom.Name = "ApplyCustom";
            ApplyCustom.Size = new Size(80, 30);
            ApplyCustom.TabIndex = 11;
            ApplyCustom.Text = "Apply";
            ApplyCustom.UseVisualStyleBackColor = true;
            ApplyCustom.Click += ApplyCustom_Click;
            // 
            // LoadCustom
            // 
            LoadCustom.Location = new Point(101, 448);
            LoadCustom.Name = "LoadCustom";
            LoadCustom.Size = new Size(80, 30);
            LoadCustom.TabIndex = 10;
            LoadCustom.Text = "Load";
            LoadCustom.UseVisualStyleBackColor = true;
            LoadCustom.Click += LoadCustom_Click;
            // 
            // SaveCustom
            // 
            SaveCustom.Location = new Point(15, 448);
            SaveCustom.Name = "SaveCustom";
            SaveCustom.Size = new Size(80, 30);
            SaveCustom.TabIndex = 9;
            SaveCustom.Text = "Save";
            SaveCustom.UseVisualStyleBackColor = true;
            SaveCustom.Click += SaveCustom_Click;
            // 
            // LoadingFilters
            // 
            LoadingFilters.FormattingEnabled = true;
            LoadingFilters.Location = new Point(15, 414);
            LoadingFilters.Name = "LoadingFilters";
            LoadingFilters.Size = new Size(274, 28);
            LoadingFilters.TabIndex = 8;
            // 
            // KernelMaxHeight
            // 
            KernelMaxHeight.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            KernelMaxHeight.Location = new Point(15, 315);
            KernelMaxHeight.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            KernelMaxHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            KernelMaxHeight.Name = "KernelMaxHeight";
            KernelMaxHeight.Size = new Size(64, 27);
            KernelMaxHeight.TabIndex = 7;
            KernelMaxHeight.Value = new decimal(new int[] { 3, 0, 0, 0 });
            KernelMaxHeight.ValueChanged += KernelMaxHeight_ValueChanged;
            // 
            // KernelMaxWidth
            // 
            KernelMaxWidth.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            KernelMaxWidth.Location = new Point(15, 282);
            KernelMaxWidth.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            KernelMaxWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            KernelMaxWidth.Name = "KernelMaxWidth";
            KernelMaxWidth.Size = new Size(64, 27);
            KernelMaxWidth.TabIndex = 6;
            KernelMaxWidth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            KernelMaxWidth.ValueChanged += KernelMaxWidth_ValueChanged;
            // 
            // OffsetBox
            // 
            OffsetBox.Location = new Point(175, 381);
            OffsetBox.Name = "OffsetBox";
            OffsetBox.Size = new Size(79, 27);
            OffsetBox.TabIndex = 5;
            // 
            // DivisorBox
            // 
            DivisorBox.Location = new Point(175, 282);
            DivisorBox.Name = "DivisorBox";
            DivisorBox.Size = new Size(79, 27);
            DivisorBox.TabIndex = 4;
            // 
            // AutoDivisor
            // 
            AutoDivisor.AutoSize = true;
            AutoDivisor.Location = new Point(175, 316);
            AutoDivisor.Name = "AutoDivisor";
            AutoDivisor.Size = new Size(115, 24);
            AutoDivisor.TabIndex = 3;
            AutoDivisor.Text = "Auto-Divisor";
            AutoDivisor.UseVisualStyleBackColor = true;
            AutoDivisor.CheckedChanged += AutoDivisor_CheckedChanged;
            // 
            // KernelTable
            // 
            KernelTable.AllowUserToAddRows = false;
            KernelTable.AllowUserToDeleteRows = false;
            KernelTable.AllowUserToResizeColumns = false;
            KernelTable.AllowUserToResizeRows = false;
            KernelTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KernelTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KernelTable.ColumnHeadersVisible = false;
            KernelTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            KernelTable.Location = new Point(15, 12);
            KernelTable.MultiSelect = false;
            KernelTable.Name = "KernelTable";
            KernelTable.RowHeadersVisible = false;
            KernelTable.RowHeadersWidth = 20;
            KernelTable.Size = new Size(275, 264);
            KernelTable.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Convolutions
            // 
            Convolutions.Controls.Add(Greyscale);
            Convolutions.Controls.Add(Dilution);
            Convolutions.Controls.Add(Erosion);
            Convolutions.Controls.Add(EmbossButton);
            Convolutions.Controls.Add(EdgeDetectionButton);
            Convolutions.Controls.Add(SharpenButton);
            Convolutions.Controls.Add(GaussianBlurButton);
            Convolutions.Controls.Add(BlurButton);
            Convolutions.Location = new Point(12, 16);
            Convolutions.Name = "Convolutions";
            Convolutions.Size = new Size(104, 280);
            Convolutions.TabIndex = 2;
            Convolutions.TabStop = false;
            Convolutions.Text = "Convolution";
            // 
            // Greyscale
            // 
            Greyscale.BackColor = Color.LightGray;
            Greyscale.Location = new Point(13, 239);
            Greyscale.Name = "Greyscale";
            Greyscale.Size = new Size(81, 28);
            Greyscale.TabIndex = 22;
            Greyscale.Text = "Greyscale";
            Greyscale.UseVisualStyleBackColor = false;
            Greyscale.Click += Greyscale_Click;
            // 
            // Dilution
            // 
            Dilution.Location = new Point(13, 177);
            Dilution.Name = "Dilution";
            Dilution.Size = new Size(81, 28);
            Dilution.TabIndex = 21;
            Dilution.Text = "Dilution";
            Dilution.UseVisualStyleBackColor = true;
            Dilution.Click += Dilution_Click;
            // 
            // Erosion
            // 
            Erosion.Location = new Point(13, 208);
            Erosion.Name = "Erosion";
            Erosion.Size = new Size(81, 28);
            Erosion.TabIndex = 20;
            Erosion.Text = "Erosion";
            Erosion.UseVisualStyleBackColor = true;
            Erosion.Click += Erosion_Click;
            // 
            // EmbossButton
            // 
            EmbossButton.Location = new Point(13, 146);
            EmbossButton.Name = "EmbossButton";
            EmbossButton.Size = new Size(81, 30);
            EmbossButton.TabIndex = 4;
            EmbossButton.Text = "Emboss";
            EmbossButton.UseVisualStyleBackColor = true;
            EmbossButton.Click += EmbossButton_Click;
            // 
            // EdgeDetectionButton
            // 
            EdgeDetectionButton.Location = new Point(13, 115);
            EdgeDetectionButton.Name = "EdgeDetectionButton";
            EdgeDetectionButton.Size = new Size(81, 30);
            EdgeDetectionButton.TabIndex = 3;
            EdgeDetectionButton.Text = "Edge Det";
            EdgeDetectionButton.UseVisualStyleBackColor = true;
            EdgeDetectionButton.Click += EdgeDetectionButton_Click;
            // 
            // SharpenButton
            // 
            SharpenButton.Location = new Point(13, 84);
            SharpenButton.Name = "SharpenButton";
            SharpenButton.Size = new Size(81, 30);
            SharpenButton.TabIndex = 2;
            SharpenButton.Text = "Sharpen";
            SharpenButton.UseVisualStyleBackColor = true;
            SharpenButton.Click += SharpenButton_Click;
            // 
            // GaussianBlurButton
            // 
            GaussianBlurButton.Location = new Point(13, 53);
            GaussianBlurButton.Name = "GaussianBlurButton";
            GaussianBlurButton.Size = new Size(81, 30);
            GaussianBlurButton.TabIndex = 1;
            GaussianBlurButton.Text = "Gaussian";
            GaussianBlurButton.UseVisualStyleBackColor = true;
            GaussianBlurButton.Click += GaussianBlurButton_Click;
            // 
            // BlurButton
            // 
            BlurButton.Location = new Point(13, 22);
            BlurButton.Name = "BlurButton";
            BlurButton.Size = new Size(81, 30);
            BlurButton.TabIndex = 0;
            BlurButton.Text = "Blur";
            BlurButton.UseVisualStyleBackColor = true;
            BlurButton.Click += BlurButton_Click;
            // 
            // Functions
            // 
            Functions.Controls.Add(GammaButton);
            Functions.Controls.Add(ContrastButton);
            Functions.Controls.Add(BrightnessButton);
            Functions.Controls.Add(InversionButton);
            Functions.Location = new Point(117, 16);
            Functions.Name = "Functions";
            Functions.Size = new Size(100, 150);
            Functions.TabIndex = 1;
            Functions.TabStop = false;
            Functions.Text = "Function";
            // 
            // GammaButton
            // 
            GammaButton.Location = new Point(6, 115);
            GammaButton.Name = "GammaButton";
            GammaButton.Size = new Size(87, 30);
            GammaButton.TabIndex = 3;
            GammaButton.Text = "Gamma";
            GammaButton.UseVisualStyleBackColor = true;
            GammaButton.Click += GammaButton_Click;
            // 
            // ContrastButton
            // 
            ContrastButton.Location = new Point(6, 84);
            ContrastButton.Name = "ContrastButton";
            ContrastButton.Size = new Size(87, 30);
            ContrastButton.TabIndex = 2;
            ContrastButton.Text = "Contrast";
            ContrastButton.UseVisualStyleBackColor = true;
            ContrastButton.Click += ContrastButton_Click;
            // 
            // BrightnessButton
            // 
            BrightnessButton.Location = new Point(6, 53);
            BrightnessButton.Name = "BrightnessButton";
            BrightnessButton.Size = new Size(87, 30);
            BrightnessButton.TabIndex = 1;
            BrightnessButton.Text = "Brightness";
            BrightnessButton.UseVisualStyleBackColor = true;
            BrightnessButton.Click += BrightnessButton_Click;
            // 
            // InversionButton
            // 
            InversionButton.Location = new Point(6, 22);
            InversionButton.Name = "InversionButton";
            InversionButton.Size = new Size(87, 30);
            InversionButton.TabIndex = 0;
            InversionButton.Text = "Inversion";
            InversionButton.UseVisualStyleBackColor = true;
            InversionButton.Click += InversionButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.Salmon;
            ResetButton.Location = new Point(117, 255);
            ResetButton.Margin = new Padding(10);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(100, 30);
            ResetButton.TabIndex = 0;
            ResetButton.Text = "Reset Filters";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // errorNoDivisor
            // 
            errorNoDivisor.ContainerControl = this;
            // 
            // errorNoOffset
            // 
            errorNoOffset.ContainerControl = this;
            // 
            // errorNoImage
            // 
            errorNoImage.ContainerControl = this;
            // 
            // errorNoK
            // 
            errorNoK.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 828);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Filter Application";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Quantizations.ResumeLayout(false);
            Quantizations.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnchorY).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnchorX).EndInit();
            ((System.ComponentModel.ISupportInitialize)KernelMaxHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)KernelMaxWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)KernelTable).EndInit();
            Convolutions.ResumeLayout(false);
            Functions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorNoDivisor).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer2;
        private PictureBox pictureBox2;
        private Button ResetButton;
        private GroupBox Functions;
        private Button ContrastButton;
        private Button BrightnessButton;
        private Button InversionButton;
        private Button GammaButton;
        private GroupBox Convolutions;
        private Button SharpenButton;
        private Button GaussianBlurButton;
        private Button BlurButton;
        private Button EmbossButton;
        private Button EdgeDetectionButton;
        private Panel panel1;
        private CheckBox AutoDivisor;
        private DataGridView KernelTable;
        private Button LoadCustom;
        private Button SaveCustom;
        private ComboBox LoadingFilters;
        private NumericUpDown KernelMaxHeight;
        private NumericUpDown KernelMaxWidth;
        private TextBox OffsetBox;
        private TextBox DivisorBox;
        private Button ApplyCustom;
        private NumericUpDown AnchorY;
        private NumericUpDown AnchorX;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Dilution;
        private Button Erosion;
        private ErrorProvider errorNoDivisor;
        private ErrorProvider errorNoOffset;
        private ErrorProvider errorNoImage;
        private GroupBox Quantizations;
        private Label labelKPop;
        private Button Popularity;
        private TextBox valuePop;
        private Button Greyscale;
        private Button Dither;
        private ErrorProvider errorNoK;
        private Button YCBCR;
    }
}
