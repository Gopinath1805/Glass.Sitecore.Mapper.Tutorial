using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glass.Sitecore.Mapper.Tutorial.Models;

namespace Glass.Sitecore.Mapper.Tutorial.layouts
{
    public partial class DemoLayout : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ISitecoreContext context = new SitecoreContext();

            DemoItem current = context.GetCurrentItem<DemoItem>();

            if (current.Drop != null)
            {
                string otherName = current.Drop.Name;
            }

        }
    }
}