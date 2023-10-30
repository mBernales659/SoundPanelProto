using System.Data.SqlClient;
using System.Numerics;
using System.Windows.Forms;
using WMPLib;


namespace SoundPanelProto
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        string connectionString = "Data Source=DESKTOP-VIJ33BO\\SQLEXPRESS; Initial Catalog=Mellowdy; Integrated Security=True";
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void dock()
        {
            AddSoundPnl.Dock = DockStyle.Fill;

            DefaultSoundPnl2.Dock = DockStyle.Fill;

            LoadablePnl1.Dock = DockStyle.Fill;
            LoadablePnl2.Dock = DockStyle.Fill;
        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {
            if (LoadablePnl1.Parent == PanelContainer1)
            {
                PanelContainer1.Controls.Remove(LoadablePnl1);
                PanelContainer2.Controls.Add(LoadablePnl1);

                dock();
            }

            else if (AddSoundPnl.Parent == PanelContainer3)
            {
                PanelContainer3.Controls.Remove(AddSoundPnl);

                PanelContainer2.Controls.Add(DefaultSoundPnl1);
                PanelContainer3.Controls.Add(DefaultSoundPnl2);
                PanelContainer4.Controls.Add(AddSoundPnl);

                dock();
            }

            else if (AddSoundPnl.Parent == PanelContainer4)
            {
                PanelContainer4.Controls.Remove(AddSoundPnl);

                PanelContainer3.Controls.Add(DefaultSoundPnl1);
                PanelContainer4.Controls.Add(DefaultSoundPnl2);
                PanelContainer5.Controls.Add(AddSoundPnl);

                dock();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelContainer1.Controls.Clear();
            PanelContainer2.Controls.Clear();
            PanelContainer3.Controls.Clear();
            PanelContainer4.Controls.Clear();
            PanelContainer5.Controls.Clear();

            PanelContainer3.Controls.Add(AddSoundPnl);
            PanelContainer2.Controls.Add(DefaultSoundPnl2);
            PanelContainer1.Controls.Add(DefaultSoundPnl1);


            connection = new SqlConnection(connectionString);

            media_retriever mr = new media_retriever();

            train();

            string SoundTitleLabel2 = DefaultSoundFileNameLbl2.Text;
            mr.AvatarRetriever(SoundTitleLabel2, DefaultSoundPicbox2);

            //kung ang filename label sa loadable panel ay not equal sa null ay iaadd niya ito sa panelconatiner

            if (FilenameLbl1.Text != "null")
            {
                PanelContainer1.Controls.Add(LoadablePnl1);
                LoadablePnl1.Visible = true;
            }
            else
            {
                LoadablePnl1.Visible = false;
            }

            if (FilenameLbl2.Text != "null")
            {
                PanelContainer2.Controls.Add(LoadablePnl2);
                LoadablePnl2.Visible = true;
            }
            else
            {
                LoadablePnl2.Visible = false;
            }

            if (FilenameLbl3.Text != "null")
            {
                PanelContainer3.Controls.Add(LoadablePnl3);
                LoadablePnl3.Visible = true;
            }
            else
            {
                LoadablePnl3.Visible = false;
            }

            if (FilenameLbl4.Text != "null")
            {
                PanelContainer4.Controls.Add(LoadablePnl4);
                LoadablePnl4.Visible = true;
            }
            else
            {
                LoadablePnl4.Visible = false;
            }

            if (FilenameLbl5.Text != "null")
            {
                PanelContainer5.Controls.Add(LoadablePnl5);
                LoadablePnl5.Visible = true;
            }
            else
            {
                LoadablePnl5.Visible = false;
            }

            //kung simula FilenameLbl1 hangang FilenameLbl5 ay not equal sa null ay ireremove nya ang AddSoundPnl sa lahat ng panelcontainer

            for (int i = 1; i <= 15; i++)
            {
                Control panelContainer = this.Controls.Find("PanelContainer" + i, true).FirstOrDefault();
                Label filenameLabel = this.Controls.Find("FilenameLbl" + i, true).FirstOrDefault() as Label;

                if (panelContainer != null && filenameLabel != null && filenameLabel.Text != "null")
                {
                    panelContainer.Controls.Remove(AddSoundPnl);
                }
            }

            dock();
        }


        string selectedFilePath = string.Empty;

        private void opnfiledialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sound Files|*.mp3;*.wav;*.ogg;*.flac|All Files|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName; // I-assign ang selected file path sa variable na ito.

                // I-display ang pangalang ng file sa Label1.
                label1.Text = Path.GetFileName(selectedFilePath);

                panel1.Visible = true;
                panel1.BringToFront();

            }
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

            opnfiledialog();

        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                byte[] fileData = File.ReadAllBytes(selectedFilePath);


                byte[] imageBytes = null; // Initiate it as null.

                // Check if PictureBox7 has an image
                if (soundpicbox.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        soundpicbox.Image.Save(ms, soundpicbox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                connection.Open();

                // Get the highest SoundID
                SqlCommand getMaxSoundID = new SqlCommand("SELECT MAX(SoundID) FROM Sounds", connection);
                object result = getMaxSoundID.ExecuteScalar();

                int maxSoundID;

                if (result != DBNull.Value)
                {
                    maxSoundID = Convert.ToInt32(result);
                }
                else
                {
                    maxSoundID = 0;
                }

                // Create a new SoundID
                int newSoundID = maxSoundID + 1;
                string soundTitle = textBox1.Text;


                SqlCommand cmd = new SqlCommand("INSERT INTO Sounds (FileName, SoundTitle, SoundData, ImageData) VALUES (@FileName, @SoundTitle, @SoundData, @ImageData)", connection);
                cmd.Parameters.AddWithValue("@FileName", Path.GetFileName(selectedFilePath));
                cmd.Parameters.AddWithValue("@SoundTitle", soundTitle);
                cmd.Parameters.AddWithValue("@SoundData", fileData);
                cmd.Parameters.AddWithValue("@ImageData", imageBytes); // Add parameter for ImageData
                cmd.ExecuteNonQuery();

                connection.Close();

                if (newSoundID > 0)
                {
                    MessageBox.Show(soundTitle + " has inserted successfully.");
                    panel1.SendToBack();
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to insert the sound file.");
                }
            }
            else
            {
                MessageBox.Show("Select a sound file using TableLayoutPanel1 before clicking the Insert button.");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DefaultSoundBtn1_Click(object sender, EventArgs e)
        {
            media_retriever mr = new media_retriever();
            int soundIDToPlay = 1;
            mr.PlaySound(soundIDToPlay);
        }

        private void train()
        {
            media_retriever mr = new media_retriever();
            int defaultSoundID = 1;


            string defaultFileName = mr.GetFileNameBySoundID(defaultSoundID);


            if (!string.IsNullOrEmpty(defaultFileName))
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(defaultFileName);
                DefaultSoundFileNameLbl2.Text = fileNameWithoutExtension;
            }
            else
            {
                DefaultSoundFileNameLbl2.Text = "No Sound Selected";
            }

        }

        private void soundpicbox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // I-load ang napiling larawan mula sa OpenFileDialog sa soundpicbox
                        soundpicbox.Image = new Bitmap(openFileDialog.FileName);
                        soundpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hindi mabuksan ang larawan: " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            opnfiledialog();
        }
    }
}