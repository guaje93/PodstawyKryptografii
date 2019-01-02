using System;

namespace Keys
{
    public class PublicKeyH : Key
    {
        #region Properties

        public PublicKeyP PublicKeyP
        {
            get;
            private set;
        }

        public PrivateKeyA PrivateKeyA
        {
            get;
            private set;
        }

        public PublicKeyG PublicKeyG
        {
            get;
            private set;
        }

        #endregion //Properties

        #region Constructors

        public PublicKeyH(PublicKeyP publicKeyP, PrivateKeyA privateKeyA, PublicKeyG publicKeyG)
        {
            PublicKeyP = publicKeyP ?? throw new NullReferenceException();
            PrivateKeyA = privateKeyA ?? throw new NullReferenceException();
            PublicKeyG = publicKeyG ?? throw new NullReferenceException();
            GenerateKeyValue();
        }

        public PublicKeyH(byte[] byteArray) : base(byteArray)
        {
        }

        #endregion //Constructors

        #region Methods
        public override void GenerateKeyValue()
        {
            KeyValue = PublicKeyG.KeyValue.modPow(PrivateKeyA.KeyValue, PublicKeyP.KeyValue);
        }

        #endregion //Methods
    }
}
