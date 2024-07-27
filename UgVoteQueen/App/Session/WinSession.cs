using Views.Common;
using Views.App.Session;

namespace Views.App.Session
{
    public partial class WinSession : Form
    {
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
            Utils.ReplacePanelContent(PanelPrincipal, LoginPanel);
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
