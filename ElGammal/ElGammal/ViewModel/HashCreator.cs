using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace ViewModel
{
    public class HashCreator
    {
        #region Fields

        private OriginalMessageFactory _originalMessageFactory;
        private MessageFactory _messageFactory;

        #endregion //Fields

        #region Properties

        public OriginalMessageFactory OriginalMessageFactory
        {
            get => _originalMessageFactory;
            set => _originalMessageFactory = value;
        }
        public MessageFactory MessageFactory
        {
            get => _messageFactory;
            set => _messageFactory = value;
        }

        #endregion //Properties

        #region Constructors

        public HashCreator(OriginalMessageFactory originalMessageFactory, MessageFactory messageFactory)
        {
            OriginalMessageFactory = originalMessageFactory;
            MessageFactory = messageFactory;
        }

        #endregion //Constructors

        #region Methods

        public void Hash(string parameter)
        {
            try
            {
                switch (parameter)
                {
                    case "HashString": HashString(); break;
                    case "HashFile": HashFile(); break;
                    default: break;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Brakuje wiadomości");
            }
        }

        private void HashString()
        {
            //https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/

            using (SHA256 sha256Hash = SHA256.Create())
            {
                var message = OriginalMessageFactory.OriginalStringMessage ?? throw new NullReferenceException();
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(message));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                MessageFactory.StringMessage.VisibleText = builder.ToString();
                MessageFactory.StringMessage.Hash = Encoding.ASCII.GetBytes(MessageFactory.StringMessage.VisibleText);
            }
        }

        private void HashFile()
        {
            //https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/

            using (SHA256 sha256Hash = SHA256.Create())
            {
                var message = OriginalMessageFactory.OriginalFileMessage ?? throw new NullReferenceException();
                MessageFactory.FileMessage.Hash = sha256Hash.ComputeHash(message);
                MessageFactory.FileMessage.VisibleText = "Skrót gotowy do zapisu";
            }
        }

        #endregion //Methods
    }
}
