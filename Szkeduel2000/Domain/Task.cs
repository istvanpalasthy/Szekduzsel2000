using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szkeduel2000.Domain
{
    public class Task
    {
        int taskId;
        string taskTitle;
        string taskDescription;
        string imgUrl;
        
        public Task()
        {
        }
        public Task(int taskId,string taskTitle, string taskDescription, string imgUrl)
        {
            this.taskId = taskId;
            this.taskTitle = taskTitle;
            this.taskDescription = taskDescription;
            this.imgUrl = imgUrl;
        }
    }
}
