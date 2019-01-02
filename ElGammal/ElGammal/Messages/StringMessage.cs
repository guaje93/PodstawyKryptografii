namespace Messages
{
    public class StringMessage : Message
    {
        #region Fields

        private byte[] _hash;

        #endregion //Fields

        #region Properties

        public byte[] Hash
        {
            get => _hash;
            set
            {
                _hash = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties

        #region Constructors
        public StringMessage(byte[] byteArray)
        {
            Hash = byteArray;
        }

        public StringMessage()
        {
        }
    }
    #endregion //Constructors
}
