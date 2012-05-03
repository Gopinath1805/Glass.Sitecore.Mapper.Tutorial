using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Models
{
    [SitecoreClass]
    public class DemoItem
    {
        [SitecoreField]
        public virtual OtherItem Drop { get; set; }

        [SitecoreField]
        public virtual IList<OtherItem> Multi { get; set; }

        [SitecoreField]
        public virtual IList<OtherItem> Tree { get; set; }
    }
}