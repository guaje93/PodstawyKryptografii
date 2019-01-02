using System;

namespace Keys
{
    public class PrivateKeyA : Key
    {
        #region Properties

        public PublicKeyP PublicKeyP
        {
            get;
            private set;
        }

        #endregion //Properties

        #region Constructors

        public PrivateKeyA(PublicKeyP publicKeyP)
        {
            PublicKeyP = publicKeyP  ?? throw new NullReferenceException();
            GenerateKeyValue();
        }

        public PrivateKeyA(byte[] byteArray) : base(byteArray)
        {
        }

        #endregion //Constructors

        #region Methods

        public override void GenerateKeyValue()
        {
            Random random = new Random();
            do
                KeyValue = BigInteger.genPseudoPrime(BITLENGTH, 10, random);
            while (1 <= KeyValue && KeyValue >= PublicKeyP.KeyValue - 1);
        }

        #endregion //Methods
    }
}
