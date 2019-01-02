using Utills;

namespace Messages
{
    public abstract class Message : BaseViewClass
    {
        #region Fields

        private string _visibleText;

        #endregion //Fields

        #region Properties
        public string VisibleText
        {
            get => _visibleText;
            set
            {
                _visibleText = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties
    }
}
