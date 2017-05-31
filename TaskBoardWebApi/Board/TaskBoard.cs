using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskBoardCore;
using TaskBoardWebApi.Hubs;

namespace TaskBoardWebApi.Board
{
    public class TaskBoard<T> where T : ITask
    {
        // Singleton instance
        private readonly static Lazy<TaskBoard<T>> _instance = new Lazy<TaskBoard<T>>(() => new TaskBoard<T>(GlobalHost.ConnectionManager.GetHubContext<TaskBoardHub>().Clients));

        private readonly ConcurrentDictionary<string, T> _board = new ConcurrentDictionary<string, T>();

        private TaskBoard(IHubConnectionContext<dynamic> clients)
        {

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
            _board.TryGetValue(taskId, out T hyperlinkerTask);

            return hyperlinkerTask != null ? hyperlinkerTask : default(T);
        }

        public T AddTask(int docId)
        {
            throw new NotImplementedException();
        }
    }
}