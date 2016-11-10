using System.Data;
using System.IO;

namespace DesignPatterns.Adapter.Real
{
    public class DataRenderer
    {
        private readonly IDbDataAdapter dataAdapter;

        public DataRenderer(IDbDataAdapter dataAdapter)
        {
            this.dataAdapter = dataAdapter;
        }

        public void Render(TextWriter writer)
        {
            writer.WriteLine("Rendering data:");
            var dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write(column.ColumnName.PadRight(20) + " ");
                }
                writer.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        writer.Write(row[i].ToString().PadRight(20) + " ");
                    }
                    writer.WriteLine();
                }
                
            }
        }
    }
}
