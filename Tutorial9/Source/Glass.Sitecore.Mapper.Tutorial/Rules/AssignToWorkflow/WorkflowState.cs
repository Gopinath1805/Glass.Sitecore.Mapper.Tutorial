using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Rules.AssignToWorkflow
{
    [SitecoreClass]
    public class WorkflowState
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }
    }
}
