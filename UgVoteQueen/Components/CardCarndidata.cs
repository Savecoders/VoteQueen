using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgVoteQueen.Views.Components
{
    public partial class CardCarndidata : Component
    {
        public CardCarndidata()
        {
            InitializeComponent();
        }

        public CardCarndidata(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
