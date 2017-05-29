using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore
{
    public class HyperlinkerTask : ITask
    {
        private TaskStatus _status;
        private DateTime _createdAt;
        private DateTime _runningAt;
        private readonly string _id;

        /// <summary>
        /// Конструктор
        /// </summary>
        public HyperlinkerTask()
        {
            _id = GenerateGuid();
            _status = TaskStatus.Preparing;
            _createdAt = DateTime.Now;
        }

        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        public string Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Статус задачи
        /// </summary>
        public TaskStatus Status
        {
            get
            {
                return _status;
            }
        }

        /// <summary>
        /// Время создания задачи
        /// </summary>
        public DateTime CreatedAt
        {
            get
            {
                return _createdAt;
            }
        }

        /// <summary>
        /// Выполнить задачу
        /// </summary>
        /// <returns></returns>
        public Task Execute()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Сгенерировать идентификатор 
        /// </summary>
        private string GenerateGuid() => Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", string.Empty).Replace("+", string.Empty);
    }
}
