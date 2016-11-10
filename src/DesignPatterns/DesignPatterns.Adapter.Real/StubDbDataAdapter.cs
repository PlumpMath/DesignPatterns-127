using System;
using System.Data;

namespace DesignPatterns.Adapter.Real
{
    public class StubDataAdapter : IDbDataAdapter
    {
        public int Fill(DataSet dataSet)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Description", typeof(string)));

            var dataRow = dataTable.NewRow();
            dataRow[0] = 1;
            dataRow[1] = "DbDataAdapter";
            dataRow[2] = "DbDataAdapter Description";
            dataTable.Rows.Add(dataRow);

            dataSet.Tables.Add(dataTable);
            dataSet.AcceptChanges();

            return 1;
        }

        #region NotImplemented

        public IDbCommand DeleteCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand InsertCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public MissingMappingAction MissingMappingAction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public MissingSchemaAction MissingSchemaAction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand SelectCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ITableMappingCollection TableMappings
        {
            get { throw new NotImplementedException(); }
        }

        public IDbCommand UpdateCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
