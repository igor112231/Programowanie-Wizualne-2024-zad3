namespace Zad_3
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class Form1 : Form
    {
        private bool isSelecting;
        private Point startPoint;
        private Rectangle cropRect;
        bool isloaded;
        bool cropup;
        public Form1()
        {
            InitializeComponent();
            pictureBox.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            pictureBox.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (isloaded && cropup)
            {
                // Start the selection process
                isSelecting = true;
                startPoint = e.Location;
                cropRect = new Rectangle(e.Location, new Size(0, 0));
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Update the crop rectangle while dragging
            if (isSelecting && isloaded && cropup)
            {
                Point endPoint = e.Location;
                cropRect = new Rectangle(
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(startPoint.X - endPoint.X),
                    Math.Abs(startPoint.Y - endPoint.Y));

                // Redraw the PictureBox to show the crop rectangle
                label1.Text = cropRect.ToString();
                pictureBox.Invalidate();
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isloaded && cropup)
            {
                // End the selection process
                isSelecting = false;

                // Perform the cropping if the rectangle is valid
                if (cropRect.Width > 0 && cropRect.Height > 0)
                {
                    CropImage();
                }
            }
        }
        private void CropImage()
        {
            Bitmap originalImage = new Bitmap(pictureBox.Image);

            //cropRect = new Rectangle(1, 1, 1000, 1000);

            Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);

            // Update the PictureBox with the cropped image
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = croppedImage;

            cropup = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadImage()
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                double height = image.Height;
                double width = image.Width;
                double ratio = height / width;
                double new_width = ratio * 285;
                int intValue = (int)Math.Round(new_width);
                //label1.Text = intValue.ToString();
                Bitmap scaledBitmap = new Bitmap(image, new Size(285, intValue));
                if (width > height)
                {
                    scaledBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                pictureBox.Image = scaledBitmap;
                isloaded = true;
            }

        }

        private void Crop_Click(object sender, EventArgs e)
        {
            cropup = true;
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            if (isloaded)
            {
                Enter.Show();
                H_box.Show();
                W_box.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (isloaded)
            {
                W_box.Show();
                Enter.Show();
            }
        }

        private void Flip_Click(object sender, EventArgs e)
        {
            if (isloaded)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox.Refresh();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        private Image rotate(int angle)
        {
            int w = pictureBox.Image.Width;
            int h = pictureBox.Image.Height;
            double rads = Math.PI * angle / 180.0;
            double cos = Math.Abs(Math.Cos(rads));
            double sin = Math.Abs(Math.Sin(rads));
            int newWidth = (int)(w * cos + h * sin);
            int newHeight = (int)(w * sin + h * cos);

            // Create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(newWidth, newHeight);

            // Make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                // Set the rotation point to the center of the image
                g.TranslateTransform((float)newWidth / 2, (float)newHeight / 2);

                // Rotate the image
                g.RotateTransform(angle);

                // Move the image back to the original position
                g.TranslateTransform(-(float)w / 2, -(float)h / 2);

                // Draw the passed in image onto the graphics object
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(pictureBox.Image, new Point(0, 0));
            }


            return rotatedBmp;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            int parsedValue1, parsedValue2;
            if (int.TryParse(H_box.Text, out parsedValue1) && int.TryParse(W_box.Text, out parsedValue2))
            {
                int height = parsedValue1;
                int width = parsedValue2;
                Image originalImage = pictureBox.Image;
                Bitmap scaledBitmap = new Bitmap(originalImage, new Size(height, width));
                pictureBox.Image = scaledBitmap;

                H_box.Text = "";
                W_box.Text = "";
                Enter.Hide();
                H_box.Hide();
                W_box.Hide();
            }
            if (!int.TryParse(H_box.Text, out parsedValue1) && int.TryParse(W_box.Text, out parsedValue2))
            {
                int angle = parsedValue2;
                pictureBox.Image = rotate(angle);
                //pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                //pictureBox.Refresh();
                Enter.Hide();
                W_box.Hide();


            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (isloaded)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp|GIF Image|*.gif",
                    Title = "Save an Image File"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}