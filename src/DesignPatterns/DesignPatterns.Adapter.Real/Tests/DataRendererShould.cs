using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatterns.Adapter.Real.Tests
{
    public class DataRendererShould
    {
        private readonly ITestOutputHelper output;

        public DataRendererShould(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void render_one_row_given_a_StubDbDataAdapter()
        {
            var dataRenderer = new DataRenderer(new StubDataAdapter());

            var writer = new StringWriter();
            dataRenderer.Render(writer);

            string result = writer.ToString();
            output.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            lineCount.ShouldBe(3);
        }

        [Fact]
        public void render_two_rows_given_an_OleDbDataAdapter()
        {
            var sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM tbl_Pattern");
            sqlDataAdapter.SelectCommand.Connection = new SqlConnection(@"Data Source=(localdb)\LocalDBApp;Initial Catalog=Sample;Integrated Security=True");

            var dataRenderer = new DataRenderer(sqlDataAdapter);

            var writer = new StringWriter();
            dataRenderer.Render(writer);

            string result = writer.ToString();
            output.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            lineCount.ShouldBe(4);
        }
    }
}
