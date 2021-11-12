using System.Drawing;

namespace WindowsApp.Modules
{
    class DriverLicenseImage
    {
        private Bitmap bitmap;
        private Graphics graphics;

        /// <summary>
        /// Создает картинку для дальнейшей работы с ней.
        /// </summary>
        /// <param name="filename"></param>
        public DriverLicenseImage(string filename)
        {
            bitmap = new Bitmap(filename);
            graphics = Graphics.FromImage(bitmap);
        }


    }
}
