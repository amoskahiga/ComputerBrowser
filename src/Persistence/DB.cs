using System;
using System.Data.Common;
using System.Collections.Generic;
using ComputerBrowser.ComputerSystem;

namespace ComputerBrowser.Persistence
{
    public static class DbCommandExtension
    {
        /// <summary>
        /// Creates a new instance of a DbParameter object
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="sourceColumn"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DbParameter CreateParameter(this DbCommand cmd, string sourceColumn, object value)
        {
            DbParameter param = cmd.CreateParameter();
            param.SourceColumn = sourceColumn;
            param.Value = value;
            return param;
        }
    }


    /// <summary>
    /// Class used to persist computer objects to the database.
    /// </summary>
    public class DB
    {

        private DbConnection connection;

        public DB(DbConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        public void PersistComputerCollection(List<Computer> computers)
        {

            foreach (Computer computer in computers)
            {
                PersistComputer(computer);
            }

        }


        /// <summary>
        /// Stores a computer object to the database.
        /// </summary>
        /// <param name="computerCollection"></param>
        public void PersistComputer(Computer computer)
        {

            //Get the ID of the computer if it already exists
            int ComputerID = GetComputerIDByName(computer.Name);

            if (ComputerID == 0)
                //Add new computer to DB and obtain its new ID
                ComputerID = PersistComputerName(computer.Name);

            //Update computer in DB
            PersistShares(computer, ComputerID);
            PersistPrinters(computer, ComputerID);
            PersistOperatingSystem(computer, ComputerID);
            PersistLogicalDisks(computer, ComputerID);
            PersistSystem(computer, ComputerID);
            PersistProcesses(computer, ComputerID);
            PersistProcessors(computer, ComputerID);
            PersistNetworkAdapters(computer, ComputerID);

        }


        /// <summary>
        /// Returns the ID of the computer from the database.
        /// </summary>
        /// <param name="computerName">Name of computer to check</param>
        /// <returns>ID of computer or 0 if computer does not exists in the database.</returns>
        private int GetComputerIDByName(String computerName)
        {

            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = "GetComputerIDByName";
            DbParameter param = cmd.CreateParameter("ComputerName", computerName.ToLower());

            connection.Open();
            Object Result = cmd.ExecuteScalar();

            int ComputerID;
            if (Result == null)
                ComputerID = 0;
            else
                ComputerID = Int32.Parse(Result.ToString());

            connection.Close();

            return ComputerID;

        }


        /// <summary>
        /// Adds adds the computer's name into the ComputersTable.
        /// </summary>
        /// <param name="computerName">Name of computer to add.</param>
        /// <returns>The ComputerID of the computer as stored in the DB.</returns>
        public int PersistComputerName(String computerName)
        {
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = "AddComputer";
            DbParameter param = cmd.CreateParameter("ComputerName", computerName);

            connection.Open();
            Object Result = cmd.ExecuteScalar();

            int ComputerID;
            if (Result == null)
                ComputerID = 0;
            else
                ComputerID = Int32.Parse(Result.ToString());

            connection.Close();

            return ComputerID;
        }


        public void PersistShares(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeleteSharesByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store each share in DB
            foreach (ComputerSystem.Share share in computer.Shares)
            {

                cmd.CommandText = "AddShare";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ComputerID", computerID);
                cmd.Parameters.Add("@Description", share.Description + "");
                cmd.Parameters.Add("@Name", share.Name + "");
                cmd.Parameters.Add("@Path", share.Path + "");
                cmd.Parameters.Add("@Type", share.Type + "");
                cmd.Parameters.Add("@Status", share.Status + "");

                cmd.ExecuteNonQuery();
            }



            connection.Close();
        }


        public void PersistPrinters(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeletePrintersByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store each printer in DB
            foreach (ComputerSystem.Printer printer in computer.Printers)
            {

                cmd.CommandText = "AddPrinter";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ComputerID", computerID);
                cmd.Parameters.Add("@Name", printer.Name + "");
                cmd.Parameters.Add("@ServerName", printer.ServerName + "");
                cmd.Parameters.Add("@ShareName", printer.ShareName + "");
                cmd.Parameters.Add("@State", printer.State + "");
                cmd.Parameters.Add("@Status", printer.Status + "");
                cmd.Parameters.Add("@HorizontalResolution", (long)printer.HorizontalResolution);
                cmd.Parameters.Add("@VerticalResolution", (long)printer.VerticalResolution);
                cmd.Parameters.Add("@DataType", printer.DataType + "");

                cmd.ExecuteNonQuery();
            }



            connection.Close();
        }


        public void PersistOperatingSystem(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeleteOperatingSystemByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store Operating System in DB
            cmd.CommandText = "AddOperatingSystem";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.Parameters.Add("@Name", computer.OperatingSystem.Name + "");
            cmd.Parameters.Add("@FreePhysicalMemory", (long)computer.OperatingSystem.FreePhysicalMemory);
            cmd.Parameters.Add("@FreeVirtualMemory", (long)computer.OperatingSystem.FreeVirtualMemory);
            cmd.Parameters.Add("@InstallDate", computer.OperatingSystem.InstallDate);
            cmd.Parameters.Add("@LastBootUpTime", computer.OperatingSystem.LastBootUpTime);
            cmd.Parameters.Add("@LocalDateTime", computer.OperatingSystem.LocalDateTime);
            cmd.Parameters.Add("@SerialNumber", computer.OperatingSystem.SerialNumber + "");
            cmd.Parameters.Add("@ServicePack", computer.OperatingSystem.ServicePack + "");
            cmd.Parameters.Add("@Version", computer.OperatingSystem.Version + "");
            cmd.Parameters.Add("@WindowsDirectory", computer.OperatingSystem.WindowsDirectory + "");

            cmd.ExecuteNonQuery();




            connection.Close();
        }


        public void PersistLogicalDisks(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeleteLogicalDisksByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store each logical disk in DB
            foreach (ComputerSystem.LogicalDisk logicalDisk in computer.LogicalDisks)
            {
                cmd.CommandText = "AddLogicalDisk";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ComputerID", computerID);
                cmd.Parameters.Add("@Name", logicalDisk.Name + "");
                cmd.Parameters.Add("@Description", logicalDisk.Description + "");
                cmd.Parameters.Add("@FileSystem", logicalDisk.FileSystem + "");
                cmd.Parameters.Add("@FreeSpace", (long)logicalDisk.FreeSpace);
                cmd.Parameters.Add("@ShareName", logicalDisk.ShareName + "");
                cmd.Parameters.Add("@Size", (long)logicalDisk.Size);
                cmd.Parameters.Add("@Status", logicalDisk.Status + "");
                cmd.Parameters.Add("@Type", logicalDisk.Type + "");

                cmd.ExecuteNonQuery();


            }




            connection.Close();
        }


        public void PersistSystem(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeleteSystemByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store System in DB
            cmd.CommandText = "AddSystem";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.Parameters.Add("@Domain", computer.System.Domain + "");
            cmd.Parameters.Add("@LoggedOnUser", computer.System.LoggedOnUser + "");
            cmd.Parameters.Add("@Manufacturer", computer.System.Manufacturer + "");
            cmd.Parameters.Add("@Model", computer.System.Model + "");
            cmd.Parameters.Add("@TotalMemory", (long)computer.System.TotalMemory);

            cmd.ExecuteNonQuery();

            connection.Close();
        }


        public void PersistProcesses(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeleteProcessesByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store each process in DB
            foreach (ComputerSystem.Process process in computer.Processes)
            {
                cmd.CommandText = "AddProcess";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ComputerID", computerID);
                cmd.Parameters.Add("@Name", process.Name + "");
                cmd.Parameters.Add("@Path", process.Path + "");

                cmd.ExecuteNonQuery();
            }




            connection.Close();
        }


        public void PersistProcessors(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeleteProcessorsByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store each processor in DB
            foreach (ComputerSystem.Processor processor in computer.Processors)
            {
                cmd.CommandText = "AddProcessor";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ComputerID", computerID);
                cmd.Parameters.Add("@Name", processor.Name + "");
                cmd.Parameters.Add("@L2CacheSize", (long)processor.L2CacheSize);
                cmd.Parameters.Add("@Speed", (long)processor.Speed);
                cmd.Parameters.Add("@UpgradeMethod", processor.UpgradeMethod + "");
                cmd.Parameters.Add("@Version", processor.Version + "");

                cmd.ExecuteNonQuery();
            }




            connection.Close();
        }


        public void PersistNetworkAdapters(Computer computer, int computerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.CommandText = "DeleteNetworkAdaptersByID";
            cmd.Parameters.Add("@ComputerID", computerID);
            cmd.ExecuteNonQuery();

            //Store each processor in DB
            foreach (ComputerSystem.NetworkAdapter networkAdapter in computer.NetworkAdapters)
            {
                cmd.CommandText = "AddNetworkAdapter";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ComputerID", computerID);
                cmd.Parameters.Add("@DatabasePath", networkAdapter.DatabasePath + "");
                cmd.Parameters.Add("@DhcpEnabled", networkAdapter.DhcpEnabled);
                cmd.Parameters.Add("@DhcpLeaseExpirationDate", networkAdapter.DhcpLeaseExpirationDate);
                cmd.Parameters.Add("@DhcpLeaseObtainedDate", networkAdapter.DhcpLeaseObtainedDate);
                cmd.Parameters.Add("@DhcpServer", networkAdapter.DhcpServer + "");
                cmd.Parameters.Add("@DnsDomain", networkAdapter.DnsDomain + "");
                cmd.Parameters.Add("@DnsHostName", networkAdapter.DnsHostName + "");
                cmd.Parameters.Add("@DnsServers", String.Join(", ", networkAdapter.DnsServers) + "");
                cmd.Parameters.Add("@Gateways", String.Join(", ", networkAdapter.Gateways) + "");
                cmd.Parameters.Add("@IPAddresses", String.Join(", ", networkAdapter.IPAddresses) + "");
                cmd.Parameters.Add("@IPEnabled", networkAdapter.IPEnabled);
                cmd.Parameters.Add("@IPSubnets", String.Join(", ", networkAdapter.IPSubnets) + "");
                cmd.Parameters.Add("@MacAddress", networkAdapter.MacAddress + "");
                cmd.Parameters.Add("@Model", networkAdapter.Model + "");
                cmd.Parameters.Add("@WinsHostLookupFile", networkAdapter.WinsHostLookupFile + "");
                cmd.Parameters.Add("@WinsLMHostLookupEnabled", networkAdapter.WinsLMHostLookupEnabled);
                cmd.Parameters.Add("@WinsPrimaryServer", networkAdapter.WinsPrimaryServer + "");
                cmd.Parameters.Add("@WinsSecondaryServer", networkAdapter.WinsSecondaryServer + "");


                cmd.ExecuteNonQuery();
            }




            connection.Close();
        }


    }
}
