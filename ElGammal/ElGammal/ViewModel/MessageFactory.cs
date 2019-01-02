using Messages;
using Utills;

namespace ViewModel
{
    public class MessageFactory : BaseViewClass
    {
        #region Fields

        private FileMessage _fileMessage;
        private CipheredFileMessage _cipheredFileMessage;
        private StringMessage _stringMessage;
        private CipheredStringMessage _cipheredStringMessage;

        #endregion //Fields

        #region Properties

        public FileMessage FileMessage
        {
            get { return _fileMessage; }
            set
            {
                _fileMessage = value;
                OnPropertyChanged();
            }
        }

        public CipheredFileMessage CipheredFileMessage
        {
            get { return _cipheredFileMessage; }
            set
            {
                _cipheredFileMessage = value;
                OnPropertyChanged();
            }
        }

        public StringMessage StringMessage
        {
            get { return _stringMessage; }
            set
            {
                _stringMessage = value;
                OnPropertyChanged();
            }
        }
        public CipheredStringMessage CipheredStringMessage
        {
            get => _cipheredStringMessage;
            set
            {
                _cipheredStringMessage = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties

        #region Constructors

        public MessageFactory()
        {
            FileMessage = new FileMessage();
            CipheredFileMessage = new CipheredFileMessage();
            StringMessage = new StringMessage();
            CipheredStringMessage = new CipheredStringMessage();
        }

        #endregion //Constructors
    }
}
