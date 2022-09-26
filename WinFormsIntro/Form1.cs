using WinFormsIntro.Properties;

namespace WinFormsIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void TimerTick(object? sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }



        private void btn_clickMe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Clicked", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                btn_clickMe.Text = "Yes";
            else if (result == DialogResult.No)
                btn_clickMe.Text = "No";

        }



        private void btn_clickMe_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                BackColor = SystemColors.ActiveBorder;
            else if (e.Button == MouseButtons.Right)
                this.BackColor = Color.Green;
            else
                BackColor = Color.FromArgb(7, 138, 93);
            // BackColor = Color.FromKnownColor(KnownColor.Transparent);
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Text = $"X:{e.X}  Y:{e.Y}";
            Text = e.Location.ToString();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // var timer = new System.Windows.Forms.Timer();
            // timer.Interval = 1000;
            // timer.Tick += TimerTick;
            // 
            // timer.Start();
            // // timer.Stop();


            BackgroundImage = Resources.Azerbaijan_Satellite_Map;
        }




        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_EnterLeave.ForeColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_EnterLeave.ForeColor = Color.Green;
        }







        private bool _state = false;
        private void button2_Click(object sender, EventArgs e)
        {
            btn_State.BackColor = _state ? Color.Red : Color.Blue;

            // button2.BackColor = _state switch 
            // { 
            //     true => Color.Red,
            //     false => Color.Blue
            // };

            _state = !_state;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Random.Shared.Next(150, 850);
            int y = Random.Shared.Next(100, 630);


            Label label = new Label
            {
                BackColor = Color.GreenYellow,
                Location = new Point(x, y),
                Size = new Size(50, 30),
                Text = "New Label"
            };



            label.Click += (s, e) => (s as Label)?.Dispose();
            
            Controls.Add(label);
        }


    }
}