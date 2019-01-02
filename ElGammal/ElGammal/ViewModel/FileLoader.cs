using Microsoft.Win32;
using System;
using System.IO;

namespace ViewModel
{
    public static class FileLoader
    {
        #region Methods

        public static byte[] LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                return File.ReadAllBytes(openFileDialog.FileName);
            else
                throw new NullReferenceException();
        }

        #endregion //Methods
    }
}