using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace JSDY.U9SV.Utils
{

    /// <summary>
    /// SQLHelper 的摘要说明
    /// </summary>
    public class SQLHelper
    {
        #region 连接串

        /// <summary>
        /// 获取当前数据库连接
        /// </summary>
        /// <returns></returns>
        public static IDbConnection GetCurrConnection()
        {
            try
            {
                string connString = PDAConfig.GetConnectionString();
                if (_currConnection == null || string.Compare(_currConnection.ConnectionString, connString, true) != 0)
                    _currConnection = CreateConnection(connString);
                return _currConnection;
            }
            catch (Exception ex)
            {
                PDALog.Error(ex);
                throw;
            }
        }

        private static IDbConnection _currConnection = null;

        /// <summary>
        /// 创建数据库连接
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        private static IDbConnection CreateConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("connection string is null!");

            IDbConnection connection = new SqlConnection(connectionString);
            PDALog.Debug(string.Format("创建返回一个新的数据库连接对象SqlConnection.ConnectionString:{0}.", connectionString));
            return connection;
        }
        /// <summary>
        /// 创建数据适配器
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private static IDbDataAdapter CreateAdapter(IDbCommand command)
        {
            SqlCommand sqlCommand = command as SqlCommand;
            if (sqlCommand == null)
                throw new Exception("IDbCommand的类型不是SqlCommand！");
            return new SqlDataAdapter(sqlCommand);
        }

        #endregion

        #region 查询

        /// <summary>
        /// 使用数据事务，执行sql
        /// </summary>
        /// <param name="strSql"></param>
        public static void ExecuteSqlTransaction(List<string> strSqls)
        {
            if (strSqls == null || strSqls.Count == 0) return;
           
            IDbConnection conn = SQLHelper.GetCurrConnection();
            IDbCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            conn.Open();
            IDbTransaction transaction = conn.BeginTransaction();
            try
            {
                command.Transaction = transaction;
                foreach (string strSql in strSqls)
                {
                    try
                    {
                        PDALog.Debug("执行sql:" + strSql);
                        command.CommandText = strSql;
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        PDALog.Error("执行sql:" + strSql);
                        PDALog.Error(ex);
                        throw;
                    }
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                transaction.Dispose();
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        /// <summary>
        /// 执行SQL，返回影响行数
        /// </summary>
        /// <param name="strSql"></param>
        public static int ExecuteNonQuery(string strSql)
        {
            PDALog.Debug("执行sql:" + strSql);
            IDbConnection conn = SQLHelper.GetCurrConnection();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = strSql;
            command.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                PDALog.Error("执行sql:" + strSql);
                PDALog.Error(ex);
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }
        /// <summary>
        /// 执行SQL，返回结果集中的第一行第一列的数据
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string strSql)
        {
            PDALog.Debug("执行sql:" + strSql);
            IDbConnection conn = SQLHelper.GetCurrConnection();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = strSql;
            command.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                PDALog.Error("执行sql:" + strSql);
                PDALog.Error(ex);
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }
        /// <summary>
        /// 执行SQL，返回IDataReader结果
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static IDataReader ExecuteReader(string strSql)
        {
            PDALog.Debug("执行sql:" + strSql);
            IDbConnection conn = SQLHelper.GetCurrConnection();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = strSql;
            command.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                PDALog.Error("执行sql:" + strSql);
                PDALog.Error(ex);
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }
        /// <summary>
        /// 执行SQL，返回DataSet结果
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string strSql)
        {
            PDALog.Debug("执行sql:" + strSql);
            IDbConnection conn = SQLHelper.GetCurrConnection();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = strSql;
            command.CommandType = CommandType.Text;

            IDbDataAdapter adapter = CreateAdapter(command);
            DataSet dataSet = new DataSet();
            conn.Open();
            try
            {
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                PDALog.Error("执行sql:" + strSql);
                PDALog.Error(ex);
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        #endregion
    }
}
