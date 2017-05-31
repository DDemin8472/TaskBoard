using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskBoardWebApi.Board
{
    public class TaskResultInfo : TaskInfo
    {
        /// <summary>
        /// Путь до обработанного документа
        /// </summary>
        [JsonProperty("Path")]
        public string PathToDoc
        {
            get;
            set;
        }
    }
}