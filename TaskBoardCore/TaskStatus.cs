using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore
{
    /// <summary>
    /// Состояние задачи
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>
        /// Подготовка к запуску
        /// </summary>
        Preparing = 0,

        /// <summary>
        /// Запущено
        /// </summary>
        Running = 1,

        /// <summary>
        /// Выполнено
        /// </summary>
        Complete = 2,

        /// <summary>
        /// Ошибка
        /// </summary>
        Error = 3
    }
}
