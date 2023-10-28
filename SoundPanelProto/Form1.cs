namespace SoundPanelProto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dock()
        {
            AddSoundPnl.Dock = DockStyle.Fill;

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

                PanelContainer4.Controls.Add(AddSoundPnl);

                dock();
            }

            else if (AddSoundPnl.Parent == PanelContainer4)
            {
                PanelContainer4.Controls.Remove(AddSoundPnl);

                PanelContainer5.Controls.Add(AddSoundPnl);

                dock();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

    }
}