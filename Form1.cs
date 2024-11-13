namespace JuliaSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDownRe.Value;
            double b = (double)numericUpDownIm.Value;
            var c = new ComplexNumber(a, b);

            DrawFractal(c);
        }

        public void DrawFractal(ComplexNumber c)
        {
            int frameWight = pictureBoxField.Width;
            int frameHeight = pictureBoxField.Height;
            Bitmap frame = new Bitmap(frameWight, frameHeight);

            double scale = (double)numericUpDownScale.Value;

            for (int x = 0; x < frameWight; x++)
            {
                for (int y = 0; y < frameHeight; y++)
                {
                    double a = (x - (frameWight / 2d)) / (frameWight / scale / 1.777d);
                    double b = (y - (frameHeight / 2d)) / (frameHeight / scale);
                    ComplexNumber z = new ComplexNumber(a, -b);

                    int iteration = 0;
                    int maxIteration = (int)numericUpDownIterations.Value;

                    do
                    {
                        z *= z;
                        z += c;
                        iteration++;
                    } while (z.SquareOfAbs() < 4d && iteration < maxIteration);

                    int shade = 255 - (int)(255d / maxIteration * iteration);
                    Color pixelColor = Color.FromArgb(shade, shade, shade);
                    frame.SetPixel(x, y, pixelColor);
                }
            }

            pictureBoxField.Image = frame;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savingDialog = new SaveFileDialog();

            savingDialog.OverwritePrompt = true;
            savingDialog.CheckPathExists = true;

            savingDialog.Title = "Сохранение";
            savingDialog.Filter = "PNG-Изображение*.png|JPG-Изображение*.jpg|GIF-Изображение*.gif|Все файлы|*.*";

            if (savingDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxField.Image.Save(savingDialog.FileName);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
