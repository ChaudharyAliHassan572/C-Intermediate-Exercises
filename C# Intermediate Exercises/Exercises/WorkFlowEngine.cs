using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Intermediate_Exercises.Exercises
{
    internal class WorkFlowEngine
    {
        public void Run(WorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
            {
                activity.Execute();
            }
        }

    }
}
