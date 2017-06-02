using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore
{
    public class HyperlinkerTask : ITask
    {
        private string _path;
        private TaskStatus _status;
        private DateTime _createdAt;
        private DateTime _ranAt;
        private readonly string _id;
        private readonly int _docId;

        #region Конструкторы

        /// <summary>
        /// Конструктор
        /// </summary>
        public HyperlinkerTask(int docId)
        {
            _docId = docId;
            _id = GenerateGuid();
            _status = TaskStatus.Preparing;
            _createdAt = DateTime.Now;
        }

        #endregion

        #region Свойства

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
        /// Идентификатор документа
        /// </summary>
        public int DocId
        {
            get
            {
                return _docId;
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
        /// Время запуска задачи
        /// </summary>
        public DateTime RanAt
        {
            get
            {
                return _ranAt;
            }
        }

        /// <summary>
        /// Путь до обработанного документа
        /// </summary>
        public string PathToDoc
        {
            get
            {
                return _path;
            }
        }

        #endregion

        #region Public методы

        public static HyperlinkerTask Create(int docId)
        {
            return new HyperlinkerTask(docId);
        }

        /// <summary>
        /// Запустить задачу
        /// </summary>
        /// <param name="docId">Идентификатор документа</param>
        public Task<int> Start()
        {
            _status = TaskStatus.Running;
            _ranAt = DateTime.Now;

            try
            {
                return Execute(_docId);
            }
            catch (InvalidOperationException)
            {
                _status = TaskStatus.Error;
                return null;
            }
        }

        #endregion

        #region Private методы

        /// <summary>
        /// Выполнить задачу
        /// </summary>
        /// <param name="docId">Идентификатор документа</param>
        private async Task<int> Execute(int docId)
        {
            Random rnd = new Random();
            int delayTimeInterval = rnd.Next(1, 10);

            await Task.Delay(delayTimeInterval);

            _status = TaskStatus.Complete;
            return delayTimeInterval;
        }

        /// <summary>
        /// Сгенерировать идентификатор 
        /// </summary>
        private string GenerateGuid() => Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", string.Empty).Replace("+", string.Empty);

        #endregion
    }
}
