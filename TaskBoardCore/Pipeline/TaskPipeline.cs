using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore.Pipeline
{
    public class WorkedPipeline<T> where T : ITask
    {
        private const int defaultPipelineCapacity = 5;
        private readonly ConcurrentDictionary<string, T> _workedPipeline;
        private int _pipelineBlockCount;

        public WorkedPipeline() : this( defaultPipelineCapacity ) { }

        public WorkedPipeline( int pipelineCapacity )
        {
            this._workedPipeline = new ConcurrentDictionary<string, T> ();
            this._pipelineBlockCount = pipelineCapacity;
        }

        public string Add( T task )
        {
            throw new NotImplementedException ();
        }
    }
}
