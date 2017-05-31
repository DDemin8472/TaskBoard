using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskBoardCore;
using Newtonsoft.Json;

namespace TaskBoardWebApi.Board
{
    /// <summary>
    /// Информация о задаче
    /// </summary>
    public class TaskInfo
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonProperty("Id")]
        public string Id
        {
            get;
            set;
        }
        
        /// <summary>
        /// Время старта задачи
        /// </summary>
        [JsonProperty("StartedAt")]
        public DateTime StartedAt
        {
            get;
            set;
        }

        /// <summary>
        /// Статут задачи
        /// </summary>
        [JsonProperty("Status")]
        public TaskStatus Status
        {
            get;
            set;
        }
    }
}