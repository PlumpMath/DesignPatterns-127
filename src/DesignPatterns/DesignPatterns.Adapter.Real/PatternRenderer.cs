using System.Collections.Generic;

namespace DesignPatterns.Adapter.Real
{
    public class PatternRenderer
    {
        private readonly IPatternRendererAdapter patternRendererAdapter;

        public PatternRenderer()
            :this(new PatternRendererAdapter())
        {
        }

        public PatternRenderer(IPatternRendererAdapter patternRendererAdapter)
        {
            this.patternRendererAdapter = patternRendererAdapter;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return patternRendererAdapter.ListPatterns(patterns);
        }
    }
}
