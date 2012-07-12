using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.Configuration;

namespace Glass.Sitecore.Mapper.Tutorial.Templates.Base
{
    [SitecoreClass(true, "{D63B4B64-69B9-433E-B666-7B575730F6DC}")]
    public interface ICommon
    {
        [SitecoreField("{69B4C639-9D9C-41F4-878E-17A26DCA5E9E}", SitecoreFieldType.SingleLineText, "Common")]
        string Title { get; set; }

        [SitecoreField("{F09FA9D9-E650-40BC-B933-3B58DB3F74DF}", SitecoreFieldType.RichText, "Common")]
        string Content { get; set; }
    }
}