using Keys;
using Messages;
using System;
using System.Linq;
using System.Text;

namespace ViewModel
{
    public static class Decryptor
    {
        #region Methods

        public static FileMessage DecryptFile(this CipheredFileMessage cipheredFileMessage, KeyFactory keyFactory)
        {
            var c1 = cipheredFileMessage.HashC1 ?? throw new NullReferenceException();
            var c2 = cipheredFileMessage.HashC2 ?? throw new NullReferenceException();
            var keyA = keyFactory?.PrivateKeyA?.KeyValue ?? throw new NullReferenceException();
            var keyP = keyFactory?.PublicKeyP?.KeyValue ?? throw new NullReferenceException();


            var fileMessage = new FileMessage();
            BigInteger DecryptedFileNum = new BigInteger(0);
            BigInteger bufferC1 = new BigInteger(c1);
            BigInteger bufferC2 = new BigInteger(c2);
            DecryptedFileNum = (bufferC2 * 1 / bufferC1.modPow(keyA, keyP));
            fileMessage.Hash = DecryptedFileNum.getBytes().ToArray();
            return fileMessage;
        }

        public static StringMessage DecryptString(this CipheredStringMessage cipheredStringMessage, KeyFactory keyFactory)
        {
            var c1 = cipheredStringMessage.HashC1 ?? throw new NullReferenceException();
            var c2 = cipheredStringMessage.HashC2 ?? throw new NullReferenceException();
            var keyA = keyFactory?.PrivateKeyA?.KeyValue ?? throw new NullReferenceException();
            var keyP = keyFactory?.PublicKeyP?.KeyValue ?? throw new NullReferenceException();

            var stringMessage = new StringMessage();
            BigInteger DecryptedFileNum = new BigInteger(0);
            BigInteger bufferC1 = new BigInteger(c1);
            BigInteger bufferC2 = new BigInteger(c2);
            DecryptedFileNum = (bufferC2 * 1 / bufferC1.modPow(keyA, keyP));
            stringMessage.Hash = DecryptedFileNum.getBytes();
            stringMessage.VisibleText = Encoding.ASCII.GetString(stringMessage.Hash);
            return stringMessage;
        }

        #endregion //Methods
    }
}
