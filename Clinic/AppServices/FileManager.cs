using System.Windows.Forms;

namespace Clinic.AppServices
{
    internal class FileManager
    {
        public static string GetImgPath(string fileName)
        {
            return System.IO.Path.Combine(Application.StartupPath, "img", fileName);
        }
    }
}
