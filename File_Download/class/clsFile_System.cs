using System;
using System.Data.OleDb;
using System.IO;

namespace File_System
{
    class clsFile_System
    {
        public string  File_Serial_Key { get; set; }
        public string FileName { get; set; }
        public string FileStream { get; set; }
        public string Upload_Time { get; set; }
        public string User_Serial_Key { get; set; }
        public string Remark { get; set; }
        public string IsDelete { get; set; }



        public string IncreaseData()
        {
            string sData = "";
            int iCount = 0;
            OleDbConnection odcConnect = new OleDbConnection(DBConnection.sConnnection);
            string sSQL = "SELECT MAX(File_Serial_Key) AS File_Serial_Key FROM Data_File WHERE File_Serial_Key LIKE ?";
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcCommand.Parameters.Add("File_Serial_Key", OleDbType.VarChar);
            odcCommand.Parameters["File_Serial_Key"].Value = "FM%";
            try
            {
                odcConnect.Open();
                sData = odcCommand.ExecuteScalar().ToString();
            }
            catch (Exception exMsg)
            {
                if (exMsg != null)
                {
                    //WriteAlarmLog("Log_User_Serial Data Alarm:" + exMsg.ToString(), "clsDatabase_Alarm.txt");
                    if (odcCommand != null) odcCommand.Dispose();
                    if (odcConnect != null) odcConnect.Dispose();
                }
            }
            finally
            {
                if (odcCommand != null) odcCommand.Dispose();
                if (odcConnect != null) odcConnect.Dispose();
            }

            if (sData.Trim().Length == 0)
                sData = "FM00000001";
            else
            {
                iCount = Convert.ToInt32(sData.Substring(2, 8)) + 1;
                sData = "FM" + string.Format("{0:00000000}", iCount);
            }
            return sData;
        }
        public void AddFile(string filename, string UserKey, string UpdateStartDate, string UpdateDutyDate, string ExcuteFile, string Enforce)
        {
            byte[] file;
            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }

            string sSQL = @"INSERT INTO File_Download_New (FileName,FileStream,User_Serial_Key,UpdateTime,UpdateStartDate,UpdateDutyDate,ExcuteFile,Enforce)  VALUES( N'" + Path.GetFileName(filename).Replace("'", "''") + "', ?, ?, CONVERT(VARCHAR, GETDATE(),101) , ?,  ?, ?, ?)";
            OleDbConnection odcConnect = new OleDbConnection(DBConnection.sConnnection);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);  
            odcCommand.Parameters.Add("FileStream", OleDbType.VarBinary).Value = file;
            odcCommand.Parameters.Add("User_Serial_Key", OleDbType.VarChar).Value = UserKey;
            odcCommand.Parameters.Add("UpdateStartDate", OleDbType.VarChar).Value = UpdateStartDate;
            odcCommand.Parameters.Add("UpdateDutyDate", OleDbType.VarChar).Value = UpdateDutyDate;
            odcCommand.Parameters.Add("ExcuteFile", OleDbType.VarChar).Value = ExcuteFile;
            odcCommand.Parameters.Add("Enforce", OleDbType.VarChar).Value = Enforce;
            odcConnect.Open();
            odcCommand.ExecuteNonQuery();
            odcConnect.Close();
        }
        public void DeleteFile()
        {
            string sSQL = "DELETE FROM File_Download_New WHERE FileName = '" + FileName + "'";
            OleDbConnection odcConnect = new OleDbConnection(DBConnection.sConnnection);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcConnect.Open();
            odcCommand.ExecuteNonQuery();
            odcConnect.Close();
        }
        public void UpdateFile()
        {
            //string sSQL = "UPDATE Data_File SET Remark= N'" + Remark + "' WHERE File_Serial_Key = '" + File_Serial_Key + "'";
            //clsConnectDatabase con = new clsConnectDatabase();
            //con.executeQuery(sSQL);
        }
    }
}
