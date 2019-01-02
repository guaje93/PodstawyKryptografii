using System;

namespace Keys
{
    public class PublicKeyP : Key
    {
        #region Constructors

        public PublicKeyP()
        {
            GenerateKeyValue();
        }

        public PublicKeyP(byte[] byteArray) : base(byteArray)
        {
        }

        #endregion //Constructors

        #region Methods

        public override void GenerateKeyValue()
        {
            Random random = new Random();
            KeyValue = BigInteger.genPseudoPrime(BITLENGTH, 10, random);
        }

        #endregion //Methods
    }
}
