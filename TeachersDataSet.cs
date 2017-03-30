using System.Data.SqlClient;

namespace TeacherStarterKit
{


    partial class TeachersDataSet
    {

    }
}

namespace TeacherStarterKit.TeachersDataSetTableAdapters
{
    partial class CourseStudentsTableAdapter
    {

        private SqlTransaction _transaction;

        public SqlTransaction AdapterTransaction
        {
            get
            {
                return _transaction;
            }
            set
            {

                this._transaction = value;
                //  configure the base commands

                if (!(this.Adapter.InsertCommand == null))
                {
                    this.Adapter.InsertCommand.Connection = _transaction.Connection;
                    this.Adapter.InsertCommand.Transaction = _transaction;
                }
                if (!(this.Adapter.UpdateCommand == null))
                {
                    this.Adapter.UpdateCommand.Connection = _transaction.Connection;
                    this.Adapter.UpdateCommand.Transaction = _transaction;
                }
                if (!(this.Adapter.DeleteCommand == null))
                {
                    this.Adapter.DeleteCommand.Connection = _transaction.Connection;
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                //  configure the user-defined commands
                foreach (SqlCommand cmd in this.CommandCollection)
                {
                    cmd.Connection = _transaction.Connection;
                    cmd.Transaction = this._transaction;
                }
            }
        }
    }
    // '' 
    // '' Add AdapterTransaction property to GradesTableAdapter to support Transactions
    // '' 
    // '' 
    partial class GradesTableAdapter
    {

        private System.Data.SqlClient.SqlTransaction _transaction;

        public System.Data.SqlClient.SqlTransaction AdapterTransaction
        {
            get
            {
                return _transaction;
            }
            set
            {

                this._transaction = value;
                //  configure the base commands
                if (!(this.Adapter.InsertCommand == null))
                {
                    this.Adapter.InsertCommand.Connection = _transaction.Connection;
                    this.Adapter.InsertCommand.Transaction = _transaction;
                }
                if (!(this.Adapter.UpdateCommand == null))
                {
                    this.Adapter.UpdateCommand.Connection = _transaction.Connection;
                    this.Adapter.UpdateCommand.Transaction = _transaction;
                }
                if (!(this.Adapter.DeleteCommand == null))
                {
                    this.Adapter.DeleteCommand.Connection = _transaction.Connection;
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                //  configure the user-defined commands
                foreach (SqlCommand cmd in this.CommandCollection)
                {
                    cmd.Connection = _transaction.Connection;
                    cmd.Transaction = this._transaction;
                }

            }
        }
    }
}