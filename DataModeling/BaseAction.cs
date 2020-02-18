using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.DataModeling
{
    public class BaseAction
    {
        public string ActionType { get; set; }

        public BaseAction(string actionType)
        {
            this.ActionType = actionType;
        }
    }
}
