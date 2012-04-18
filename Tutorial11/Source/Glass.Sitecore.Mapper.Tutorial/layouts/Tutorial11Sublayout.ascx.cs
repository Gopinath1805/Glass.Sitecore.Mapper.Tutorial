using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glass.Sitecore.Mapper.Tutorial.Models;
using Glass.Sitecore.Mapper.Web.Ui;

namespace Glass.Sitecore.Mapper.Tutorial.layouts
{
    public partial class Tutorial11Sublayout : GlassUserControl<Tutorial11Item>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
           var home =  SitecoreContext.GetItem<Tutorial11Item>("/sitecore/content/home");
           Model = home;
        }
    }
}