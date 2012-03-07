using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glass.Sitecore.Mapper.Tutorial.Models;

namespace Glass.Sitecore.Mapper.Tutorial.layouts
{
    public partial class GlassTutorial1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ISitecoreContext context = new SitecoreContext();
            var home = context.GetCurrentItem<Home>();

            Title.Text = home.Title;
            Text.Text = home.Text;
            CreateBy.Text = home.CreatedBy;
            CreatedOn.Text = home.Created.ToShortDateString();
            Path.Text = home.Path;
        }
    }
}