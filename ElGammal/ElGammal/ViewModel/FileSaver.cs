using Microsoft.Win32;
using System.IO;

namespace ViewModel
{
    public static class FileSaver
    {
        #region Methods

        public static void SaveToFile(byte [] byteArray)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.ShowDialog();

            if (file.FileName != "")
                File.WriteAllBytes(file.FileName, byteArray);
        }

        #endregion //Methods
    }
}
