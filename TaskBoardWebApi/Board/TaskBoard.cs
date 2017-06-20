using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskBoardCore;
using TaskBoardCore.Pipeline;
using TaskBoardWebApi.Hubs;

namespace TaskBoardWebApi.Board
{
    public class TaskBoard<T> where T : ITask
    {
        // Singleton instance
        private readonly static Lazy<TaskBoard<T>> _instance = new Lazy<TaskBoard<T>>(() => new TaskBoard<T>(GlobalHost.ConnectionManager.GetHubContext<TaskBoardHub>().Clients, 4));
        
        private readonly TaskPipeline _pipeline;

        private TaskBoard(IHubConnectionContext<dynamic> clients, int pipelineCapacity )
        {
            _pipeline = new TaskPipeline ( pipelineCapacity );
        }

        public static TaskBoard<T> Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public T GetTask(string taskId)
        {
            throw new NotImplementedException ();
        }

        public T AddTask(T task)
        {
            throw new NotImplementedException ();
        }
    }
}