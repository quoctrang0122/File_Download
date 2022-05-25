using EncryptionQRCode;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace File_System
{
    public class DBConnection
    {
        public static string sConnnection = DatabaseConnection(Encryption.DatabaseConnection("QRCode_Database.bmp"));

        public string Server_IP { get { return IP; } }
        private static string IP;

        #region //Get Server Time//
        public static DateTime GetServerTime()
        {
            string sTime = DateTime.Now.ToString();

            OleDbConnection odcConnect = new OleDbConnection(sConnnection);
            string sSQL = "SELECT GETDATE()";
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            try
            {
                odcConnect.Open();
                sTime = odcCommand.ExecuteScalar().ToString();
            }
            catch (Exception exMsg)
            {
                if (exMsg != null)
                {
                    WriteAlarmLog("GetServerTime Data Alarm:" + exMsg.ToString(), "clsDatabase_Alarm.txt");
                    if (odcCommand != null) odcCommand.Dispose();
                    if (odcConnect != null) odcConnect.Dispose();
                }
            }
            finally
            {
                if (odcCommand != null) odcCommand.Dispose();
                if (odcConnect != null) odcConnect.Dispose();
            }


            DateTime dtServerTime = Convert.ToDateTime(sTime);
            return dtServerTime;
        }
        #endregion

        #region //Database Connection string//
        private static string DatabaseConnection(string EncryptionString)
        {
            string sConnnection = "";
            string[] saConnection = EncryptionString.Split(',');
            sConnnection = @"Provider=SQLOLEDB;Data Source=" + saConnection[0] +
                           @";Initial Catalog=" + saConnection[1] +
                           @";User id=" + saConnection[2] +
                           @";Password=" + saConnection[3];
            IP = saConnection[0];
            return sConnnection;
        }
        #endregion

        #region //Alarm record//
        public static void WriteAlarmLog(string sErrorMessage, string sFileName)
        {
            FileInfo fiLog = new FileInfo(System.Windows.Forms.Application.StartupPath + @"\" + sFileName);
            StreamWriter swMsg = null;
            string sLine = null;
            try
            {
                if (fiLog.Exists)
                {
                    swMsg = fiLog.AppendText();
                }
                else
                {
                    swMsg = fiLog.CreateText();
                    sLine = sLine + DateTime.Now.ToString() + " Create new file" + Environment.NewLine;
                    //swMsg.Write(sLine);
                }
                sLine = sLine + DateTime.Now.ToString() + " " + sErrorMessage + Environment.NewLine;
                swMsg.Write(sLine);
                swMsg.Flush();
                swMsg.Close();
            }
            catch (Exception exError)
            {
                if (exError != null)
                {
                    swMsg.Flush();
                    swMsg.Close();
                }
            }
        }

        #endregion
    }
    class clsLanguage
    {
        public static string LanguageName = "VN";

        #region ////////////////////////////CHANGE LANGUAGE///////////////////////////////////        
        //public static void ChangeLanguage(Control control)
        //{
        //    control.Text = clsGetLanguage.GetLanguage(LanguageName, control.Name);
        //    foreach (Control c in control.Controls)
        //    {
        //        if (c.HasChildren)
        //            ChangeLanguage(c);
        //        if ((c is Label && (c.Name).Substring(0, 5).ToString() != "Value")|| c is RadioButton || c is GroupBox || c is Button || c is CheckBox || c is MenuStrip || c is TabPage || c is RibbonControl || c is XtraTabPage || c is XtraTabControl || c is CheckEdit || c is SimpleButton || c is PanelControl)
        //            c.Text = clsGetLanguage.GetLanguage(LanguageName, c.Name);
        //    }

        //}

        //public void Translate(ToolStripMenuItem menu)
        //{
        //    foreach (ToolStripMenuItem item in menu.DropDownItems)
        //    {

        //        if (item.HasDropDownItems)
        //            Translate(item);
        //        item.Text = clsGetLanguage.GetLanguage(clsLanguage.LanguageName, item.Name);
        //    }
        //}

        //public void ChangeLanguageAll()
        //{
        //    foreach (ToolStripMenuItem item in mstMain.Items)
        //    {
        //        if (item.HasDropDownItems)
        //            Translate(item);
        //        item.Text = clsGetLanguage.GetLanguage(clsLanguage.LanguageName, item.Name);
        //    }
        //    ChangeLanguage(this);

        //}
        //public static string LanguageName = "EN";

        public static string GetControlText(string ObjectName)
        {
            string text = "";
            OleDbConnection oleDb = new OleDbConnection(DBConnection.sConnnection);
            string cmdText = "SELECT ObjectContent FROM Type_Language WHERE TLLanguage = ? AND ObjectName = ?";
            OleDbCommand oleDbCommand = new OleDbCommand(cmdText, oleDb);
            oleDbCommand.Parameters.Add("TLLanguage", OleDbType.VarChar).Value = LanguageName;
            oleDbCommand.Parameters.Add("ObjectName", OleDbType.VarChar).Value = ObjectName;
            try
            {
                oleDb.Open();
                text = Convert.ToString(oleDbCommand.ExecuteScalar());
                oleDb.Close();
            }
            catch (Exception ex)
            {
                bool flag = ex != null;
                if (flag)
                {
                    bool flag2 = oleDbCommand != null;
                    if (flag2)
                    {
                        oleDbCommand.Dispose();
                    }
                    bool flag3 = oleDb != null;
                    if (flag3)
                    {
                        oleDb.Dispose();
                    }
                }
            }
            bool flag4 = text == "";
            if (flag4)
            {
                text = ObjectName;
            }
            return text;
        }

        public static void changeLanguage(Control control)
        {
            //if (control.Name.Substring(0, 5).ToLower() != "value")
            //{
            //    control.Text = clsLanguage.GetObjectContentByName(control.Name);
            //}
            foreach (Control control2 in control.Controls)
            {
                if (control2.HasChildren)
                {
                    changeLanguage(control2);
                }
                if (control2 is Label || control2 is GroupBox || control2 is RadioButton || control2 is TabPage || control2 is CheckBox)
                {
                    try
                    {
                        if (control2.Name.Substring(0, 5).ToLower() != "value")
                        {
                            control2.Text = GetControlText(control2.Name);

                        }
                    }
                    catch { }
                }

                if (control2 is Button && control2.Text.Trim() != "")
                {
                    control2.Text = GetControlText(control2.Name);
                }

            }
        }

        #endregion
        #region //////////////////////////////////Funtion Load ComboBox//////////////////////////
        public void LoadCompobox(System.Windows.Forms.ComboBox c, string sSQL, string MemberValue, string DislayValue)
        {
            DBConnection con = new DBConnection();
            OleDbConnection odcConnect = new OleDbConnection(DBConnection.sConnnection);
            OleDbCommand odccomman = new OleDbCommand(sSQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader odrReader = odccomman.ExecuteReader();
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            c.Items.Clear();
            c.DisplayMember = "Text";
            c.ValueMember = "Value";

            try
            {
                while (odrReader.Read())
                {
                    c.Items.Add(new { Text = odrReader[DislayValue], Value = odrReader[MemberValue] });

                }
            }
            catch (Exception exMsg)
            {
                if (exMsg != null)
                {
                    if (odrReader != null) odrReader.Dispose();
                }
            }
            finally
            {
                if (odrReader != null) odrReader.Dispose();
            }
        }



        #endregion
    }
}
