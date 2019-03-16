using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HireMe.Utility
{
    public class Base64Extensions
    {
        /// <summary>
        /// To demonstrate extraction of file extension from base64 string.
        /// </summary>
        /// <param name="base64String">base64 string.</param>
        /// <returns>Henceforth file extension from string.</returns>
        public static string GetFileExtension(string base64String)
        {


            var data = base64String.Substring(0, 5);

            //System.Text.RegularExpressions.Regex.Match("/data:([a - zA - Z0 - 9] +\/[a - zA - Z0 - 9 -.+] +).*,.*/");
            var regex = new Regex(@"data:(?<mime>[\w/\-\.]+);(?<encoding>\w+),(?<data>.*)", RegexOptions.Compiled);

            var match = regex.Match(base64String);
            var mime = match.Groups["mime"].Value;
            //var encoding = match.Groups["encoding"].Value;
            //var data = match.Groups["data"].Value;

            switch (mime.ToUpper())
            {
                case "IMAGE/BMP":
                    return "bmp";
                case "IMAGE/GIF":
                    return "gif";
                case "IMAGE/JPEG":
                    return "jpg";
                case "IMAGE/TIFF":
                    return "tiff";
                case "IMAGE/PNG":
                    return "png";
                default:
                    return string.Empty;
            }
        }

    }
}