
namespace lands.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public LoginViewModel Login { get; set; }

        public LandsViewModel Lands
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        public static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }

        internal class GetInstance
        {
        }
        #endregion
    }
}
