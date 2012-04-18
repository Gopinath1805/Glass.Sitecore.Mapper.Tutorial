using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Glass.Sitecore.Mapper.Tutorial.Rules.AssignToWorkflow
{
    public class AssignToWorkflowAction<T> : global::Sitecore.Rules.Actions.RuleAction<T>
    where T : global::Sitecore.Rules.RuleContext
    {

        public string WorkflowId { get; set; }
        public string WorkflowStateId { get; set; }

        public override void Apply(T ruleContext)
        {
            var item = ruleContext.Item;

            ISitecoreService service = new SitecoreService(item.Database);

            //read the passed in item to a class
            var targetItem = service.CreateClass<TargetItem>(false, false, item);

            Apply(service, targetItem);

            using (new global::Sitecore.SecurityModel.SecurityDisabler())
            {
                using (new global::Sitecore.Data.Items.EditContext(item))
                {
                    using (new global::Sitecore.Data.Events.EventDisabler())
                    {
                        service.WriteToItem(targetItem, item);

                    }
                }
            }
            //write back changes to the item



        }

        /// <summary>
        /// This method is Unit Testable
        /// </summary>     
        public void Apply(ISitecoreService service, TargetItem item)
        {

            //if the item has a workflow then don't assign it a new one
            if (item.Workflow != null) return;

            Workflow workflow = service.GetItem<Workflow>(new Guid(WorkflowId));
            
            if (workflow == null)
                throw new NullReferenceException("Could not find workflow with item ID {0}".Formatted(WorkflowId));

            WorkflowState state = workflow.States.FirstOrDefault(x => x.Id == new Guid(WorkflowStateId));

            if(state == null)
                throw new NullReferenceException("Could not find workflow with item ID {0}".Formatted(WorkflowId));

            item.Workflow = workflow;
            item.WorkflowState = state;
            
        }

    }
}