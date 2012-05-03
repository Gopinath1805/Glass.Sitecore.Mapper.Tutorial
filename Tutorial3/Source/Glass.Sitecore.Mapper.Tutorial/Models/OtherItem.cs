using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Models
{
    [SitecoreClass]
    public class OtherItem
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField]
        public virtual string Title { get; set; }

        [SitecoreInfo(Configuration.SitecoreInfoType.Name)]
        public virtual string Name { get; set; }
    }
}