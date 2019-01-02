using System;

namespace Keys
{
    public class PublicKeyG : Key
    {
        #region Properties

        public PublicKeyP PublicKeyP
        {
            get;
            private set;
        }

        #endregion //Properties

        #region Constructors

        public PublicKeyG(PublicKeyP publicKeyP)
        {
            PublicKeyP = publicKeyP ?? throw new NullReferenceException();
            GenerateKeyValue();
        }
        public PublicKeyG(byte [] byteArray) : base(byteArray)
        {
        }

        #endregion //Constructors

        #region Methods

        public override void GenerateKeyValue()
        {
            Random random = new Random();
            BigInteger privateKeyAValue;
            do
                privateKeyAValue = BigInteger.genPseudoPrime(BITLENGTH, 10, random);
            while (1 <= privateKeyAValue && privateKeyAValue >= PublicKeyP.KeyValue - 1);
            this.KeyValue = privateKeyAValue;
        }

        #endregion //Methods
    }
}
