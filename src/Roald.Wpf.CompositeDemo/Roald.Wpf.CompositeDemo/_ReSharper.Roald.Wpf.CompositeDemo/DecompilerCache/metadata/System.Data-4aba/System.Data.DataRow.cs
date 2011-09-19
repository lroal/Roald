// Type: System.Data.DataRow
// Assembly: System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Data.dll

using System.ComponentModel;

namespace System.Data
{
    public class DataRow
    {
        protected internal DataRow(DataRowBuilder builder);
        public string RowError { get; set; }
        public DataRowState RowState { get; }
        public DataTable Table { get; }
        public object this[int columnIndex] { get; set; }
        public object this[string columnName] { get; set; }
        public object this[DataColumn column] { get; set; }
        public object this[int columnIndex, DataRowVersion version] { get; }
        public object this[string columnName, DataRowVersion version] { get; }
        public object this[DataColumn column, DataRowVersion version] { get; }
        public object[] ItemArray { get; set; }
        public bool HasErrors { get; }
        public void AcceptChanges();

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void BeginEdit();

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void CancelEdit();

        public void Delete();

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void EndEdit();

        public void SetColumnError(int columnIndex, string error);
        public void SetColumnError(string columnName, string error);
        public void SetColumnError(DataColumn column, string error);
        public string GetColumnError(int columnIndex);
        public string GetColumnError(string columnName);
        public string GetColumnError(DataColumn column);
        public void ClearErrors();
        public DataColumn[] GetColumnsInError();
        public DataRow[] GetChildRows(string relationName);
        public DataRow[] GetChildRows(string relationName, DataRowVersion version);
        public DataRow[] GetChildRows(DataRelation relation);
        public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version);
        public DataRow GetParentRow(string relationName);
        public DataRow GetParentRow(string relationName, DataRowVersion version);
        public DataRow GetParentRow(DataRelation relation);
        public DataRow GetParentRow(DataRelation relation, DataRowVersion version);
        public DataRow[] GetParentRows(string relationName);
        public DataRow[] GetParentRows(string relationName, DataRowVersion version);
        public DataRow[] GetParentRows(DataRelation relation);
        public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version);
        public bool HasVersion(DataRowVersion version);
        public bool IsNull(int columnIndex);
        public bool IsNull(string columnName);
        public bool IsNull(DataColumn column);
        public bool IsNull(DataColumn column, DataRowVersion version);
        public void RejectChanges();
        protected void SetNull(DataColumn column);
        public void SetParentRow(DataRow parentRow);
        public void SetParentRow(DataRow parentRow, DataRelation relation);
        public void SetAdded();
        public void SetModified();
    }
}
