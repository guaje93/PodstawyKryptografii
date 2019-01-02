using System;

namespace Keys
{
    public class RandomKeyR : Key
    {
        #region Properties

        public PublicKeyP PublicKeyP
        {
            get;
            private set;
        }

        #endregion //Properties

        #region Constructors

        public RandomKeyR(PublicKeyP publicKeyP)
        {
            PublicKeyP = publicKeyP ?? throw new NullReferenceException();
            GenerateKeyValue();
        }

        public RandomKeyR(byte [] byteArray) : base(byteArray)
        {
        }

        #endregion //Constructors

        #region Methods

        public override void GenerateKeyValue()
        {
            Random random = new Random();
            do
                KeyValue = BigInteger.genPseudoPrime(BITLENGTH, 10, random);
            while (1 < KeyValue && KeyValue > PublicKeyP.KeyValue - 1);
        }

        #endregion //Methods
    }
}
