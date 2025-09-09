using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Intermediate_Exercises.Exercises
{
    internal class WorkFlow
    {
        private readonly List<IActivity> _activities;
        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            if (activity == null)
            {
                throw new ArgumentNullException("The Activity is not Valied");
            }
            _activities.Add(activity);
        }
        public IEnumerable<IActivity> GetActivities()
        {
            {
                return _activities;
            }
        }
    }
}