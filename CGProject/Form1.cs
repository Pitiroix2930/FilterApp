using CGProject.Helpers;
using CGProject.Filters;
using CGProject.Models;
using System.Xml;
using Newtonsoft.Json;

namespace CGProject
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap filteredImage;
        private bool isGrayscaleMode = false;
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            //LoadBuiltInFilters();
            SaveBuiltInFilters();
            LoadSavedFilterList();

            // Attach event AFTER loading to prevent premature activation
            LoadingFilters.SelectedIndexChanged += (s, ev) => SetupGrid();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    filteredImage = new Bitmap(originalImage);
                    pictureBox1.Image = originalImage;
                    pictureBox2.Image = filteredImage;
                    isGrayscaleMode = false;
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filteredImage.Save(saveFileDialog.FileName);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                filteredImage = new Bitmap(originalImage);
                pictureBox2.Image = filteredImage;
                isGrayscaleMode = false;
            }
        }

        private void InversionButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new InversionFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void BrightnessButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new BrightnessFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void ContrastButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new ContrastFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void GammaButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new GammaCorrectionFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void BlurButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new BoxBlurFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void GaussianBlurButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new GaussianBlurFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void SharpenButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new SharpenFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void EdgeDetectionButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new EdgeDetectionFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }
        private void EmbossButton_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var embossFilter = new EmbossFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = embossFilter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }
        private void SetupGrid()
        {
            if (LoadingFilters.SelectedItem != null && LoadingFilters.SelectedIndex >= 0)
            {
                string selectedFilter = LoadingFilters.SelectedItem.ToString();
                LoadCustomFilter(selectedFilter);
            }
        }

        private void LoadCustomFilter(string filterName)
        {
            string path = $"Filters/{filterName}.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                var filter = JsonConvert.DeserializeObject<SavedFilter>(json);

                int rows = filter.Kernel.GetLength(0);
                int cols = filter.Kernel.GetLength(1);

                KernelMaxHeight.Value = rows;
                KernelMaxWidth.Value = cols;
                KernelTable.RowCount = rows;
                KernelTable.ColumnCount = cols;
                AnchorX.Value = filter.AnchorX;
                AnchorY.Value = filter.AnchorY;
                PopulateKernelGrid(filter.Kernel, rows, cols);
                DivisorBox.Text = filter.Divisor.ToString();
                OffsetBox.Text = filter.Offset.ToString();
            }
        }
        private void PopulateKernelGrid(double[,] kernel, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    KernelTable.Rows[row].Cells[col].Value = kernel[row, col].ToString("F0");

                    if (row == (int)AnchorY.Value - 1 && col == (int)AnchorX.Value - 1)
                    {
                        KernelTable.Rows[row].Cells[col].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        KernelTable.Rows[row].Cells[col].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void SaveCustom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)DivisorBox.Text))
            {
                errorNoDivisor.SetError(DivisorBox, "Provide a value for the divisor");
            }
            else if (string.IsNullOrEmpty((string)OffsetBox.Text))
            {
                errorNoOffset.SetError(OffsetBox, "Provide a value for the offset");
            }
            else
            {
                errorNoDivisor.Clear();
                errorNoOffset.Clear();
                double[,] kernel = new double[KernelTable.ColumnCount, KernelTable.RowCount];
                for (int x = 0; x < KernelTable.ColumnCount; x++)
                {
                    for (int y = 0; y < KernelTable.RowCount; y++)
                    {
                        if (double.TryParse(KernelTable[x, y]?.Value?.ToString(), out double value))
                        {
                            kernel[x, y] = value;
                        }
                    }
                }

                var filter = new SavedFilter
                {
                    Name = $"Custom Filter {DateTime.Now:HHmmss}",
                    Kernel = kernel,
                    Divisor = double.Parse(DivisorBox.Text),
                    Offset = double.Parse(OffsetBox.Text),
                    AnchorX = (int)AnchorX.Value,
                    AnchorY = (int)AnchorY.Value
                };

                string json = JsonConvert.SerializeObject(filter, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText($"filters/{filter.Name}.json", json);

                MessageBox.Show("Filter saved!");
                LoadSavedFilterList();
            }
        }

        private void LoadSavedFilterList()
        {
            LoadingFilters.Items.Clear();

            if (!Directory.Exists("filters"))
                Directory.CreateDirectory("filters");

            var files = Directory.GetFiles("filters", "*.json");
            foreach (var file in files)
            {
                LoadingFilters.Items.Add(Path.GetFileNameWithoutExtension(file));
            }

            if (LoadingFilters.Items.Count > 0)
                LoadingFilters.SelectedIndex = 0;
        }

        private void LoadCustom_Click(object sender, EventArgs e)
        {
            string selectedFilter = LoadingFilters.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedFilter)) return;

            string filePath = $"filters/{selectedFilter}.json";
            if (!File.Exists(filePath)) return;

            var filter = JsonConvert.DeserializeObject<SavedFilter>(File.ReadAllText(filePath));
            if (filter == null) return;

            KernelMaxHeight.Value = filter.Kernel.GetLength(1);
            KernelMaxWidth.Value = filter.Kernel.GetLength(0);
            AnchorX.Value = filter.AnchorX;
            AnchorY.Value = filter.AnchorY;
            SetupGrid();
            DivisorBox.Text = filter.Divisor.ToString();
            OffsetBox.Text = filter.Offset.ToString();
        }

        private void ApplyCustom_Click(object sender, EventArgs e)
        {
            if (filteredImage is null)
            {
                errorNoImage.SetError(ApplyCustom, "Load an image for the filter to be applied to");
            }
            else if (string.IsNullOrEmpty((string)DivisorBox.Text))
            {
                errorNoDivisor.SetError(DivisorBox, "Provide a value for the divisor");
            }
            else if (string.IsNullOrEmpty((string)OffsetBox.Text))
            {
                errorNoOffset.SetError(OffsetBox, "Provide a value for the offset");
            }
            else
            {
                errorNoImage.Clear();
                errorNoDivisor.Clear();
                errorNoOffset.Clear();
                int width = KernelTable.ColumnCount;
                int height = KernelTable.RowCount;
                double[,] Kernel = new double[width, height];

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (double.TryParse(KernelTable[x, y]?.Value?.ToString(), out double value))
                        {
                            Kernel[x, y] = value;
                        }
                    }
                }
                double divisor = double.Parse(DivisorBox.Text);
                double offset = double.Parse(OffsetBox.Text);
                int anchorX = (int)AnchorX.Value;
                int anchorY = (int)AnchorY.Value;

                ConvolutionFilter filter = new ConvolutionFilter(Kernel, divisor, offset, anchorX, anchorY);
                var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
                pixels = filter.ApplyFilter(pixels);
                filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
                pictureBox2.Image = filteredImage;
            }
        }

        private void AutoDivisor_CheckedChanged(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (DataGridViewRow row in KernelTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && double.TryParse(cell.Value.ToString(), out double value))
                    {
                        sum += value;
                    }
                }
            }

            DivisorBox.Text = sum.ToString();
        }

        private void KernelMaxWidth_ValueChanged(object sender, EventArgs e)
        {
            AnchorX.Maximum = KernelMaxWidth.Value;
            UpdateKernelTable((int)KernelMaxHeight.Value, KernelTable.ColumnCount);
        }

        private void KernelMaxHeight_ValueChanged(object sender, EventArgs e)
        {
            AnchorY.Maximum = KernelMaxHeight.Value;
            UpdateKernelTable(KernelTable.RowCount, (int)KernelMaxWidth.Value);
        }

        private void UpdateKernelTable(int rows, int columns)
        {
            KernelTable.Rows.Clear();
            KernelTable.Columns.Clear();

            for (int i = 0; i < columns; i++)
            {
                KernelTable.Columns.Add(new DataGridViewTextBoxColumn());
            }

            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(KernelTable);
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = 0;
                }
                KernelTable.Rows.Add(row);
            }
        }

        private void SaveFilterToFile(string name, double[,] kernel, double divisor, double offset, int anchorX, int anchorY)
        {
            var filter = new SavedFilter
            {
                Name = name,
                Kernel = kernel,
                Divisor = divisor,
                Offset = offset,
                AnchorX = anchorX,
                AnchorY = anchorY
            };

            string path = $"filters/{name}.json";
            string json = JsonConvert.SerializeObject(filter);
            File.WriteAllText(path, json);
        }

        private void SaveBuiltInFilters()
        {
            if (!Directory.Exists("filters"))
                Directory.CreateDirectory("filters");

            SaveFilterToFile("Sharpen",
                new double[,] {
            {  0, -1,  0 },
            { -1,  5, -1 },
            {  0, -1,  0 }
                }, divisor: 1, offset: 0, anchorX: 2, anchorY: 2);

            SaveFilterToFile("GaussianBlur",
                new double[,] {
            { 1, 2, 1 },
            { 2, 4, 2 },
            { 1, 2, 1 }
                }, divisor: 16, offset: 0, anchorX: 2, anchorY: 2);

            SaveFilterToFile("EdgeDetection",
                new double[,] {
            { -1, -1, -1 },
            { -1,  8, -1 },
            { -1, -1, -1 }
                }, divisor: 1, offset: 0, anchorX: 2, anchorY: 2);

            SaveFilterToFile("Emboss",
                new double[,] {
            { -2, -1,  0 },
            { -1,  1,  1 },
            {  0,  1,  2 }
                }, divisor: 1, offset: 128, anchorX: 2, anchorY: 2);

            SaveFilterToFile("BoxBlur",
                new double[,] {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
                }, divisor: 9, offset: 0, anchorX: 2, anchorY: 2);
            SaveFilterToFile("Dither_FloydSteinberg",
                new double[,] {
            { 0, 0, 0 },
            { 0, 0, 7 },
            { 3, 5, 1 }
                }, divisor: 16, offset: 0, anchorX: 2, anchorY: 2);
            SaveFilterToFile("Dither_Burkes",
                new double[,] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 8, 4 },
            { 2, 4, 8, 4, 2 }
                }, divisor: 32, offset: 0, anchorX: 3, anchorY: 2);
            SaveFilterToFile("Dither_Stucki",
                new double[,] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 8, 4 },
            { 2, 4, 8, 4, 2 },
            { 1, 2, 4, 2, 1 }
                }, divisor: 42, offset: 0, anchorX: 3, anchorY: 3);
            SaveFilterToFile("Dither_Sierra",
                new double[,] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 5, 3 },
            { 2, 4, 5, 4, 2 },
            { 0, 2, 3, 2, 0 }
                }, divisor: 32, offset: 0, anchorX: 3, anchorY: 3);
            SaveFilterToFile("Dither_Atkinson",
                new double[,] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1 },
            { 0, 1, 1, 1, 0 },
            { 0, 0, 1, 0, 0 }
                }, divisor: 8, offset: 0, anchorX: 3, anchorY: 3);
        }

        private void Erosion_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new ErosionFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void Dilution_Click(object sender, EventArgs e)
        {
            if (filteredImage == null) return;

            var filter = new DilutionFilter();
            var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
            pixels = filter.ApplyFilter(pixels);
            filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
            pictureBox2.Image = filteredImage;
        }

        private void Popularity_Click(object sender, EventArgs e)
        {
            if (filteredImage is null)
            {
                errorNoImage.SetError(Popularity, "Load an image for the filter to be applied to");
            }
            else if (string.IsNullOrEmpty((string)valuePop.Text))
            {
                errorNoK.SetError(valuePop, "Provide a value of k");
            }
            else
            {
                errorNoImage.Clear();
                errorNoK.Clear();
                var filter = new PopularityQuantization();
                var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
                pixels = filter.ApplyFilter(pixels, int.Parse(valuePop.Text));
                filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
                pictureBox2.Image = filteredImage;
            }
        }

        private void Greyscale_Click(object sender, EventArgs e)
        {
            if (filteredImage != null)
            {
                var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
                for (int x = 0; x < pixels.GetLength(0); x++)
                {
                    for (int y = 0; y < pixels.GetLength(1); y++)
                    {
                        byte gray = (byte)(0.2126 * pixels[x, y].R + 0.7152 * pixels[x, y].G + 0.0722 * pixels[x, y].B);
                        //byte gray = (byte)(0.299 * pixels[x, y].R + 0.587 * pixels[x, y].G + 0.114 * pixels[x, y].B);
                        pixels[x, y] = new PixelColor(gray, gray, gray);
                    }
                }
                filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
                pictureBox2.Image = filteredImage;
                isGrayscaleMode = true;
            }
        }

        private void Dither_Click(object sender, EventArgs e)
        {
            if (filteredImage is null)
            {
                errorNoImage.SetError(ApplyCustom, "Load an image for the filter to be applied to");
            }
            else if (string.IsNullOrEmpty((string)valuePop.Text))
            {
                errorNoK.SetError(valuePop, "Provide a value of k");
            }
            else if (string.IsNullOrEmpty((string)DivisorBox.Text))
            {
                errorNoDivisor.SetError(DivisorBox, "Provide a value for the divisor");
            }
            else if (string.IsNullOrEmpty((string)OffsetBox.Text))
            {
                errorNoOffset.SetError(OffsetBox, "Provide a value for the offset");
            }
            else
            {
                errorNoImage.Clear();
                errorNoK.Clear();
                errorNoDivisor.Clear();
                errorNoOffset.Clear();
                int width = KernelTable.ColumnCount;
                int height = KernelTable.RowCount;
                double[,] Kernel = new double[width, height];

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (double.TryParse(KernelTable[x, y]?.Value?.ToString(), out double value))
                        {
                            Kernel[x, y] = value;
                        }
                    }
                }
                double divisor = double.Parse(DivisorBox.Text);
                double offset = double.Parse(OffsetBox.Text);
                int anchorX = (int)AnchorX.Value;
                int anchorY = (int)AnchorY.Value;
                int k = int.Parse(valuePop.Text);

                var filter = new ErrorDiffusion(Kernel, divisor, anchorX, anchorY, k, isGrayscaleMode);
                var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
                pixels = filter.ApplyFilter(pixels);
                filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
                pictureBox2.Image = filteredImage;

            }
        }

        private void YCBCR_Click(object sender, EventArgs e)
        {
            if (filteredImage is null)
            {
                errorNoImage.SetError(ApplyCustom, "Load an image for the filter to be applied to");
            }
            else if (string.IsNullOrEmpty((string)valuePop.Text))
            {
                errorNoK.SetError(valuePop, "Provide a value of k");
            }
            else if (string.IsNullOrEmpty((string)DivisorBox.Text))
            {
                errorNoDivisor.SetError(DivisorBox, "Provide a value for the divisor");
            }
            else if (string.IsNullOrEmpty((string)OffsetBox.Text))
            {
                errorNoOffset.SetError(OffsetBox, "Provide a value for the offset");
            }
            else
            {
                errorNoImage.Clear();
                errorNoK.Clear();
                errorNoDivisor.Clear();
                errorNoOffset.Clear();
                int width = KernelTable.ColumnCount;
                int height = KernelTable.RowCount;
                double[,] Kernel = new double[width, height];

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (double.TryParse(KernelTable[x, y]?.Value?.ToString(), out double value))
                        {
                            Kernel[x, y] = value;
                        }
                    }
                }
                double divisor = double.Parse(DivisorBox.Text);
                double offset = double.Parse(OffsetBox.Text);
                int anchorX = (int)AnchorX.Value;
                int anchorY = (int)AnchorY.Value;
                //int k = int.Parse(valuePop.Text);

                var filter = new YCBCRFilter(Kernel, divisor, anchorX, anchorY, 3);
                var pixels = BitmapConverter.BitmapToPixelArray(filteredImage);
                pixels = filter.ApplyFilter(pixels);
                filteredImage = BitmapConverter.PixelArrayToBitmap(pixels);
                pictureBox2.Image = filteredImage;

            }
        }
    }
}
