using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskBoardCore;
using TaskBoardWebApi.Board;

namespace TaskBoardWebApi.Hubs
{
    [HubName("TaskBoardHub")]
    public class TaskBoardHub : Hub
    {
        private readonly TaskBoard<HyperlinkerTask> _taskBoard;

        public TaskBoardHub() : this(TaskBoard<HyperlinkerTask>.Instance) { }

        public TaskBoardHub(TaskBoard<HyperlinkerTask> taskBoard)
        {
            _taskBoard = taskBoard;
        }

        /// <summary>
        /// Получить информацию о задаче
        /// </summary>
        /// <param name="taskId">Идентификатор задачи</param>
        /// <returns></returns>
        public TaskResultInfo GetTaskInfo(string taskId)
        {
            var task = _taskBoard.GetTask(taskId);

            return task != null ? new TaskResultInfo()
                            {
                                Id = task.Id,
                                StartedAt = task.RanAt,
                                Status = task.Status,
                                PathToDoc = task.Status == TaskStatus.Complete ? task.PathToDoc : null
                            }
                            :
                            null;
        }

        /// <summary>
        /// Добавить задачу на выполнение
        /// </summary>
        /// <param name="docId">Идентификатор документа</param>
        /// <returns></returns>
        public TaskInfo AddTask(int docId)
        {
            var task = _taskBoard.AddTask(docId);

            return task != null ? new TaskInfo()
                            {
                                Id = task.Id,
                                StartedAt = task.RanAt,
                                Status = task.Status
                            }
                            :
                            null;
        }
    }
}