using System.Collections.Generic;

namespace DesignPatterns.Adapter.Real
{
    public interface IPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}
