using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore
{
    public interface ITask
    {
        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        string Id
        {
            get;
        }

        /// <summary>
        /// Идентификатор документа
        /// </summary>
        int DocId
        {
            get;
        }

        /// <summary>
        /// Статус задачи
        /// </summary>
        TaskStatus Status
        {
            get;
        }

        /// <summary>
        /// Время создания задачи
        /// </summary>
        DateTime CreatedAt
        {
            get;
        }

        /// <summary>
        /// Время запуска задачи
        /// </summary>
        DateTime RanAt
        {
            get;
        }

        Task<int> Start();
    }
}
