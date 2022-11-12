namespace AppTracker
{
    public partial class App_Tracker : Form
    {
        bool TimerActive = false;
        bool SettingActive = false;
        bool PScannedActive = false;
        bool CScanActive = false;

       
        int ms = 0;
        int s = 0;
        int m = 0;
        int hr = 0;
        public App_Tracker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximise_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimise_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void move_form_area_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_move_area_Click(object sender, MouseEventArgs e)
        {
            
        }

        private void timer_button_Click(object sender, EventArgs e)
        {
            title_label.Text = "App Tracker - Timer";
            TimerActive = true;
            SettingActive = false;
            PScannedActive = false;
            CScanActive = false;
            RefreshMidPanel();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            title_label.Text = "App Tracker - Settings"; 
            TimerActive = false;
            SettingActive = true;
            PScannedActive = false;
            CScanActive = false;
            RefreshMidPanel();
        }

        private void background_app_tracker_button_Click(object sender, EventArgs e)
        {
            title_label.Text = "App Tracker - Previous Recording's";
            TimerActive = false;
            SettingActive = false;
            PScannedActive = true;
            CScanActive = false;
            RefreshMidPanel();
        }

        private void cur_apps_recording_button_Click(object sender, EventArgs e)
        {
            title_label.Text = "App Tracker - Current Recording";
            TimerActive = false;
            SettingActive = false;
            PScannedActive = false;
            CScanActive = true;
            RefreshMidPanel();
        }

        private void RefreshMidPanel()
        {
            if (TimerActive)
            {
                timer_label.Visible = true;
                timer_start_button.Visible = true;
            } else
            {
                timer_label.Visible = false;
                timer_start_button.Visible = false;
            }
        }

        private void StopWatchTimer_Tick(object sender, EventArgs e)
        {

            ms = ms + 16;
            //m ++;
            
            if (ms >= 1000)
            {
                ms = 0;
                s++;
            }
            if(s >= 60)
            {
                s = 0;
                m++;
            }
            if(m >= 60)
            {
                m = 0;
                hr++;
            }

            timer_label.Text = hr.ToString() + ":" + m.ToString() + ":" + s.ToString();
            

        }

        private void timer_start_button_Click(object sender, EventArgs e)
        {
            
            StopWatchTimer.Enabled = true;
        }
    }
}