using System;
using System.Collections.Generic;
using System.Data;

namespace DesignPatterns.Adapter.Real
{
    public class PatternCollectionDbDataAdapter : IDbDataAdapter
    {
        private readonly IEnumerable<Pattern> patterns;

        public PatternCollectionDbDataAdapter(IEnumerable<Pattern> patterns)
        {
            this.patterns = patterns;
        }

        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

            foreach (var pattern in patterns)
            {
                var myRow = myDataTable.NewRow();
                myRow[0] = pattern.Id;
                myRow[1] = pattern.Name;
                myRow[2] = pattern.Description;
                myDataTable.Rows.Add(myRow);
            }
            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();

            return myDataTable.Rows.Count;
        }

        #region NotImplemented
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

        public ITableMappingCollection TableMappings
        {
            get { throw new NotImplementedException(); }
        }

        public IDbCommand SelectCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand InsertCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand UpdateCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand DeleteCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        #endregion
    }
}
