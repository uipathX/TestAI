using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;

namespace TestAI
{
    public class Workflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
           var state = true;
            var test = "data";
        }
    }
}