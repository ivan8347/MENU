using System.Drawing;
using System.IO;

namespace MENU
{
    public static class ImageExtensions
    {
        public static byte[] ImageToBytes(this Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
