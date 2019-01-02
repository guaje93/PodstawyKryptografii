using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utills;

namespace ViewModel
{
    public class OriginalMessageFactory : BaseViewClass
    {
        #region Fields

        private string _originalStringMessage;
        private byte[] _originalFileMessage;
        private string _operationStatus;

        #endregion

        #region Properties

        public string OriginalStringMessage
        {
            get => _originalStringMessage;
            set
            {
                _originalStringMessage = value;
                OnPropertyChanged();
            }
        }

        public byte[] OriginalFileMessage
        {
            get => _originalFileMessage;
            set
            {
                _originalFileMessage = value;
                OnPropertyChanged();
            }
        }

        public string OperationStatus
        {
            get => _operationStatus;
            set
            {
                _operationStatus = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties

        #region Constructors

        public OriginalMessageFactory(string originalStringMessage, byte[] originalFileMessage)
        {
            OriginalStringMessage = originalStringMessage;
            OriginalFileMessage = originalFileMessage;
        }

        public OriginalMessageFactory()
        {
        }

        #endregion //Constructors
    }
}
