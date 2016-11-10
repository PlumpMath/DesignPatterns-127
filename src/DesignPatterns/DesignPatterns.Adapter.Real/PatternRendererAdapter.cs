using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatterns.Adapter.Real
{
    public class PatternRendererAdapter : IPatternRendererAdapter
    {
        private DataRenderer dataRenderer;

        public PatternRendererAdapter()
        {
        }

        public PatternRendererAdapter(DataRenderer dataRenderer)
        {
            this.dataRenderer = dataRenderer;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            var dbDataAdapter = new PatternCollectionDbDataAdapter(patterns);
            dataRenderer = new DataRenderer(dbDataAdapter);
            
            var writer = new StringWriter();
            dataRenderer.Render(writer);

            return writer.ToString();
        }
    }
}
