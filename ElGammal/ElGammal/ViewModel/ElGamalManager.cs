using Keys;
using System;
using System.Text;
using System.Windows;

namespace ViewModel
{
    public class ElGamalManager
    {
        #region Fields

        private KeyFactory _keyFactory;
        private HashCreator _hashCreator;
        private HashComparer _hashComparer;
        private SaveToFileFactory _saveToFileFactory;
        private LoadFromFileFactory _loadFromFileFactory;
        private MessageFactory _messageFactory;
        private OriginalMessageFactory _originalMessageFactory;

        #endregion //Fields

        #region Properties

        public KeyFactory KeyFactory
        {
            get => _keyFactory;
            set => _keyFactory = value;
        }

        public HashCreator HashCreator
        {
            get => _hashCreator;
            set => _hashCreator = value;
        }

        public HashComparer HashComparer
        {
            get => _hashComparer;
            set => _hashComparer = value;
        }

        public SaveToFileFactory SaveToFileFactory
        {
            get => _saveToFileFactory;
            set => _saveToFileFactory = value;
        }

        public LoadFromFileFactory LoadFromFileFactory
        {
            get => _loadFromFileFactory;
            set => _loadFromFileFactory = value;
        }


        public MessageFactory MessageFactory
        {
            get { return _messageFactory; }
            set { _messageFactory = value; }
        }

        public OriginalMessageFactory OriginalMessageFactory
        {
            get => _originalMessageFactory;
            set => _originalMessageFactory = value;
        }

        #endregion //Properties

        #region Constructors

        public ElGamalManager()
        {
            KeyFactory = new KeyFactory();
            MessageFactory = new MessageFactory();
            OriginalMessageFactory = new OriginalMessageFactory();
            HashComparer = new HashComparer();
            HashCreator = new HashCreator(OriginalMessageFactory, MessageFactory);
            SaveToFileFactory = new SaveToFileFactory(KeyFactory, MessageFactory);
            LoadFromFileFactory = new LoadFromFileFactory(KeyFactory, MessageFactory, OriginalMessageFactory, HashComparer);
        }

        #endregion //Constructors

        #region Methods

        public void Encrypt(string parameter)
        {
            try
            {
                switch (parameter)
                {
                    case "string": MessageFactory.CipheredStringMessage = MessageFactory.StringMessage.EncryptString(KeyFactory); break;
                    case "file": MessageFactory.CipheredFileMessage = MessageFactory.FileMessage.EncryptFile(KeyFactory); break;
                    default: break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Brak wszystkich danych");
            }
        }
        public void Decrypt(string parameter)
        {
            try
            {
                switch (parameter)
                {
                    case "string":
                        {
                            MessageFactory.StringMessage = MessageFactory.CipheredStringMessage.DecryptString(KeyFactory);
                            HashComparer.DecryptedHash = MessageFactory.CipheredStringMessage.DecryptString(KeyFactory).Hash;
                            break;
                        }
                    case "file":
                        {
                            MessageFactory.FileMessage = MessageFactory.CipheredFileMessage.DecryptFile(KeyFactory);
                            HashComparer.DecryptedHash = MessageFactory.CipheredFileMessage.DecryptFile(KeyFactory).Hash;
                            break;
                        }
                    default: break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Brak wszystkich danych");
            }
        }
    }

    #endregion //Methods
}

