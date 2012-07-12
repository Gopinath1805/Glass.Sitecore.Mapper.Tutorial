using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.Configuration;
using Glass.Sitecore.Mapper.Tutorial.Templates.Base;

namespace Glass.Sitecore.Mapper.Tutorial.Templates
{
    [SitecoreClass(true, "{C76767E8-5D06-4968-9E04-390918B64825}")]
    public class News : ICommon
    {
        [SitecoreId]
        public Guid Id { get; set; }

        [SitecoreField("{0904A3E0-5EE8-46AE-90B7-66FED2EFBEA3}", SitecoreFieldType.DateTime, "Content", FieldTitle="Published Date")]
        public virtual DateTime PublishedDate { get; set; }

        [SitecoreField("{09B51FA5-CA7A-4F99-9EE5-F1509B57B9A3}", SitecoreFieldType.Checkbox, "Content", FieldTitle = "Featured News")]
        public virtual bool FeaturedNews { get; set; }


        public string Title
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }
    }
}