using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    public class WorkItem
    {
        private static int currentID;
        protected int ID {  get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }
        public WorkItem() 
        {
            ID = 0;
            Title = "Default title";
            Description = "Default description.";
            jobLength = new TimeSpan();
        }
        public WorkItem(string title, string description, TimeSpan jobLength)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = description;
            this.jobLength = jobLength;
        }
        static WorkItem() => currentID = 0;
        protected int GetNextID() => ++currentID;
        
        public void Update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.jobLength = joblen;
        }
        public override string ToString() => $"{this.ID} - {this.Title}";
    }

    public class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }
        public ChangeRequest() { }
        public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description= desc;
            this.jobLength = jobLen;
            this.originalItemID = originalID;
        }
    }
}
