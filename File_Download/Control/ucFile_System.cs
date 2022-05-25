using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Tulpep.NotificationWindow;
namespace File_System
{

    public partial class ucFile_System : Form
    {
        clsFile_System N;
        public string Value_User_Serial_Key = "DU00000002" ;
        public string sExcuteFile = "";
        public static string aLanguage = "VN";
        public ucFile_System()
        {
           
            InitializeComponent();
            //MessageBox.Show(clsConnectDatabase.sConnnection);
			clsLanguage.LanguageName = aLanguage;//frmMain.aLanguage;
            clsLanguage.changeLanguage(this);
            dgvUpload_System.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUpload_System.AllowUserToResizeRows = false;
            dgvUpload_System.MultiSelect = false;
            dgvUpload_System.EnableHeadersVisualStyles = false;
            dgvUpload_System.EnableHeadersVisualStyles = false;
            this.dgvUpload_System.EnableHeadersVisualStyles = false;
            this.dgvUpload_System.ColumnHeadersHeight = 35;
            dgvUpload_System.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvUpload_System.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            dgvUpload_System.RowTemplate.Height = 35;
            dgvUpload_System.EnableHeadersVisualStyles = false;
            this.dgvUpload_System.EnableHeadersVisualStyles = false;
            this.dgvUpload_System.ColumnHeadersHeight = 35;
            //chinh mau ke soc
            dgvUpload_System.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(214, 237, 249);
            foreach (DataGridViewColumn c in dgvUpload_System.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Calibi", 11F, GraphicsUnit.World);
            }
        }
      enum  dgvUpload_System_enum
        {
            Check = 0,          
            File_Name = 1,           
            Upload_Time = 2,
            User_Serial_Key = 3,
            ExcuteFile = 4,
            Enforce = 5
        }
        private void GetFileUpload()
        {

            OleDbConnection odcConnect = new OleDbConnection(DBConnection.sConnnection);

            string sSQL = "select FileName,FileStream,A.User_Serial_Key,User_Name,CONVERT(VARCHAR,UpdateTime,103) UpdateTime ,UpdateStartDate,UpdateDutyDate,ExcuteFile,Enforce from File_Download_New A,Data_User B WHERE A.User_Serial_Key = B.User_Serial_Key";
            if(txtFile_Name.Text != "")
            { 
                sSQL += " and FileName Like '%" + txtFile_Name.Text.Trim()+ "%'  "; 
            }
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);

            try
            {
                odcConnect.Open();
                dgvUpload_System.Rows.Clear();
                OleDbDataReader odrReader = odcCommand.ExecuteReader();
                try
                {
                    int t = 1;

                    while (odrReader.Read())
                    {

                        dgvUpload_System.Rows.Add(new object[] { "False", odrReader["FileName"].ToString(), odrReader["UpdateTime"].ToString(), odrReader["User_Name"].ToString(), odrReader["ExcuteFile"].ToString(), odrReader["Enforce"].ToString() });

                        if (t % 2 == 0)
                            dgvUpload_System.Rows[t - 1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                        //t++;
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
            catch (Exception exMsg)
            {
                if (exMsg != null)
                {
                    if (odcCommand != null) odcCommand.Dispose();
                    if (odcConnect != null) odcConnect.Dispose();
                }
            }
            finally
            {
                if (odcCommand != null) odcCommand.Dispose();
                if (odcConnect != null) odcConnect.Dispose();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetFileUpload();
        }
        private static bool Check_File(string File_Name)
        {
            OleDbConnection odcConnect = new OleDbConnection(DBConnection.sConnnection);
            string sSQL = "SELECT FileName FROM File_Download_New WHERE FileName =  N'" + File_Name + "'";
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
          
            try
            {
                odcConnect.Open();
                OleDbDataReader odrReader = odcCommand.ExecuteReader();
                try
                {
                    while (odrReader.Read())
                    {
                        return true;
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
            catch (Exception exMsg)
            {
                if (exMsg != null)
                {
                    if (odcCommand != null) odcCommand.Dispose();
                    if (odcConnect != null) odcConnect.Dispose();
                }
            }
            finally
            {
                if (odcCommand != null) odcCommand.Dispose();
                if (odcConnect != null) odcConnect.Dispose();
            }
            return false;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            N = new clsFile_System();
            string FileName = "";
            string Check_Name = "";
            OpenFileDialog ofdOpenfile = new OpenFileDialog();
            if (ofdOpenfile.ShowDialog() == DialogResult.OK)
            {
                FileName = ofdOpenfile.FileName;
                Check_Name =  ofdOpenfile.SafeFileName; 
                if (Check_File(Check_Name.ToString()))
                {
                    if (clsLanguage.LanguageName == "TW")
                    {
                        MessageBox.Show("该文件已存在 ! 请在更新前删除 ", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (clsLanguage.LanguageName == "EN")
                    {
                        MessageBox.Show("The file already exists ! Please delete before update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Tệp tin đã tồn tại ! Hãy xóa trước khi cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if(chxFile_System.Checked == true)
                    {
                        N.AddFile(FileName, Value_User_Serial_Key, DateTime.Now.ToString("yyyyMMdd"), "20991231", "1", "0");
                        chxFile_System.Checked = false;
                    }
                    else
                    {
                        N.AddFile(FileName, Value_User_Serial_Key, DateTime.Now.ToString("yyyyMMdd"), "20991231", "0", "0");

                    }
                }									
										GetFileUpload();
						}									

        }
        private void Function_Delete()
        {
            DialogResult traloi;
            traloi = MessageBox.Show(" Do you want to delete ? ", "Reply", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sLine = "";
                for (int i = 0; i < dgvUpload_System.RowCount; i++)
                {
                    N = new clsFile_System();

                    if (dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.Check].Value.ToString() == "True")
                    {

                        N.FileName = dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.File_Name].Value.ToString();
                        N.DeleteFile();
                        sLine = sLine + N.FileName + "\t Delete Sucessful!!" + Environment.NewLine;
                    }

                }
                if (sLine == "")
                    MessageBox.Show("Please ! Select information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(sLine, "Information Delete");
                GetFileUpload();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Function_Delete();
        }
        private void DownloadFile(string FileName, string SPATH)
        {
            OleDbConnection odcConnect = new OleDbConnection(DBConnection.sConnnection);
            string sPath = "";
            string sSQL = "SELECT FileStream,FileName FROM File_Download_New  where FileName = N'" + FileName + "'";
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            try
            {
                odcConnect.Open();
                OleDbDataReader odrReader = odcCommand.ExecuteReader();
                try
                {
                    while (odrReader.Read())
                    {
                        Application.DoEvents();
                        sExcuteFile = odrReader["FileName"].ToString().Trim();
                        System.GC.Collect();
                        //sPath = @"D:\DATA\DOWNLOAD\" + odrReader["File_Name"].ToString().Trim(); 
                        sPath = SPATH;
                        System.IO.FileInfo fiImg = new System.IO.FileInfo(sPath);
                        fiImg.Delete();

                        if (fiImg.Exists == false)
                        {
                            Application.DoEvents();
                            Byte[] byBlob = null;
                            byBlob = new Byte[(odrReader.GetBytes(0, 0, null, 0, int.MaxValue))];
                            odrReader.GetBytes(0, 0, byBlob, 0, byBlob.Length);
                            FileStream fsImg = null;
                            fsImg = new FileStream(sPath, FileMode.Create, FileAccess.Write);
                            fsImg.Write(byBlob, 0, byBlob.Length);
                            fsImg.Close();
                        }
                        else
                        {

                        }
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
            catch (Exception exMsg)
            {
                if (exMsg != null)
                {

                    if (odcCommand != null) odcCommand.Dispose();
                    if (odcConnect != null) odcConnect.Dispose();
                }
            }
            finally
            {
                if (odcCommand != null) odcCommand.Dispose();
                if (odcConnect != null) odcConnect.Dispose();
            }

        }
        private void Function_Download()
        {
            bool check = false;
            for (int i = 0; i < dgvUpload_System.RowCount; i++)
            {
                if (dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.Check].Value.ToString() == "True")
                    check = true;
            }
            if (check == false)
                MessageBox.Show("Please ! Select information need download !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var SelectFolder = new FolderSelectDialog();
                SelectFolder.Title = "Select your folder";
                SelectFolder.InitialDirectory = @"D:\";
                if (SelectFolder.ShowDialog(IntPtr.Zero))
                {
                    for (int i = 0; i < dgvUpload_System.RowCount; i++)
                    {
                        if (dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.Check].Value.ToString() == "True")
                        {
                            string SPATH = SelectFolder.FileName + "\\" + dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.File_Name].Value.ToString();
                            //MessageBox.Show(SPATH);
                            DownloadFile(dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.File_Name].Value.ToString(), SPATH);
                            MessageBox.Show("Download Succesful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            Function_Download();
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvUpload_System.RowCount; i++)
            {
                if (dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.Check].Value.ToString() == "True")
                {
                    N = new clsFile_System();
                        N.FileName = dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.File_Name].Value.ToString();                      
                        N.UpdateFile();
                        MessageBox.Show("Succesfull","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUpload_System.Columns[(int)dgvUpload_System_enum.Check].Width = 50;
            dgvUpload_System.Columns[(int)dgvUpload_System_enum.File_Name].AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill;
            dgvUpload_System.Columns[(int)dgvUpload_System_enum.Upload_Time].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
            dgvUpload_System.Columns[(int)dgvUpload_System_enum.User_Serial_Key].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUpload_System.Columns[(int)dgvUpload_System_enum.ExcuteFile].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUpload_System.Columns[(int)dgvUpload_System_enum.Enforce].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            txtFile_Name.Text = "";


        }

        private void lblFile_Name_TextChanged(object sender, EventArgs e)
        {
            if (ucFile_System.aLanguage == "EN")
            {
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Check].HeaderText = "Check";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.File_Name].HeaderText = "File Name";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Upload_Time].HeaderText = "Upload";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.User_Serial_Key].HeaderText = "User Name";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.ExcuteFile].HeaderText = "ExcuteFile";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Enforce].HeaderText = "Enforce";

            }
            else if (ucFile_System.aLanguage == "TW")
            {
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Check].HeaderText = "选择";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.File_Name].HeaderText = "文件名";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Upload_Time].HeaderText = "时间的变化";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.User_Serial_Key].HeaderText = "创造者";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.ExcuteFile].HeaderText = "执行";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Enforce].HeaderText = "Enforce";
            }
            else if (ucFile_System.aLanguage == "VN")

            {
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Check].HeaderText = "Chọn";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.File_Name].HeaderText = "Tên tệp";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Upload_Time].HeaderText = "Thời gian";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.User_Serial_Key].HeaderText = "Người cập nhật";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.ExcuteFile].HeaderText = "Thi hành";
                dgvUpload_System.Columns[(int)dgvUpload_System_enum.Enforce].HeaderText = "Enforce";
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            GetFileUpload();
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {

            N = new clsFile_System();
            string FileName = "";
            string Check_Name = "";
            OpenFileDialog ofdOpenfile = new OpenFileDialog();
            if (ofdOpenfile.ShowDialog() == DialogResult.OK)
            {
                FileName = ofdOpenfile.FileName;
                Check_Name = ofdOpenfile.SafeFileName;
                if (Check_File(Check_Name.ToString()))
                {
                    if (clsLanguage.LanguageName == "TW")
                    {
                        MessageBox.Show("该文件已存在 ! 请在更新前删除 ", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (clsLanguage.LanguageName == "EN")
                    {
                        MessageBox.Show("The file already exists ! Please delete before update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Tệp tin đã tồn tại ! Hãy xóa trước khi cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (chxFile_System.Checked == true)
                    {
                        N.AddFile(FileName, Value_User_Serial_Key, DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd"), "1", "0");
                        chxFile_System.Checked = false;
                    }
                    else
                    {
                        N.AddFile(FileName, Value_User_Serial_Key, DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd"), "0", "0");

                    }
                }
						
					}
			
				GetFileUpload();
								
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            Function_Delete();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvUpload_System.RowCount; i++)
            {
                if (dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.Check].Value.ToString() == "True")
                {
                    N = new clsFile_System();
                    N.FileName = dgvUpload_System.Rows[i].Cells[(int)dgvUpload_System_enum.File_Name].Value.ToString();
                    N.UpdateFile();
                    MessageBox.Show("Succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

		private void Timer1_Tick(object sender, EventArgs e)
		{

		}
		public event EventHandler MenuClick;
		private void button1_Click(object sender, EventArgs e) {
			PopupNotifier popu = new PopupNotifier();
			popu.Image = Properties.Resources.iconfinder;
			popu.AnimationDuration = 1000;
			popu.AnimationInterval = 1;
			//popu.ShowOptionsButton = true;
			if (clsLanguage.LanguageName == "TW") {
				popu.TitleText = "新公告";
				popu.ContentText = "您要打开任何新更新吗？";
				popu.Popup();

			}
			else if (clsLanguage.LanguageName == "EN") {
				popu.TitleText = "Thông báo mới";
				popu.TitleText = "Có bản cập nhật mới bạn muốn tắt phần mềm mở lại hay không?";
				popu.Popup();
			}
			else {
				popu.TitleText = "New Infomation";
				popu.ContentText = "Is there any new update you want to open?";
				popu.Popup();
			}
		}

		private void yesToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void noToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}
	}
}
