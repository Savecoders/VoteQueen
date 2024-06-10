using UgVoteQueen.Common;
using UgVoteQueen.PL.Session;

namespace UgVoteQueen.PL
{
    public partial class WinSession : Form
    {
        private Utils utils = new();
        private static WinSession _instance;
        private Login LoginPanel = new();
        private Register RegisterPanel = new();

        public static WinSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WinSession();
                }
                return _instance;
            }
        }

        public WinSession()
        {
            InitializeComponent();
            LoginPanel.SetPanels(PanelPrincipal, RegisterPanel);
            RegisterPanel.SetPanels(PanelPrincipal, LoginPanel);
            utils.ReplacePanelContent(PanelPrincipal, LoginPanel);
        }
    }
}
