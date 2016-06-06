using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Runtime.Serialization;

namespace WCFService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]   
    public class ImportService : IImport
    {
        [OperationBehavior]
        public string Test()
        {
            return "Hello Test";
        }

        [OperationBehavior]
        public List<ImportStaging> getData()
        {
            var buffer = new List<ImportStaging>();
            
            try
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.ConnStr))
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = Properties.Resources.GetCmd;
                    conn.Open();
                    Console.WriteLine("Connection Open...");
                    using (var rdr = comm.ExecuteReader())
                    {
                        Console.WriteLine("Execute Query...");
                        while (rdr.Read())
                        {
                            var t = new ImportStaging();
                            t.AxId = rdr.GetString(rdr.GetOrdinal("AxId"));
                            t.Action = rdr.GetByte(rdr.GetOrdinal("Action"));
                            t.Module = rdr.GetByte(rdr.GetOrdinal("Module"));
                            t.Status = rdr.GetByte(rdr.GetOrdinal("Status"));
                            t.Partition = rdr.GetString(rdr.GetOrdinal("Partition"));
                            t.CommonKey = rdr.GetString(rdr.GetOrdinal("CommonKey"));
                            t.Data = Encoding.Unicode.GetBytes(rdr.GetString(rdr.GetOrdinal("Data")));
                            t.Log = rdr.GetString(rdr.GetOrdinal("Log"));
                            buffer.Add(t);
                        }
                        rdr.Close();
                    }
                    
                    conn.Close();
                    comm.Dispose();
                    conn.Dispose();
                }
                Console.WriteLine("Connection Close...");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return buffer;
        }

        [OperationBehavior]
        public List<ImportStaging> getAllData()
        {
            var buffer = new List<ImportStaging>();
            try
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.ConnStr))
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "Select * from ImportStaging order by commonkey asc";
                    conn.Open();
                    Console.WriteLine("Connection Open...");
                    using (var rdr = comm.ExecuteReader())
                    {
                        Console.WriteLine("Execute Query...");
                        while (rdr.Read())
                        {
                            var t = new ImportStaging();
                            t.AxId = rdr.GetString(rdr.GetOrdinal("AxId"));
                            t.Action = rdr.GetByte(rdr.GetOrdinal("Action"));
                            t.Module = rdr.GetByte(rdr.GetOrdinal("Module"));
                            t.Status = rdr.GetByte(rdr.GetOrdinal("Status"));
                            t.Partition = rdr.GetString(rdr.GetOrdinal("Partition"));
                            t.CommonKey = rdr.GetString(rdr.GetOrdinal("CommonKey"));
                            t.Data = Encoding.Unicode.GetBytes(rdr.GetString(rdr.GetOrdinal("Data")));
                            t.Log = rdr.GetString(rdr.GetOrdinal("Log"));
                            buffer.Add(t);
                        }
                        rdr.Close();
                    }
                    conn.Close();
                    comm.Dispose();
                    conn.Dispose();
                }
                Console.WriteLine("Connection Close...");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return buffer;
        }

        [OperationBehavior]
        public bool setStatusbyCommonKey(ImportStaging updated)
        {
            var res = false;
            try
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.ConnStr))
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = Properties.Resources.SetCmd;
                    comm.Parameters.AddWithValue("@axid", updated.AxId);
                    comm.Parameters.AddWithValue("@status", updated.Status);
                    comm.Parameters.Add("@log",SqlDbType.NVarChar).Value = updated.Log;
                    comm.Parameters.AddWithValue("@key", updated.CommonKey);
                    comm.Parameters.AddWithValue("@module", updated.Module);
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        res = true;
                        Console.WriteLine("Status Changed...");
                    }
                    conn.Close();
                    comm.Dispose();
                    conn.Dispose();
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }
    }


    [ServiceContract]
    public interface IImport
    {
        [OperationContract]
        string Test();

        [OperationContract]
        List<ImportStaging> getData();

        [OperationContract]
        List<ImportStaging> getAllData();

        [OperationContract]
        bool setStatusbyCommonKey(ImportStaging updated);
    }

    [DataContract]
    public class ImportStaging
    {
        [DataMember]
        public string CommonKey { get; set; }

        [DataMember]
        public string Partition { get; set; }

        [DataMember]
        public string AxId { get; set; }

        [DataMember]
        public byte Action { get; set; }

        [DataMember]
        public byte Module { get; set; }

        [DataMember]
        public byte Status { get; set; }

        [DataMember]
        public byte[] Data { get; set; }

        [DataMember]
        public string Log { get; set; }
    }

}
