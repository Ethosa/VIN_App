using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace WindowsApp.Modules
{
    class DriverLicenseImage
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private Font font;
        private Brush brush;
        private Brush hintBrush;
        private Brush numBrush;

        /// <summary>
        /// Создает картинку для дальнейшей работы с ней.
        /// </summary>
        /// <param name="filename"></param>
        public DriverLicenseImage(Bitmap bmp)
        {
            bitmap = new Bitmap(bmp);
            graphics = Graphics.FromImage(bitmap);
            font = new Font("Arial", 24);
            brush = new SolidBrush(Color.Black);
            hintBrush = new SolidBrush(Color.Gray);
            numBrush = new SolidBrush(Color.DarkViolet);
            SetupGraphics();
        }

        /// <summary>
        /// Рисует данные ВУ.
        /// </summary>
        public void DrawInfo(string lastname, string firstname, string middlename, string categories,
                             string address, string dateFrom, string dateTo, string licNum, string licSerial)
        {
            float x = 285;
            float y = DrawPart("1.", lastname, "SURNAME", x, 200);
            y = DrawPart("2.", firstname + " " + middlename, "NAME MIDDLE NAME", x, y);
            y = DrawPart("3.", address, "", x, y);
            y = DrawPart("4a)", dateFrom + "  " + dateTo, "", x, y);
            y = DrawPart("5.", licSerial + " " + licNum, "", x, y);
            DrawPart("9.", categories, "", x, y + 24*4);
        }

        public float DrawPart(string number, string text, string hint, float x, float y)
        {
            graphics.DrawString(number, font, numBrush, new PointF(x, y));
            graphics.DrawString(text, font, brush, new PointF(x + 40, y));
            graphics.DrawString(hint, font, hintBrush, new PointF(x + 40, y + 27));
            return y + 60;
        }

        /// <summary>
        /// Возвращает bitmap.
        /// </summary>
        /// <returns></returns>
        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public static byte[] GetBytes(Image img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        /// <summary>
        /// Настройка Graphics
        /// </summary>
        private void SetupGraphics()
        {
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        }
    }
}
