using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views.Common
{
    public class Utils
    {

        public void ReplacePanelContent(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

    }
}
