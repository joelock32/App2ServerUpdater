using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ETravUpdater
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string xfile;
        string fn;
        string[] versioninfo;
        string FileNameof;
        String ConnStr = "Data Source=etrav-hack;Initial Catalog=Images;Persist Security Info=True;User ID=Application;Password=noitacilppa";
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                xfile = openFileDialog1.FileName;
                FileNameof = Path.GetFileName(xfile);
                fn = Path.GetFileNameWithoutExtension(xfile);
                versioninfo = fn.Split('_');
                Version v;
                if (versioninfo.Length > 1 && Version.TryParse(versioninfo.Last(), out v))
                {
                    Console.Write("Major:{0}, Minor:{1}", v.Major, v.Minor);
                }
                databaseFilePut(xfile);
            }
            Console.WriteLine(result); // <-- For debugging use.
        }

        public  void databaseFilePut(string varFilePath)
        {
            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            using (SqlConnection SqlConn = new SqlConnection(ConnStr))
            using (SqlCommand command = SqlConn.CreateCommand())
            {
                command.CommandText = "UPDATE tblapplications SET Application=@binapp, SET Version=@versioninfo FileDate=getdate() ";
                command.Parameters.AddWithValue("@binapp", file);
                command.Parameters.AddWithValue("@versioninfo", versioninfo);

                SqlConn.Open();

                command.ExecuteNonQuery();
                
                SqlConn.Close();
            }
        }

        public void databaseFileRead(string varID, string varPathToNewLocation)
        {
            using (SqlConnection SqlConn = new SqlConnection(ConnStr))
            using (SqlCommand command = SqlConn.CreateCommand())
            {
                command.CommandText = @"SELECT [Application] FROM tblapplications WHERE [RaportID] = @varID";
                command.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = command.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }
        }

        public MemoryStream databaseFileRead(string varID)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (SqlConnection SqlConn = new SqlConnection(ConnStr))
            using (SqlCommand command = SqlConn.CreateCommand())
            {
                command.CommandText = @"SELECT [Application] FROM tblapplications WHERE [RaportID] = @varID";
                command.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = command.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        //using (var fs = new MemoryStream(memoryStream, FileMode.Create, FileAccess.Write)) {
                        memoryStream.Write(blob, 0, blob.Length);
                        //}
                    }
            }
            return memoryStream;
        }

        public int databaseFilePut(MemoryStream fileToPut)
        {
            int varID = 0;
            byte[] file = fileToPut.ToArray();
            const string preparedCommand = @"
                    INSERT INTO tblapplications
                               ([RaportPlik])
                         VALUES
                               (@File)
                        SELECT [RaportID] FROM [dbo].[Raporty]
            WHERE [RaportID] = SCOPE_IDENTITY()
                    ";
            using (SqlConnection SqlConn = new SqlConnection(ConnStr))
            using (SqlCommand command = SqlConn.CreateCommand())
            {
                command.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;

                using (var sqlWriteQuery = command.ExecuteReader())
                    while (sqlWriteQuery != null && sqlWriteQuery.Read())
                    {
                        varID = sqlWriteQuery["RaportID"] is int ? (int)sqlWriteQuery["RaportID"] : 0;
                    }
            }
            return varID;
        }
    }
}
