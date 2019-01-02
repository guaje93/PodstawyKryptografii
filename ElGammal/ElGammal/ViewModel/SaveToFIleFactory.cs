using Keys;
using System;
using System.Windows;

namespace ViewModel
{
    public class SaveToFileFactory
    {
        #region Fields

        private KeyFactory _keyFactory;
        private MessageFactory _messageFactory;

        #endregion //Fields

        #region Properties

        public KeyFactory KeyFactory
        {
            get => _keyFactory;
            set => _keyFactory = value;
        }
        public MessageFactory MessageFactory
        {
            get => _messageFactory;
            set => _messageFactory = value;
        }

        #endregion

        #region Constructors

        public SaveToFileFactory(KeyFactory keyFactory, MessageFactory messageFactory)
        {
            KeyFactory = keyFactory;
            MessageFactory = messageFactory;
        }

        #endregion //Constructors

        #region Methods

        public void Save(string parameter)
        {
            try
            {
                switch (parameter)
                {

                    case "KeyA": FileSaver.SaveToFile(KeyFactory.PrivateKeyA.GetBytes()); break;
                    case "KeyG": FileSaver.SaveToFile(KeyFactory.PublicKeyG.GetBytes()); break;
                    case "KeyH": FileSaver.SaveToFile(KeyFactory.PublicKeyH.GetBytes()); break;
                    case "KeyP": FileSaver.SaveToFile(KeyFactory.PublicKeyP.GetBytes()); break;
                    case "KeyR": FileSaver.SaveToFile(KeyFactory.RandomKeyR.GetBytes()); break;
                    case "HashFile": FileSaver.SaveToFile(MessageFactory.FileMessage.Hash); break;
                    case "HashString": FileSaver.SaveToFile(MessageFactory.StringMessage.Hash); break;
                    case "C1": FileSaver.SaveToFile(MessageFactory.CipheredFileMessage.HashC1); break;
                    case "C2": FileSaver.SaveToFile(MessageFactory.CipheredFileMessage.HashC2); break;

                    default: new ArgumentException(); break;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Brakuje wszystkich danych");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Puste pole do zapisu");
            }
        }

        #endregion //Methods
    }
}
