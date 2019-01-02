namespace Messages
{
    public class FileMessage : Message
    {
        #region Fields

        private byte[] _hash;

        #endregion //Fields

        #region Properties

        public byte[] Hash
        {
            get => _hash; set
            {
                _hash = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties

        #region Constructors

        public FileMessage(byte[] byteArray)
        {
            Hash = byteArray;
        }

        public FileMessage()
        {
        }

        #endregion //Constructors
    }
}
