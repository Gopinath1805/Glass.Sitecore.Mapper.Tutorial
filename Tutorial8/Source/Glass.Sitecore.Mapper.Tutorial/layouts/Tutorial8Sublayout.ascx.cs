using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glass.Sitecore.Mapper.Web.Ui;
using Glass.Sitecore.Mapper.Tutorial.Models;

namespace Glass.Sitecore.Mapper.Tutorial.layouts
{
    public partial class Tutorial8Sublayout : GlassUserControl<Tutorial8Item>
    {
        protected override void OnLoad(EventArgs e)
        {
            string titlePrefix = "Title prefix ";

            Model = SitecoreContext.GetCurrentItem<Tutorial8Item, string>(titlePrefix);
        }
    }
}