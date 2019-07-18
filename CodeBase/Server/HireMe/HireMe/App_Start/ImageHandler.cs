using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace HireMe.App_Start
{
    public static class ImageHandler
    {
        /// <summary>
        /// Allows for image resizing. if AllowLargerImageCreation = true 
        /// you want to increase the size of the image
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="newWidth"></param>
        /// <param name="maxHeight"></param>
        /// <param name="allowLargerImageCreation"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static byte[] ResizeImage(byte[] bytes, int newWidth, int maxHeight, bool allowLargerImageCreation)
        {

            Image fullsizeImage = null;
            Image resizedImage = null;
            //Cast bytes to an image
            fullsizeImage = ByteArrayToImage(bytes);

            // Prevent using images internal thumbnail
            fullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            fullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            // If we are re sizing upwards to a bigger size
            if (allowLargerImageCreation)
            {
                if (fullsizeImage.Width <= newWidth)
                {
                    newWidth = fullsizeImage.Width;
                }
            }

            //Keep aspect ratio
            int newHeight = fullsizeImage.Height * newWidth / fullsizeImage.Width;
            if (newHeight > maxHeight)
            {
                // Resize with height instead
                newWidth = fullsizeImage.Width * maxHeight / fullsizeImage.Height;
                newHeight = maxHeight;
            }

            var thumbnailImg = new Bitmap(newWidth, newHeight);
            var thumbGraph = Graphics.FromImage(thumbnailImg);
            thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
            thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
            thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imageRectangle = new Rectangle(0, 0, newWidth, newHeight);
            thumbGraph.DrawImage(fullsizeImage, imageRectangle);

            //resizedImage = fullsizeImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            fullsizeImage.Dispose();

            return ImageToByteArray(thumbnailImg);
        }

        /// <summary>
        /// convert image to byte array
        /// </summary>
        /// <param name="imageIn"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        private static byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }


        /// <summary>
        /// Convert a byte array to an image
        /// </summary>
        /// <remarks></remarks>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }

}