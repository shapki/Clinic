using System.Windows.Forms;

namespace Clinic.AppServices
{
    internal class FileManager
    {
        /// <summary>
        /// PKGH
        /// Получение пути к изображению в папке программы
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns></returns>
        public static string GetImgPath(string fileName)
        {
            return System.IO.Path.Combine(Application.StartupPath, "img", fileName);
        }
    }
}
