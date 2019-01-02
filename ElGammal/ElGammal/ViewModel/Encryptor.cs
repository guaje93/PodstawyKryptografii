using Keys;
using Messages;
using System;

namespace ViewModel
{
    public static class Encryptor
    {
        #region Methods

        public static CipheredStringMessage EncryptString(this StringMessage stringMessage, KeyFactory keyFactory)
        {
            var hash = stringMessage.Hash ?? throw new NullReferenceException();
            var keyP = keyFactory?.PublicKeyP?.KeyValue ?? throw new NullReferenceException();
            var keyG = keyFactory?.PublicKeyG?.KeyValue ?? throw new NullReferenceException();
            var keyA = keyFactory?.PrivateKeyA?.KeyValue ?? throw new NullReferenceException();
            var keyH = keyFactory?.PublicKeyH?.KeyValue ?? throw new NullReferenceException();
            var keyR = keyFactory?.RandomKeyR?.KeyValue ?? throw new NullReferenceException();
            var cipheredStringMessage = new CipheredStringMessage();
            var Message = new BigInteger(stringMessage.Hash);
            cipheredStringMessage.HashC1 = (keyG.modPow(keyR, keyP))
                .getBytes();
            cipheredStringMessage.HashC2 = (Message * keyH.modPow(keyR, keyP))
                .getBytes();
            return cipheredStringMessage;
        }

        public static CipheredFileMessage EncryptFile(this FileMessage stringMessage, KeyFactory keyFactory)
        {
            var hash = stringMessage.Hash ?? throw new NullReferenceException();
            var keyP = keyFactory?.PublicKeyP?.KeyValue ?? throw new NullReferenceException();
            var keyG = keyFactory?.PublicKeyG?.KeyValue ?? throw new NullReferenceException();
            var keyA = keyFactory?.PrivateKeyA?.KeyValue ?? throw new NullReferenceException();
            var keyH = keyFactory?.PublicKeyH?.KeyValue ?? throw new NullReferenceException();
            var keyR = keyFactory?.RandomKeyR?.KeyValue ?? throw new NullReferenceException();

            var cipheredFileMessage = new CipheredFileMessage();
            var CipheredSFileMessageC1 = new BigInteger(0);
            var CipheredSFileMessageC2 = new BigInteger(0);


            BigInteger buffer = new BigInteger(hash);
            cipheredFileMessage.HashC1 = (keyG.modPow(keyR, keyP))
                .getBytes();
            cipheredFileMessage.HashC2 = (buffer * keyH.modPow(keyR, keyP))
                .getBytes();
            return cipheredFileMessage;
        }

        #endregion //Methods
    }
}
