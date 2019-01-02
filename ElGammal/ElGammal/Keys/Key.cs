namespace Keys
{
    public class Key
    {
        #region Fields

        public const int BITLENGTH = 1024;
        private BigInteger _keyValue;

        #endregion //Fields

        #region Properties

        public BigInteger KeyValue
        {
            get => _keyValue;
            set
            {
                _keyValue = value;
            }
        }

        #endregion //Properties

        #region Constructors

        public Key(byte[] byteArray)
        {
            KeyValue = new BigInteger(byteArray);
        }

        public Key()
        {

        }
        #endregion //Constructors

        #region Methods
        public virtual void GenerateKeyValue() { }
        public byte[] GetBytes() => KeyValue.getBytes();

        #endregion //Methods
    }
}
