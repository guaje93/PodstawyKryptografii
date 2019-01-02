using Keys;
using Messages;
using System;
using System.Windows;

namespace ViewModel
{
    public class LoadFromFileFactory
    {
        #region Fields

        private KeyFactory _keyFactory;
        private CipheredFileMessage _cipheredFileMessage;
        private FileMessage _fileMessage;
        private OriginalMessageFactory _originalMessageFactory;
        private HashComparer _hashComparer;

        #endregion //Fields

        #region Properties

        public KeyFactory KeyFactory
        {
            get => _keyFactory;
            set => _keyFactory = value;
        }

        public CipheredFileMessage CipheredFileMessage
        {
            get => _cipheredFileMessage;
            set => _cipheredFileMessage = value;
        }

        public FileMessage FileMessage
        {
            get => _fileMessage;
            set => _fileMessage = value;
        }
        public OriginalMessageFactory OriginalMessageFactory
        {
            get => _originalMessageFactory;
            set => _originalMessageFactory = value;
        }
        public HashComparer HashComparer
        {
            get => _hashComparer;
            set => _hashComparer = value;
        }

        #endregion //Properties

        #region Constructors

        public LoadFromFileFactory(KeyFactory keyFactory, MessageFactory messageFactory, OriginalMessageFactory originalMessageFactory, HashComparer hashComparer)
        {
            KeyFactory = keyFactory;
            CipheredFileMessage = messageFactory.CipheredFileMessage;
            FileMessage = messageFactory.FileMessage;
            OriginalMessageFactory = originalMessageFactory;
            HashComparer = hashComparer;
        }

        #endregion //Constructors

        #region Methods

        public void Load(string parameter)
        {
            try
            {
                switch (parameter)
                {
                    case "KeyA": KeyFactory.PrivateKeyA = new PrivateKeyA(FileLoader.LoadFile()); break;
                    case "KeyG": KeyFactory.PublicKeyG = new PublicKeyG(FileLoader.LoadFile()); break;
                    case "KeyH": KeyFactory.PublicKeyH = new PublicKeyH(FileLoader.LoadFile()); break;
                    case "KeyP": KeyFactory.PublicKeyP = new PublicKeyP(FileLoader.LoadFile()); break;
                    case "KeyR": KeyFactory.RandomKeyR = new RandomKeyR(FileLoader.LoadFile()); break;
                    case "FileMessage":
                        {
                            OriginalMessageFactory.OriginalFileMessage = FileLoader.LoadFile();
                            OriginalMessageFactory.OperationStatus = "Plik został wczytany";
                            break;
                        }
                    case "Hash": FileMessage.Hash = FileLoader.LoadFile(); break;
                    case "C1": CipheredFileMessage.HashC1 = FileLoader.LoadFile(); break;
                    case "C2": CipheredFileMessage.HashC2 = FileLoader.LoadFile(); break;
                    case "Comparer": HashComparer.OriginalHash = FileLoader.LoadFile(); break;

                    default: new ArgumentException(); break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nic nie wczytano");
            }

            #endregion //Methods
        }
    }
}
