using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace furi_imageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap img1;
        private Bitmap img1Copy;

        private Bitmap img2;
        private Bitmap img2Copy;

        private Bitmap imgR;
        private Bitmap imgRCopy;

        private int filterDimension = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo Open
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab"; // Define o diretorio padrâo de selcao de imagem
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif" + // Define as possiveis extensoes das imagens
                "|JPG image (*.jpg)|*.jpg" +
                "|BMP image (*.bmp)|*.bmp" +
                "|PNG image (*.png)|*.png" +
                "|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se o arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOk = false;

                try
                {
                    img1 = new Bitmap(filePath);
                    img1Copy = img1;
                    bLoadImgOk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error opening image A",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bLoadImgOk = false;
                }

                if (bLoadImgOk)
                {
                    // Adiciona 
                    pbA.Image = img1;

                }
            }
        }//Fim do evento click btnA

        private void btnB_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo Open
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab"; //Define o diretorio padrâo de selcao de imagem
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif" + //Define as possiveis extensoes das imagens
                "|JPG image (*.jpg)|*.jpg" +
                "|BMP image (*.bmp)|*.bmp" +
                "|PNG image (*.png)|*.png" +
                "|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            //Se o arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOk = false;

                try
                {
                    img2 = new Bitmap(filePath);
                    img2Copy = img2;
                    bLoadImgOk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error opening image B",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bLoadImgOk = false;
                }

                if (bLoadImgOk)
                {
                    pbB.Image = img2;
                }
            }
        }//Fim do evento click btB

        private void pbA_Click(object sender, EventArgs e)
        {
            btnA_Click(sender, e);
        }

        private void pbB_Click(object sender, EventArgs e)
        {
            btnB_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = addImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error adding images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap addImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = color1.R + color2.R;
                        G = color1.G + color2.G;
                        B = color1.B + color2.B;

                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnColV_Click(object sender, EventArgs e)
        {
            Bitmap[] images = new Bitmap[2];
            images[0] = img1;
            images[1] = img2;
            try
            {
                imgR = collageVBitmap(images);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error add images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDivA_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntDivA_Click(object sender, EventArgs e)
        {
            string txt = txtDivA.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0 || num > 255)
            {
                MessageBox.Show("Please insert a value in range 1 - 255", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                img1 = divImage(img1, double.Parse(txt));
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap divImage(Bitmap image, double num)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;
                    int R, G, B;

                    R = (int)(color.R / num);
                    G = (int)(color.G / num);
                    B = (int)(color.B / num);

                    colorOut = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }
            return outputImage;
        }

        private Bitmap divImages(Bitmap img1, Bitmap img2, int num)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    int R2 = color2.R, G2 = color2.G, B2 = color2.B;
                    Color color;
                    int R, G, B;

                    R = (int)(color1.R + color2.R) / num;
                    G = (int)(color1.G + color2.G) / num;
                    B = (int)(color1.B + color2.B) / num;

                    if (R < 0) R = 0;
                    else if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    else if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    else if (B > 255) B = 255;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private Bitmap resizeImage(Bitmap imgToResize)
        {
            Size size;
            Size sizeA = new Size(img1.Width, img1.Height);
            Size sizeB = new Size(img2.Width, img2.Height);
            if (sizeA.Width > sizeB.Width && sizeA.Height > sizeB.Height) size = sizeA;
            else size = sizeB;

            return new Bitmap(imgToResize, size);
        }

        private Bitmap collageVBitmap(Bitmap[] images)
        {
            images[0] = resizeImage(images[0]);
            images[1] = resizeImage(images[1]);

            var outputHeight = images.Sum(x => x.Height);
            var outputWidth = images[0].Width;

            var outputImage = new Bitmap(outputWidth, outputHeight);

            using (var g = Graphics.FromImage(outputImage))
            {
                //set background color
                g.Clear(System.Drawing.Color.Black);

                //go through each image and draw it on the output image
                int offset = 0;
                foreach (System.Drawing.Bitmap image in images)
                {
                    g.DrawImage(image,
                        new System.Drawing.Rectangle(0, offset, image.Width, image.Height)
                    );
                    offset += image.Height;
                }
            }
            return new Bitmap(outputImage);
        }
        byte Average(byte a, byte b)
        {
            return (byte)((a + b) / 2);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = subImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error subtracting images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap subImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = color1.R - color2.R;
                        G = color1.G - color2.G;
                        B = color1.B - color2.B;

                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = avgImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error averaging images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap avgImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color Color1 = imgA.GetPixel(x, y);
                    Color Color2 = imgB.GetPixel(x, y);
                    Color color = Color.FromArgb(Average(Color1.R, Color2.R), Average(Color1.G, Color2.G), Average(Color1.B, Color2.B));

                    outputImage.SetPixel(x, y, color);
                }
            }

            return outputImage;
        }

        private void txtBld_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBld_Click(object sender, EventArgs e)
        {
            string txt = txtBld.Text;
            if (txt == "")
            {
                MessageBox.Show("Field Required\nPlease insert a value in range 0.00 - 1.00", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num < 0 || num > 1)
            {
                MessageBox.Show("Please insert a value in range 0.00 - 1.00", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = blendImages(img1, img2, double.Parse(txt));
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error blending images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void verifyImage(Bitmap image)
        {
            if (image == null)
            {
                MessageBox.Show("Please insert valid images!", "Images not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new InvalidOperationException("Image not found!");
            }
        }

        private Bitmap blendImages(Bitmap img1, Bitmap img2, double num)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = (int)((num * color1.R) + (1 - num) * color2.R);
                        G = (int)((num * color1.G) + (1 - num) * color2.G);
                        B = (int)((num * color1.B) + (1 - num) * color2.B);

                        if (R < 0) R = 0;
                        else if (R > 255) R = 255;
                        if (G < 0) G = 0;
                        else if (G > 255) G = 255;
                        if (B < 0) B = 0;
                        else if (B > 255) B = 255;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void txtMult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultA_Click(object sender, EventArgs e)
        {
            string txt = txtMultA.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0)
            {
                MessageBox.Show("Enter a value greater than 1", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                img1 = multImage(img1, double.Parse(txt));
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap multImage(Bitmap image, double num)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;
                    int R, G, B;

                    R = (int)(color.R * num);
                    G = (int)(color.G * num);
                    B = (int)(color.B * num);

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    colorOut = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }
            return outputImage;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string txt = txtDiv.Text;
            if (txt == "") txt = "2";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0 || num > 255)
            {
                MessageBox.Show("Please insert a value in range 1 - 255", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = divImages(img1, img2, int.Parse(txt));
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDivB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDivB_Click(object sender, EventArgs e)
        {
            string txt = txtDivB.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0 || num > 255)
            {
                MessageBox.Show("Please insert a value in range 1 - 255", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img2);
                img2 = divImage(img2, double.Parse(txt));
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = multiplyImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error when multiplying images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap multiplyImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    R = color1.R * color2.R;
                    G = color1.G * color2.G;
                    B = color1.B * color2.B;

                    if (R < 0) R = 0;
                    else if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    else if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    else if (B > 255) B = 255;
                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }

            return outputImage;
        }

        private void txtMultB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultB_Click(object sender, EventArgs e)
        {
            string txt = txtMultB.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0)
            {
                MessageBox.Show("Enter a value greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img2);
                img2 = multImage(img2, double.Parse(txt));
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBinaryA_Click(object sender, EventArgs e)
        {
            string txt = txtBinA.Text;
            if (txt == "") txt = "0.5";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0 || num > 1)
            {
                MessageBox.Show("Please insert a value in range 0.0 - 1.0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                img1 = toBinary(img1, double.Parse(txt));
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap toBinary(Bitmap image, double thresh)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;
            double thresold = 255 * thresh;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;

                    int R, G, B;

                    if (color.R >= thresold && color.G >= thresold && color.B >= thresold)
                    {
                        R = 255;
                        G = 255;
                        B = 255;
                    }
                    else
                    {
                        R = 0;
                        G = 0;
                        B = 0;
                    }

                    colorOut = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private void btnBinaryB_Click(object sender, EventArgs e)
        {
            string txt = txtBinB.Text;
            if (txt == "") txt = "0.5";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0 || num > 1)
            {
                MessageBox.Show("Please insert a value in range 0.0 - 1.0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img2);
                img2 = toBinary(img2, double.Parse(txt));
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGrayA_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                img1 = toGray(img1);
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap toGray(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;

                    int grayScale = (int)((color.R * 0.3) + (color.G * 0.59) + (color.B * 0.11));
                    colorOut = Color.FromArgb(grayScale, grayScale, grayScale);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private void btnGrayB_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img2);
                img2 = toGray(img2);
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNotA_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                img1 = invertImageColor(img1);
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to NOT image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap invertImageColor(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;

                    int R, G, B;

                    R = 255 - color.R;
                    G = 255 - color.G;
                    B = 255 - color.B;

                    colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private void btnNotB_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img2);
                img2 = invertImageColor(img2);
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to NOT image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAND_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = andImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error AND images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap andImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA, 0.5);
            imgB = toBinary(imgB, 0.5);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if (color1.R > 0 && color2.R > 0)
                    {
                        R = 255;
                    }
                    else R = 0;

                    if (color1.G > 0 && color2.G > 0)
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (color1.B > 0 && color2.B > 0)
                    {
                        B = 255;
                    }
                    else B = 0;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = orImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error OR images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap orImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA, 0.5);
            imgB = toBinary(imgB, 0.5);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if (color1.R > 0 || color2.R > 0)
                    {
                        R = 255;
                    }
                    else R = 0;

                    if (color1.G > 0 || color2.G > 0)
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (color1.B > 0 || color2.B > 0)
                    {
                        B = 255;
                    }
                    else B = 0;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = xorImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error XOR images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap xorImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA, 0.5);
            imgB = toBinary(imgB, 0.5);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if (color1.R > 0 ^ color2.R > 0)
                    {
                        R = 255;
                    }
                    else R = 0;

                    if (color1.G > 0 ^ color2.G > 0)
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (color1.B > 0 ^ color2.B > 0)
                    {
                        B = 255;
                    }
                    else B = 0;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnNOT_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = notImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error NOT images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap notImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA, 0.5);
            imgB = toBinary(imgB, 0.5);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if (!(color1.R > 0 && color2.R > 0))
                    {
                        R = 255;
                    }
                    else R = 0;

                    if (!(color1.G > 0 && color2.G > 0))
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (!(color1.B > 0 && color2.B > 0))
                    {
                        B = 255;
                    }
                    else B = 0;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                exportImage(imgR);

                MessageBox.Show("Success when exporting image",
                    "Image result exported to executable directory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error export image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool exportImage(Bitmap image)
        {
            try
            {
                ImageCodecInfo myImageCodecInfo;
                Encoder myEncoder;
                EncoderParameter myEncoderParameter;
                EncoderParameters myEncoderParameters;

                // Get an ImageCodecInfo object that represents the JPEG codec.
                myImageCodecInfo = GetEncoderInfo("image/jpeg");

                myEncoder = Encoder.Quality;

                myEncoderParameters = new EncoderParameters(1);

                // Save the bitmap as a JPEG file with quality level 100.
                myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                image.Save("exported_result.jpg", myImageCodecInfo, myEncoderParameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(imgR);

                imgR = mirrorImages(imgR);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Mirror image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap mirrorImages(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width * 2, image.Height);

            int x, y;
            int i = outputImage.Width - 1;

            for (x = 0; x < image.Width; x++, i--)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);

                    outputImage.SetPixel(x, y, color);
                    outputImage.SetPixel(i, y, color);
                }
            }
            return outputImage;
        }

        private void btnGenAndSum_Click(object sender, EventArgs e)
        {
            try
            {
                img1 = generateImage();
                pbA.Image = img1;

                img2 = generateImage();
                pbB.Image = imgR;

                imgR = addImages(img1, img2);
                imgRCopy = imgR;
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Mirror image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap generateImage()
        {
            //By aybe - StackOverflow
            Bitmap image = new Bitmap(10, 10, PixelFormat.Format8bppIndexed);
            var bitmapData = image.LockBits(new Rectangle(Point.Empty, image.Size), ImageLockMode.ReadWrite, image.PixelFormat);
            Random random = new Random();
            byte[] buffer = new byte[image.Width * image.Height];
            random.NextBytes(buffer);
            System.Runtime.InteropServices.Marshal.Copy(buffer, 0, bitmapData.Scan0, buffer.Length);
            image.UnlockBits(bitmapData);
            return image;
        }

        private void btnMirrorA_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);

                img1 = mirrorImages(img1);
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Mirror image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnMirrorB_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img2);

                img2 = mirrorImages(img2);
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Mirror image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGenA_Click(object sender, EventArgs e)
        {
            try
            {
                img1 = generateImage();
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Mirror image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGenB_Click(object sender, EventArgs e)
        {
            try
            {
                img2 = generateImage();
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Mirror image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

      

        private void txtDiv_TextChanged(object sender, EventArgs e)
        {

        }

       

       

       

        private void bntHist_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                calculateHistogram(img1);

            }

            if (img2 != null)
            {

            }

            if (imgR != null)
            {

            }

            //Form2 f2 = new Form2();
            //f2.ShowDialog();
        }

        private void calculateHistogram(Bitmap image)
        {
            Bitmap imageGrayScale = toGray(image);

            int x, y;
            int[] histCount = new int[256];

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color colorPixel = imageGrayScale.GetPixel(x, y);

                    histCount[colorPixel.R]++;

                }
            }

            chart1.Series["QtyPixels"].Points.Clear();
            for (int i = 1; i < 256; i++)
            {
                chart1.Series["QtyPixels"].Points.AddXY(i, histCount[i]);
            }
        }

        private Bitmap equalizeImage(Bitmap image)
        {
            Bitmap imageEqualized = new Bitmap(image.Width, image.Height);


            //Step 1 - Calculate Histogram
            int[] histCountR = new int[256];
            int[] histCountG = new int[256];
            int[] histCountB = new int[256];

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color colorPixel = image.GetPixel(x, y);
                    histCountR[colorPixel.R]++;
                    histCountG[colorPixel.G]++;
                    histCountB[colorPixel.B]++;
                }
            }

            //Step 2 - Calculate CFD
            int[] cfdR = new int[256];
            int[] cfdG = new int[256];
            int[] cfdB = new int[256];

            cfdR[0] = histCountR[0];
            cfdG[0] = histCountG[0];
            cfdB[0] = histCountB[0];

            for (int i = 1; i < 256; i++)
            {
                cfdR[i] = histCountR[i] + cfdR[i - 1];
                cfdG[i] = histCountG[i] + cfdG[i - 1];
                cfdB[i] = histCountB[i] + cfdB[i - 1];   
            }

            int minCfdR = cfdR.Min();
            int minCfdG = cfdG.Min();
            int minCfdB = cfdB.Min();

            double imageArea = image.Width * image.Height;

            //Step 3 - Calculate New Color
            int[] hR = new int[256];
            int[] hG = new int[256];
            int[] hB = new int[256];

            /*for (int i = 0; i < 256; i++)
            {
                hR[i] = ((cfdR[i] - minCfdR) / (imageArea - minCfdR)) * 254;
                hG[i] = ((cfdG[i] - minCfdG) / (imageArea - minCfdG)) * 254;
                hB[i] = ((cfdB[i] - minCfdB) / (imageArea - minCfdB)) * 254;
            }*/

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color colorPixel = image.GetPixel(x, y);

                    double R = ((cfdR[colorPixel.R] - minCfdR) / (imageArea - minCfdR)) * 254;
                    double G = ((cfdG[colorPixel.G] - minCfdG) / (imageArea - minCfdG)) * 254;
                    double B = ((cfdB[colorPixel.B] - minCfdB) / (imageArea - minCfdB)) * 254;

                    Color colorEq = Color.FromArgb((int)R, (int)G, (int)B);

                    imageEqualized.SetPixel(x, y, colorEq);

                }
            }

            //Calculate Histogram Equalized
            int[] histEqCount = new int[256];

            Bitmap imageGrayScale = toGray(imageEqualized);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color colorPixel = imageGrayScale.GetPixel(x, y);

                    histEqCount[colorPixel.R]++;

                }
            }

            chart2.Series["QtyPixels"].Points.Clear();
            for (int i = 1; i < 256; i++)
            {
                chart2.Series["QtyPixels"].Points.AddXY(i, histEqCount[i]);
            }

            return imageEqualized;
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                imgR = equalizeImage(img1);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Mirror image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEqA_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                img1 = equalizeImage(img1);
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void rdoTree_CheckedChanged(object sender, EventArgs e)
        {
            filterDimension = 3;
        }

        private void rdoFive_CheckedChanged(object sender, EventArgs e)
        {
            filterDimension = 5;
        }

        private void rdoSeven_CheckedChanged(object sender, EventArgs e)
        {
            filterDimension = 7;
        }

        private void btnFilterMax_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                imgR = filterMax(img1);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFilterMin_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                imgR = filterMin(img1);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFilterAvg_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                imgR = filterAvg(img1);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFilterMed_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                imgR = filterMed(img1);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFilterOrd_Click(object sender, EventArgs e)
        {
            int neighborhoodSize = filterDimension * filterDimension;
            string txt = txtFilterOrd.Text;
            if (txt == "") txt = neighborhoodSize.ToString();
            else if (!int.TryParse(txt, out int num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num < 0 || num > neighborhoodSize)
            {
                MessageBox.Show("Please insert a value in range 0 - " +  neighborhoodSize, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            try
            {
                verifyImage(img1);
                imgR = filterOrd(img1, int.Parse(txt));
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFilterSmoothing_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                imgR = filterSmoothing(img1);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFilterGaus_Click(object sender, EventArgs e)
        {
            int neighborhoodSize = filterDimension * filterDimension;
            string txt = txtFilterGaus.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num < 0 || num > 3)
            {
                MessageBox.Show("Please insert a value in range 0.0 - 3.0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                imgR = filterGaussian(img1, double.Parse(txt));
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    " image error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap filterGaussian(Bitmap image, double num)
        {
            Bitmap outputImage = new Bitmap(image.Width + 1, image.Height + 1);

            int kernelArea = filterDimension * filterDimension;

            /*int[] kernel = new int[kernelArea];

            for (int i = 0; i < kernelArea; i++) kernel[i] = 1;*/

            for (int x = 1; x < (image.Width - 1); x++)
            {
                for (int y = 1; y < (image.Height - 1); y++)
                {

                    const double PI = 3.1415926535897931;

                    int R, G, B;

                    double sumRed = 0, sumGreen = 0, sumBlue = 0, div = 0, filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow( - 1, 2) + Math.Pow( - 1, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x - 1, y - 1).R * filter;
                    sumGreen += image.GetPixel(x - 1, y - 1).G * filter;
                    sumBlue += image.GetPixel(x - 1, y - 1).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow( - 1, 2) + Math.Pow(0, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x - 1, y).R * filter;
                    sumGreen += image.GetPixel(x - 1, y).G * filter;
                    sumBlue += image.GetPixel(x - 1, y).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow( - 1, 2) + Math.Pow( 1, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x - 1, y + 1).R * filter;
                    sumGreen += image.GetPixel(x - 1, y + 1).G * filter;
                    sumBlue += image.GetPixel(x - 1, y + 1).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow(0, 2) + Math.Pow( - 1, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x, y - 1).R * filter;
                    sumGreen += image.GetPixel(x, y - 1).G * filter;
                    sumBlue += image.GetPixel(x, y - 1).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow(0, 2) + Math.Pow(0, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x, y).R * filter;
                    sumGreen += image.GetPixel(x, y).G * filter;
                    sumBlue += image.GetPixel(x, y).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow(0, 2) + Math.Pow( 1, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x, y + 1).R * filter;
                    sumGreen += image.GetPixel(x, y + 1).G * filter;
                    sumBlue += image.GetPixel(x, y + 1).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow(1, 2) + Math.Pow(- 1, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x + 1, y - 1).R * filter;
                    sumGreen += image.GetPixel(x + 1, y - 1).G * filter;
                    sumBlue += image.GetPixel(x + 1, y - 1).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow(1, 2) + Math.Pow(0, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x + 1, y).R * filter;
                    sumGreen += image.GetPixel(x + 1, y).G * filter;
                    sumBlue += image.GetPixel(x + 1, y).B * filter;
                    div += filter;

                    filter = ((1 / (2 * PI * Math.Pow(num, 2))) * Math.Exp(-((Math.Pow(1, 2) + Math.Pow(1, 2)) / (2 * Math.Pow(num, 2)))));
                    sumRed += image.GetPixel(x + 1, y + 1).R * filter;
                    sumGreen += image.GetPixel(x + 1, y + 1).G * filter;
                    sumBlue += image.GetPixel(x + 1, y + 1).B * filter;
                    div += filter;


                    R = (int)(sumRed / div);
                    G = (int)(sumGreen / div);
                    B = (int)(sumBlue / div);

                    if (R < 0) R = 0;
                    else if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    else if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    else if (B > 255) B = 255;

                    Color colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private Bitmap filterSmoothing(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width + 1, image.Height + 1);

            int kernelArea = filterDimension * filterDimension;

            /*int[] kernel = new int[kernelArea];

            for (int i = 0; i < kernelArea; i++) kernel[i] = 1;*/

            for (int x = 1; x < (image.Width - 1); x++)
            {
                for (int y = 1; y < (image.Height - 1); y++)
                {
                    int R, G, B;

                    Neighborhood neighborhood = calculateNeighborhood(image, x, y);

                    //neighborhood.ngbR.RemoveAt((kernelArea - 1) / 2);
                    int minNgbR = neighborhood.ngbR.Min(), minNgbG = neighborhood.ngbG.Min(), minNgbB = neighborhood.ngbB.Min();
                    int maxNgbR = neighborhood.ngbR.Max(), maxNgbG = neighborhood.ngbG.Max(), maxNgbB = neighborhood.ngbB.Max();
                    Color centraPixel = image.GetPixel(x, y);

                    if (centraPixel.R < minNgbR) R = minNgbR;
                    else if (centraPixel.R > maxNgbR) R = maxNgbR;
                    else R = centraPixel.R;

                    if (centraPixel.G < minNgbG) G = minNgbG;
                    else if (centraPixel.G > maxNgbG) G = maxNgbG;
                    else G = centraPixel.G;

                    if (centraPixel.B < minNgbB) B = minNgbB;
                    else if (centraPixel.B > maxNgbB) B = maxNgbB;
                    else B = centraPixel.B;

                    Color colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private Bitmap filterOrd(Bitmap image, int num)
        {
            Bitmap outputImage = new Bitmap(image.Width + 1, image.Height + 1);

            int kernelArea = filterDimension * filterDimension;

            if (num == kernelArea) num -= 1;

            /*int[] kernel = new int[kernelArea];

            for (int i = 0; i < kernelArea; i++) kernel[i] = 1;*/

            for (int x = 1; x < (image.Width - 1); x++)
            {
                for (int y = 1; y < (image.Height - 1); y++)
                {

                    Neighborhood neighborhood = calculateNeighborhood(image, x, y);

                    int[] ngbR = neighborhood.ngbR;
                    int[] ngbG = neighborhood.ngbG;
                    int[] ngbB = neighborhood.ngbB;

                    Array.Sort(ngbR);
                    Array.Sort(ngbG);
                    Array.Sort(ngbB);

                    int R = ngbR[num], G = ngbG[num], B = ngbB[num];

                    Color colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private Bitmap filterMed(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width + 1, image.Height + 1);

            int kernelArea = filterDimension * filterDimension;
            int droppedLines = filterDimension / 2;
            /*int[] kernel = new int[kernelArea];

            for (int i = 0; i < kernelArea; i++) kernel[i] = 1;*/

            for (int x = droppedLines; x < (image.Width - droppedLines); x++)
            {
                for (int y = droppedLines; y < (image.Height - droppedLines); y++)
                {

                    Neighborhood neighborhood = calculateNeighborhood(image, x, y);

                    int[] ngbR = neighborhood.ngbR;
                    int[] ngbG = neighborhood.ngbG;
                    int[] ngbB = neighborhood.ngbB;

                    Array.Sort(ngbR);
                    Array.Sort(ngbG);
                    Array.Sort(ngbB);

                    int R = ngbR[(kernelArea-1) / 2], G = ngbG[(kernelArea - 1) / 2], B = ngbB[(kernelArea - 1) / 2];

                    Color colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private Bitmap filterAvg(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width + 1, image.Height + 1);

            int kernelArea = filterDimension * filterDimension;
            int droppedLines = filterDimension / 2;

            /*int[] kernel = new int[kernelArea];

            for (int i = 0; i < kernelArea; i++) kernel[i] = 1;*/

            for (int x = droppedLines; x < (image.Width - droppedLines); x++)
            {
                for (int y = droppedLines; y < (image.Height - droppedLines); y++)
                {

                    Neighborhood neighborhood = calculateNeighborhood(image, x, y);

                    int R = (neighborhood.ngbR.Sum()/kernelArea), G = (neighborhood.ngbG.Sum()/kernelArea), B = (neighborhood.ngbB.Sum()/kernelArea);

                    Color colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private Bitmap filterMax(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width + 1, image.Height + 1);

            /*int kernelArea = filterDimension * filterDimension;

            int[] kernel = new int[kernelArea];

            for (int i = 0; i < kernelArea; i++) kernel[i] = 1;*/

            for (int x = 1; x < (image.Width-1); x++)
            {
                for (int y = 1; y < (image.Height-1); y++)
                { 

                    Neighborhood neighborhood = calculateNeighborhood(image, x, y);

                    int R = neighborhood.ngbR.Max(), G = neighborhood.ngbG.Max(), B = neighborhood.ngbB.Max();

                    Color colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;

        }

        private Bitmap filterMin(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width + 1, image.Height + 1);

            /*int kernelArea = filterDimension * filterDimension;

            int[] kernel = new int[kernelArea];

            for (int i = 0; i < kernelArea; i++) kernel[i] = 1;*/

            for (int x = 1; x < (image.Width - 1); x++)
            {
                for (int y = 1; y < (image.Height - 1); y++)
                {

                    Neighborhood neighborhood = calculateNeighborhood(image, x, y);

                    int R = neighborhood.ngbR.Min(), G = neighborhood.ngbG.Min(), B = neighborhood.ngbB.Min();

                    Color colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;

        }

        public class Neighborhood
        {
            public int[] ngbR { get; set; }
            public int[] ngbG { get; set; }
            public int[] ngbB { get; set; }
        }

        private Neighborhood calculateNeighborhood(Bitmap image, int x, int y)
        {
            //Color[] neighborhood = new Color[filterDimension * filterDimension];
            int[] ngbR = new int[filterDimension * filterDimension];
            int[] ngbG = new int[filterDimension * filterDimension];
            int[] ngbB = new int[filterDimension * filterDimension];

            if (filterDimension == 3)
            {
                /*neighborhood[0] = image.GetPixel(x - 1, y - 1);
                neighborhood[1] = image.GetPixel(x - 1, y);
                neighborhood[2] = image.GetPixel(x - 1, y + 1);
                neighborhood[3] = image.GetPixel(x, y - 1);

                neighborhood[4] = image.GetPixel(x, y);

                neighborhood[5] = image.GetPixel(x, y + 1);
                neighborhood[6] = image.GetPixel(x + 1, y - 1);
                neighborhood[7] = image.GetPixel(x + 1, y);
                neighborhood[8] = image.GetPixel(x + 1, y + 1);*/

                //neighborhood red
                ngbR[0] = image.GetPixel(x - 1, y - 1).R;
                ngbR[1] = image.GetPixel(x - 1, y).R;
                ngbR[2] = image.GetPixel(x - 1, y + 1).R;
                ngbR[3] = image.GetPixel(x, y - 1).R;

                ngbR[4] = image.GetPixel(x, y).R;

                ngbR[5] = image.GetPixel(x, y + 1).R;
                ngbR[6] = image.GetPixel(x + 1, y - 1).R;
                ngbR[7] = image.GetPixel(x + 1, y).R;
                ngbR[8] = image.GetPixel(x + 1, y + 1).R;

                //neighborhood green
                ngbG[0] = image.GetPixel(x - 1, y - 1).G;
                ngbG[1] = image.GetPixel(x - 1, y).G;
                ngbG[2] = image.GetPixel(x - 1, y + 1).G;
                ngbG[3] = image.GetPixel(x, y - 1).G;

                ngbG[4] = image.GetPixel(x, y).G;

                ngbG[5] = image.GetPixel(x, y + 1).G;
                ngbG[6] = image.GetPixel(x + 1, y - 1).G;
                ngbG[7] = image.GetPixel(x + 1, y).G;
                ngbG[8] = image.GetPixel(x + 1, y + 1).G;

                //neighborhood blue
                ngbB[0] = image.GetPixel(x - 1, y - 1).B;
                ngbB[1] = image.GetPixel(x - 1, y).B;
                ngbB[2] = image.GetPixel(x - 1, y + 1).B;
                ngbB[3] = image.GetPixel(x, y - 1).B;

                ngbB[4] = image.GetPixel(x, y).B;

                ngbB[5] = image.GetPixel(x, y + 1).B;
                ngbB[6] = image.GetPixel(x + 1, y - 1).B;
                ngbB[7] = image.GetPixel(x + 1, y).B;
                ngbB[8] = image.GetPixel(x + 1, y + 1).B;
            }
            else if (filterDimension == 5) // TEM Q TRATAR
            {
                /*neighborhood[0] = image.GetPixel(x - 2, y - 2);
                neighborhood[1] = image.GetPixel(x - 2, y - 1);
                neighborhood[2] = image.GetPixel(x - 2, y);
                neighborhood[3] = image.GetPixel(x - 2, y + 1);
                neighborhood[4] = image.GetPixel(x - 2, y + 2);
                neighborhood[5] = image.GetPixel(x - 1, y - 2);
                neighborhood[6] = image.GetPixel(x - 1, y - 1);
                neighborhood[7] = image.GetPixel(x - 1, y);
                neighborhood[8] = image.GetPixel(x - 1, y + 1);
                neighborhood[9] = image.GetPixel(x - 1, y + 2);
                neighborhood[10] = image.GetPixel(x, y - 2);
                neighborhood[11] = image.GetPixel(x, y - 1);

                neighborhood[12] = image.GetPixel(x, y);

                neighborhood[13] = image.GetPixel(x, y + 1);
                neighborhood[14] = image.GetPixel(x, y + 2);
                neighborhood[15] = image.GetPixel(x + 1, y - 2);
                neighborhood[16] = image.GetPixel(x + 1, y - 1);
                neighborhood[17] = image.GetPixel(x + 1, y);
                neighborhood[18] = image.GetPixel(x + 1, y + 1);
                neighborhood[19] = image.GetPixel(x + 1, y + 2);
                neighborhood[20] = image.GetPixel(x + 2, y - 2);
                neighborhood[21] = image.GetPixel(x + 2, y - 1);
                neighborhood[22] = image.GetPixel(x + 2, y);
                neighborhood[23] = image.GetPixel(x + 2, y + 1);
                neighborhood[24] = image.GetPixel(x + 2, y + 2);*/

                //neighborhood red
                ngbR[0] = image.GetPixel(x - 2, y - 2).R;
                ngbR[1] = image.GetPixel(x - 2, y - 1).R;
                ngbR[2] = image.GetPixel(x - 2, y).R;
                ngbR[3] = image.GetPixel(x - 2, y + 1).R;
                ngbR[4] = image.GetPixel(x - 2, y + 2).R;
                ngbR[5] = image.GetPixel(x - 1, y - 2).R;
                ngbR[6] = image.GetPixel(x - 1, y - 1).R;
                ngbR[7] = image.GetPixel(x - 1, y).R;
                ngbR[8] = image.GetPixel(x - 1, y + 1).R;
                ngbR[9] = image.GetPixel(x - 1, y + 2).R;
                ngbR[10] = image.GetPixel(x, y - 2).R;
                ngbR[11] = image.GetPixel(x, y - 1).R;
                ngbR[12] = image.GetPixel(x, y).R;
                ngbR[13] = image.GetPixel(x, y + 1).R;
                ngbR[14] = image.GetPixel(x, y + 2).R;
                ngbR[15] = image.GetPixel(x + 1, y - 2).R;
                ngbR[16] = image.GetPixel(x + 1, y - 1).R;
                ngbR[17] = image.GetPixel(x + 1, y).R;
                ngbR[18] = image.GetPixel(x + 1, y + 1).R;
                ngbR[19] = image.GetPixel(x + 1, y + 2).R;
                ngbR[20] = image.GetPixel(x + 2, y - 2).R;
                ngbR[21] = image.GetPixel(x + 2, y - 1).R;
                ngbR[22] = image.GetPixel(x + 2, y).R;
                ngbR[23] = image.GetPixel(x + 2, y + 1).R;
                ngbR[24] = image.GetPixel(x + 2, y + 2).R;

                //neighborhood green
                ngbG[0] = image.GetPixel(x - 2, y - 2).G;
                ngbG[1] = image.GetPixel(x - 2, y - 1).G;
                ngbG[2] = image.GetPixel(x - 2, y).G;
                ngbG[3] = image.GetPixel(x - 2, y + 1).G;
                ngbG[4] = image.GetPixel(x - 2, y + 2).G;
                ngbG[5] = image.GetPixel(x - 1, y - 2).G;
                ngbG[6] = image.GetPixel(x - 1, y - 1).G;
                ngbG[7] = image.GetPixel(x - 1, y).G;
                ngbG[8] = image.GetPixel(x - 1, y + 1).G;
                ngbG[9] = image.GetPixel(x - 1, y + 2).G;
                ngbG[10] = image.GetPixel(x, y - 2).G;
                ngbG[11] = image.GetPixel(x, y - 1).G;
                ngbG[12] = image.GetPixel(x, y).G;
                ngbG[13] = image.GetPixel(x, y + 1).G;
                ngbG[14] = image.GetPixel(x, y + 2).G;
                ngbG[15] = image.GetPixel(x + 1, y - 2).G;
                ngbG[16] = image.GetPixel(x + 1, y - 1).G;
                ngbG[17] = image.GetPixel(x + 1, y).G;
                ngbG[18] = image.GetPixel(x + 1, y + 1).G;
                ngbG[19] = image.GetPixel(x + 1, y + 2).G;
                ngbG[20] = image.GetPixel(x + 2, y - 2).G;
                ngbG[21] = image.GetPixel(x + 2, y - 1).G;
                ngbG[22] = image.GetPixel(x + 2, y).G;
                ngbG[23] = image.GetPixel(x + 2, y + 1).G;
                ngbG[24] = image.GetPixel(x + 2, y + 2).G;

                //neighborhood blue
                ngbB[0] = image.GetPixel(x - 2, y - 2).B;
                ngbB[1] = image.GetPixel(x - 2, y - 1).B;
                ngbB[2] = image.GetPixel(x - 2, y).B;
                ngbB[3] = image.GetPixel(x - 2, y + 1).B;
                ngbB[4] = image.GetPixel(x - 2, y + 2).B;
                ngbB[5] = image.GetPixel(x - 1, y - 2).B;
                ngbB[6] = image.GetPixel(x - 1, y - 1).B;
                ngbB[7] = image.GetPixel(x - 1, y).B;
                ngbB[8] = image.GetPixel(x - 1, y + 1).B;
                ngbB[9] = image.GetPixel(x - 1, y + 2).B;
                ngbB[10] = image.GetPixel(x, y - 2).B;
                ngbB[11] = image.GetPixel(x, y - 1).B;
                ngbB[12] = image.GetPixel(x, y).B;
                ngbB[13] = image.GetPixel(x, y + 1).B;
                ngbB[14] = image.GetPixel(x, y + 2).B;
                ngbB[15] = image.GetPixel(x + 1, y - 2).B;
                ngbB[16] = image.GetPixel(x + 1, y - 1).B;
                ngbB[17] = image.GetPixel(x + 1, y).B;
                ngbB[18] = image.GetPixel(x + 1, y + 1).B;
                ngbB[19] = image.GetPixel(x + 1, y + 2).B;
                ngbB[20] = image.GetPixel(x + 2, y - 2).B;
                ngbB[21] = image.GetPixel(x + 2, y - 1).B;
                ngbB[22] = image.GetPixel(x + 2, y).B;
                ngbB[23] = image.GetPixel(x + 2, y + 1).B;
                ngbB[24] = image.GetPixel(x + 2, y + 2).B;
            }
            else if (filterDimension == 7) { }

                return new Neighborhood { ngbR = ngbR, ngbG = ngbG, ngbB = ngbB };
        }

        private void btnEqB_Click(object sender, EventArgs e)
        {

        }
    }
}
