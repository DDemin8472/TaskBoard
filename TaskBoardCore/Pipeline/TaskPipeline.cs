using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardCore.Pipeline
{
    public class TaskPipeline
    {
        private const int defaultPipelineCapacity = 5;
        private readonly HyperlinkerTask [] _pipeline;

        public TaskPipeline() : this( defaultPipelineCapacity ) { }

        public TaskPipeline( int pipelineCapacity )
        {
            _pipeline = new HyperlinkerTask [ pipelineCapacity ];
        }

        //public bool Add( HyperlinkerTask task )
        //{

        //}
    }
}
