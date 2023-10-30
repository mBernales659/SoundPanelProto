using System;
using System.Data.SqlClient;
using System.IO;
using WMPLib;
using System.Windows.Forms;

namespace SoundPanelProto
{
    public class media_retriever
    {
        SqlConnection connection;
        string connectionString = "Data Source=DESKTOP-VIJ33BO\\SQLEXPRESS; Initial Catalog=Mellowdy; Integrated Security=True";
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();

        public media_retriever()
        {
            connection = new SqlConnection(connectionString);
        }

        public void PlaySound(int soundIDToPlay)
        {
            string filePath = GetFilePathBySoundID(soundIDToPlay);

            if (!string.IsNullOrEmpty(filePath))
            {
                Player.URL = filePath;
                Player.controls.play();
            }
            else
            {
                MessageBox.Show("Sound file not found");
            }
        }

        public string GetFileNameBySoundID(int soundID)
        {
            string fileName = null;

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT SoundTitle FROM Sounds WHERE SoundID = @SoundID", connection);
            cmd.Parameters.AddWithValue("@SoundID", soundID);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    fileName = reader["SoundTitle"].ToString();
                }
            }

            connection.Close();

            return fileName;
        }

        public string GetFilePathBySoundID(int soundID)
        {
            string filePath = null;

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT SoundData FROM Sounds WHERE SoundID = @SoundID", connection);
            cmd.Parameters.AddWithValue("@SoundID", soundID);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    byte[] fileData = (byte[])reader["SoundData"];
                    string tempFileName = Path.GetTempFileName();
                    string mp3TempFileName = Path.ChangeExtension(tempFileName, ".mp3");
                    File.WriteAllBytes(mp3TempFileName, fileData);
                    filePath = mp3TempFileName;
                }
            }

            connection.Close();

            return filePath;
        }
    }
}
