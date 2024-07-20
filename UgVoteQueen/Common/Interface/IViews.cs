using System;

namespace Views.Common.Interface
{

    public interface IView
    {
        void ModelChange(object sender, EventArgs e);
    }

}