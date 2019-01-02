using System;
using System.Windows;
using Utills;

namespace Keys
{
    public class KeyFactory : BaseViewClass
    {
        #region Fields

        PublicKeyP _publicKeyP;
        PublicKeyG _publicKeyG;
        PublicKeyH _publicKeyH;
        PrivateKeyA _privateKeyA;
        RandomKeyR _randomKeyR;

        #endregion //Fields

        #region Properties

        public PublicKeyP PublicKeyP
        {
            get => _publicKeyP;
            set
            {
                _publicKeyP = value;
                OnPropertyChanged();
            }
        }
        public PublicKeyG PublicKeyG
        {
            get => _publicKeyG;
            set
            {
                _publicKeyG = value;
                OnPropertyChanged();
            }
        }
        public PublicKeyH PublicKeyH
        {
            get => _publicKeyH;
            set
            {
                _publicKeyH = value;
                OnPropertyChanged();
            }
        }
        public RandomKeyR RandomKeyR
        {
            get => _randomKeyR;
            set
            {
                _randomKeyR = value;
                OnPropertyChanged();
            }
        }
        public PrivateKeyA PrivateKeyA
        {
            get => _privateKeyA;
            set
            {
                _privateKeyA = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties

        #region Constructors
        public KeyFactory()
        {
        }

        #endregion //Constructors

        #region Methods

        public void GenerateKey(string parameter)
        {
            switch (parameter)
            {
                case "P": GeneratePublicKeyP(); break;
                case "G": GeneratePublicKeyG(); break;
                case "H": GeneratePublicKeyH(); break;
                case "A": GeneratePrivateKeyA(); break;
                case "R": GenerateKeyR(); break;
                default: throw new NullReferenceException(); 
            }
        }

        private void GeneratePublicKeyP()
        {
            PublicKeyP = new PublicKeyP();
        }

        private void GeneratePublicKeyG()
        {
            try
            {
                PublicKeyG = new PublicKeyG(PublicKeyP);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klucz publiczny P jest wymagany");
            }
        }

        private void GeneratePrivateKeyA()
        {
            try
            {
                PrivateKeyA = new PrivateKeyA(PublicKeyP);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klucz publiczny P jest wymagany");
            }
        }

        private void GenerateKeyR()
        {
            try
            {
                RandomKeyR = new RandomKeyR(PublicKeyP);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klucz publiczny P jest wymagany");
            }
        }

        private void GeneratePublicKeyH()
        {
            try
            {
                PublicKeyH = new PublicKeyH(PublicKeyP, PrivateKeyA, PublicKeyG);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klucz publiczny P jest wymagany");
            }
        }

        #endregion //Methods
    }
}
