using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatterns.Adapter.Real.Tests
{
    public class PatternRendererShould
    {
        private readonly ITestOutputHelper output;

        public PatternRendererShould(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void render_two_patterns()
        {
            var patternRenderer = new PatternRenderer();

            var list = new List<Pattern>
            {
                new Pattern {Id = 1, Name = "Pattern One", Description = "Pattern One Description"},
                new Pattern {Id = 2, Name = "Pattern Two", Description = "Pattern Two Description"}
            };

            string result = patternRenderer.ListPatterns(list);
            output.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            lineCount.ShouldBe(list.Count + 2);
        }
    }
}
