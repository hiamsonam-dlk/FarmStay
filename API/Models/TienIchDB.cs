using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace API.Models
{
    public class TienIchDB
    {

        public static Task<DataSet> ExecuteDataSetTask(string conString,
            string store,
            string[] thamso,
            object[] giatri,
            string[] cursors)
        {
            if (cursors == null)
                cursors = new string[] { "RSOUT" };
            Task<DataSet> task = Task.Run(() =>
            {
                return ExecuteDataSet(conString, store, thamso, giatri, cursors);
            });
            return task;
        }

        public static Task<DataTable> ExecuteDataTableTask(string conString,
            string store,
            string[] thamso,
            object[] giatri,
            string[] cursors = null)
        {
            if (cursors == null)
                cursors = new string[] { "RSOUT" };
            Task<DataTable> task = Task<DataTable>.Run(() =>
            {
                return ExecuteDataTable(conString, store, thamso, giatri, cursors);
            });
            return task;
        }

        public static Task<DataTable> ExecuteDataTableWithTypesTask(string conString,
            string store,
            string[] thamso,
            object[] giatri,
            OracleDbType[] paramTypes,
            string[] cursors = null)
        {
            if (cursors == null)
                cursors = new string[] { "RSOUT" };
            Task<DataTable> task = Task<DataTable>.Run(() =>
            {
                return ExecuteDataTableWithTypes(conString, store, thamso, giatri, paramTypes, cursors);
            });
            return task;
        }

        public static Task ExecuteNonQueryTask(string conString,
            string store,
            string[] thamso,
            object[] giatri)
        {
            Task task = Task.Run(() =>
            {
                ExecuteNonQuery(conString, store, thamso, giatri);
            });
            return task;
        }

        public static void ExecuteNonQuery(string conString,
            string store,
            string[] thamso,
            object[] giatri)
        {

            using (OracleConnection conn = new OracleConnection(conString))
            {
                using (OracleCommand comm = new OracleCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = store;
                    comm.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < thamso.Length; i++)
                    {
                        object paramValue = giatri[i];
                        if (paramValue == null) paramValue = DBNull.Value;
                        var param = comm.Parameters.Add(thamso[i], paramValue);
                    }
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static DataTable ExecuteDataTable(string conString,
            string store,
            string[] thamso,
            object[] giatri,
            string[] cursors)
        {
            using (OracleConnection conn = new OracleConnection(conString))
            {
                using (OracleCommand comm = new OracleCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = store;
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    for (int i = 0; i < thamso.Length; i++)
                    {
                        comm.Parameters.Add(thamso[i], giatri[i]);
                    }
                    for (int i = 0; i < cursors.Length; i++)
                    {
                        comm.Parameters.Add(new OracleParameter(cursors[i], OracleDbType.RefCursor)).Direction = ParameterDirection.Output;
                    }
                    DataTable dt = new DataTable();
                    OracleDataAdapter da = new OracleDataAdapter() {
                        SelectCommand = comm
                    };
                    
                    conn.Open();
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }

        public static DataTable ExecuteDataTableWithTypes(string conString,
            string store,
            string[] thamso,
            object[] giatri,
            OracleDbType[] paramTypes,
            string[] cursors)
        {
            using (OracleConnection conn = new OracleConnection(conString))
            {
                using (OracleCommand comm = new OracleCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = store;
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    for (int i = 0; i < thamso.Length; i++)
                    {
                        var param = comm.Parameters.Add(thamso[i], giatri[i]);
                        param.OracleDbType = paramTypes[i];
                    }
                    for (int i = 0; i < cursors.Length; i++)
                    {
                        comm.Parameters.Add(new OracleParameter(cursors[i], OracleDbType.RefCursor)).Direction = ParameterDirection.Output;
                    }
                    DataTable dt = new DataTable();
                    OracleDataAdapter da = new OracleDataAdapter() {
                        SelectCommand = comm
                    };
                    
                    conn.Open();
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }

        public static DataSet ExecuteDataSet(string conString,
            string store,
            string[] thamso,
            object[] giatri,
            string[] cursors)
        {

            using (OracleConnection conn = new OracleConnection(conString))
            {
                using (OracleCommand comm = new OracleCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = store;
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    for (int i = 0; i < thamso.Length; i++)
                    {
                        comm.Parameters.Add(thamso[i], giatri[i]);
                    }
                    for (int i = 0; i < cursors.Length; i++)
                    {
                        comm.Parameters.Add(new OracleParameter(cursors[i], OracleDbType.RefCursor)).Direction = ParameterDirection.Output;
                    }

                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter() {
                        SelectCommand = comm
                    };                    
                    conn.Open();
                    da.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
        }
    }
}