using System;
using System.Windows;
using Utills;

namespace ViewModel
{
    public class HashComparer : BaseViewClass
    {
        #region Fields

        private string stringResult;
        private byte[] _originalHash;
        private byte[] _decryptedHash;

        #endregion //Fields

        #region Properties

        public string StringResult
        {
            get => stringResult;
            set
            {
                stringResult = value;
                OnPropertyChanged();
            }
        }

        public byte[] OriginalHash
        {
            get => _originalHash; set
            {
                _originalHash = value;
                OnPropertyChanged();
            }
        }

        public byte[] DecryptedHash
        {
            get => _decryptedHash; set
            {
                _decryptedHash = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties

        #region Methods

        public void CompareHashes()
        {
            try
            {
                if (AreHashesEqual())
                    StringResult = "Skróty są identyczne!";
                else
                    StringResult = "Skróty się różnią!";

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Brak parametrów do porównania");
            }
        }


        private bool AreHashesEqual()
        {
            if (OriginalHash == null || DecryptedHash == null)
                throw new NullReferenceException();

            if (OriginalHash.Length != DecryptedHash.Length)
                return false;

            for (int i = 0; i < DecryptedHash.Length; i++)
                if (!DecryptedHash[i].Equals(OriginalHash[i]))
                    return false;

            return true;
        }

        #endregion //Methods
    }
}
