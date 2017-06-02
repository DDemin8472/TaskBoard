using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Threading.Tasks;
using TaskBoardWebApi.Board;
using TaskBoardWebApi.Hubs;

namespace TaskBoardWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods:"*")]
    public class TaskBoardController : ApiController
    {

        [ActionName("TaskResult")]
        public async Task<TaskResultInfo> GetTaskResult(string taskId)
        {
            TaskBoardHub hub = new TaskBoardHub();

            return hub.GetTaskInfo(taskId);
        }

        [ActionName("AddTask")]
        public async Task<TaskInfo> AddTask(int docId)
        {
            TaskBoardHub hub = new TaskBoardHub();

            return hub.AddTask(docId);
        }
    }
}
