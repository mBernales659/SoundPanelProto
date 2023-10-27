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
            //panel2.Dock = DockStyle.Fill;
            //panel3.Dock = DockStyle.Fill;
            //panel4.Dock = DockStyle.Fill;
            //panel5.Dock = DockStyle.Fill;

            LoadablePnl1.Dock = DockStyle.Fill;
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
                PanelContainer3.Controls.Add(LoadablePnl1);
                LoadablePnl1.Visible = true;

                PanelContainer4.Controls.Add(panel1);
                PanelContainer3.Controls.Remove(panel1);

            }
            else
            {

                LoadablePnl1.Visible = false;
            }

            dock();
        }


    }
}