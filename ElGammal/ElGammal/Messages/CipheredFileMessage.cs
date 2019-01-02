namespace Messages
{
    public class CipheredFileMessage : Message
    {
        #region Fields

        private byte[] _hashC1;
        private byte[] _hashC2;

        #endregion //Fields

        #region Properties

        public byte[] HashC1
        {
            get => _hashC1;
            set
            {
                _hashC1 = value;
                OnPropertyChanged();
            }
        }
        public byte[] HashC2
        {
            get => _hashC2;

            set
            {
                _hashC2 = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties
    }
}
