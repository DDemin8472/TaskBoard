﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore.Pipeline
{
    public class TaskPipeline<T>
    {
        private const int defaultPipelineCapacity = 5;
        private readonly ConcurrentDictionary<string, T> _workedPipeline;
        private readonly ConcurrentDictionary<string, T> _waitedPipeline;
        private int _pipelineBlockCount;

        public TaskPipeline() : this( defaultPipelineCapacity ) { }

        public TaskPipeline( int pipelineCapacity )
        {
            this._workedPipeline = new ConcurrentDictionary<string, T> ();
            this._waitedPipeline = new ConcurrentDictionary<string, T> ();

            this._pipelineBlockCount = pipelineCapacity;
        }
        
    }
}
