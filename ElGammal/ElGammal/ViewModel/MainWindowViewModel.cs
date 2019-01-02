using System.Windows.Input;
using Utills;

namespace ViewModel
{
    public class MainWindowViewModel : BaseViewClass
    {
        #region Fields

        private ICommand _keyCommand;
        private ICommand _loadCommand;
        private ICommand _saveCommand;
        private ICommand _hashCommand;
        private ICommand _encryptCommand;
        private ICommand _decryptCommand;
        private ICommand _compareHashCommand;

        #endregion //Fields
        
        #region Commands
        public ICommand KeyCommand => _keyCommand ?? 
                                      (_keyCommand = new RelayCommand(args => ElGamalManager.KeyFactory.GenerateKey(args as string)));
        public ICommand LoadCommand => _loadCommand ?? 
                                      (_loadCommand = new RelayCommand(args => ElGamalManager.LoadFromFileFactory.Load(args as string)));
        public ICommand SaveCommand => _saveCommand ?? 
                                      (_saveCommand = new RelayCommand(args => ElGamalManager.SaveToFileFactory.Save(args as string)));
        public ICommand HashCommand => _hashCommand ?? 
                                      (_hashCommand = new RelayCommand(args => ElGamalManager.HashCreator.Hash(args as string)));
        public ICommand EncryptCommand => _encryptCommand ?? 
                                         (_encryptCommand = new RelayCommand(args => ElGamalManager.Encrypt(args as string)));
        public ICommand DecryptCommand => _decryptCommand ?? 
                                         (_decryptCommand = new RelayCommand(args => ElGamalManager.Decrypt(args as string)));

        public ICommand CompareHashCommand => _compareHashCommand ?? 
                                             (_compareHashCommand = new RelayCommand(Action => ElGamalManager.HashComparer.CompareHashes()));

        #endregion

        #region Properties

        public ElGamalManager ElGamalManager { get; set; }

        #endregion //Properties

        #region Constructors

        public MainWindowViewModel()
        {
            ElGamalManager = new ElGamalManager();
        }

        #endregion //Constructors
    }
}
