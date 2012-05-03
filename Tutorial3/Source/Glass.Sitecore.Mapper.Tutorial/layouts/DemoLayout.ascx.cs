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
           

        }

        public void DropRead()
        {
            ISitecoreContext context = new SitecoreContext();

            DemoItem current = context.GetCurrentItem<DemoItem>();

            if (current.Drop != null)
            {
                string otherName = current.Drop.Name;
            }
        }

        public void DropSave()
        {
            ISitecoreContext context = new SitecoreContext();

            DemoItem current = context.GetCurrentItem<DemoItem>();
            OtherItem other = context.GetItem<OtherItem>("/sitecore/content/home/someOtherItem");

            current.Drop = other;

            context.Save(current);
        }

        public void  MultiTreeRead()
        {
            ISitecoreContext context = new SitecoreContext();

            DemoItem current = context.GetCurrentItem<DemoItem>();

            foreach (OtherItem other in current.Multi)
            {
                string title = other.Title;
            }

            foreach (OtherItem other in current.Tree)
            {
                string title = other.Title;
            }
        }

        public void MultiTreeRead()
        {
            ISitecoreContext context = new SitecoreContext();

            DemoItem current = context.GetCurrentItem<DemoItem>();

            OtherItem forRemoval = current.Multi.First();

            current.Multi.Remove(forRemoval);

            OtherItem toAdd = context.GetItem<OtherItem>("/sitecore/content/home/someOtherItem");

            current.Multi.Add(toAdd);

            context.Save(current);

        }
    }
}