using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfValue
{
    public abstract class WorkData : IPrint, IComparable<WorkData>
    {
        private int code;
        private string type;

       
        public WorkData(int code, string type)
        {
            Code = code;
            Type = type;
        }

       
        public int Code
        {
            get { return code; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Your code should be positive number!");
                }
                code = value;
            }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int CompareTo(WorkData other) 
        {
            return Code.CompareTo(other.Code);
        }

        public virtual void Print() { }
    }
}
