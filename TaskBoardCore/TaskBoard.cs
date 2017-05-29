using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore
{
    public class TaskBoard
    {
        private readonly ConcurrentDictionary<string, ITask> _board = new ConcurrentDictionary<string, ITask>();
    }
}
