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
            panel1.Dock = DockStyle.Fill;

            LoadablePnl1.Dock = DockStyle.Fill;
            LoadablePnl2.Dock = DockStyle.Fill;
        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {
            if (panel1.Parent == PanelContainer3)
            {
                PanelContainer3.Controls.Remove(panel1);

                PanelContainer4.Controls.Add(panel1);

                dock();
            }

            else if (panel1.Parent == PanelContainer4)
            {
                PanelContainer4.Controls.Remove(panel1);

                PanelContainer5.Controls.Add(panel1);

                dock();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                PanelContainer4.Controls.Add(LoadablePnl2);
                LoadablePnl2.Visible = true;

                PanelContainer2.Controls.Add(LoadablePnl2);
            }
            else
            {
                LoadablePnl2.Visible = false;
            }

            dock();

        }



    }
}