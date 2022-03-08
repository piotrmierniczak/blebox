using blebox.library;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blebox.Forms
{
    public partial class wLightBoxForm : Form
    {
        public string Url { get; set; } = "http://192.168.18.88";
        ControlState ControlState;
        private static readonly HttpClient httpClient = new HttpClient();
        private Thread threadGet = new Thread(() => { });
        private Thread threadPost = new Thread(() => { });
        bool postWait = false;
        bool settingsInProgress = false;
        public wLightBoxForm()
        {
            InitializeComponent();
            infoToolTip.SetToolTip(closeLabel, "Zamknij");
            ControlState = new ControlState();
            timerPost.Start();
        }

        #region MoveFormWithoutBorder
        private bool mouseDown;
        private Point lastLocation;
        private void FMouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void FMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void FMouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void Close_MouseClick(object sender, MouseEventArgs e) => Close();

        private async void AddressButton_Click(object sender, EventArgs e)
        {
            try
            {
                var state = await httpClient.GetStringAsync(Url + "/api/rgbw/state");
                ControlState = new ControlState(state);
                SetFormControlsLikeControlState();
                connectionStatusLabel.Text = "OK";
                connectionStatusLabel.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show("Brak połączenia ze sterownikiem.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFormControlsLikeControlState()
        {
            settingsInProgress = true;
            string desiredColor = ControlState.Rgbw.DesiredColor;
            string channel1 = desiredColor.Substring(0, 2);
            channel1TrackBar.Value = int.Parse(channel1, System.Globalization.NumberStyles.HexNumber);
            string channel2 = desiredColor.Substring(2, 2);
            channel2TrackBar.Value = int.Parse(channel2, System.Globalization.NumberStyles.HexNumber);
            string channel3 = desiredColor.Substring(4, 2);
            channel3TrackBar.Value = int.Parse(channel3, System.Globalization.NumberStyles.HexNumber);
            string channel4 = desiredColor.Substring(6, 2);
            channel4TrackBar.Value = int.Parse(channel4, System.Globalization.NumberStyles.HexNumber);
            try
            {
                string channel5 = desiredColor.Substring(8, 2);
                channel1TrackBar.Value = int.Parse(channel5, System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                //work only with wLightBox v.3 (RGBWW)
            }
            settingsInProgress = false;
        }

        private void TimerPost_Tick(object sender, EventArgs e)
        {
            if (!threadPost.IsAlive && postWait && !settingsInProgress)
            {
                postWait = false;
                threadPost = new Thread(() => PostAsync());
                threadPost.Start();
            }
        }

        private async Task PostAsync()
        {
            string json = JsonConvert.SerializeObject(ControlState);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync(Url + "/api/rgbw/set", data);
        }

        private void SetDesiredColor(string desiredColor)
        {
            try
            {
                ControlState.Rgbw.DesiredColor = desiredColor;
                postWait = true;
            }
            catch
            {
                //desiredColor.Length do not work on wLightBox v.2
            }
        }

        #region RGBWW
        private void Channel1TrackBar_ValueChanged(object sender, EventArgs e)
        {
            int value = channel1TrackBar.Value;
            channel1ValueLabel.Text = value.ToString();
            string hexValue = value.ToString("X2");
            string desiredColor = ControlState.Rgbw.DesiredColor;
            string newDesiredColor = hexValue + desiredColor.Substring(2);
            SetDesiredColor(newDesiredColor);
        }

        private void Channel2TrackBar_ValueChanged(object sender, EventArgs e)
        {
            int value = channel2TrackBar.Value;
            channel2ValueLabel.Text = value.ToString();
            string hexValue = value.ToString("X2");
            string desiredColor = ControlState.Rgbw.DesiredColor;
            string newDesiredColor = desiredColor.Substring(0, 2) + hexValue + desiredColor.Substring(4);
            SetDesiredColor(newDesiredColor);
        }

        private void Channel3TrackBar_ValueChanged(object sender, EventArgs e)
        {
            int value = channel3TrackBar.Value;
            channel3ValueLabel.Text = value.ToString();
            string hexValue = value.ToString("X2");
            string desiredColor = ControlState.Rgbw.DesiredColor;
            string newDesiredColor = desiredColor.Substring(0, 4) + hexValue + desiredColor.Substring(6);
            SetDesiredColor(newDesiredColor);
        }

        private void Channel4TrackBar_ValueChanged(object sender, EventArgs e)
        {
            int value = channel4TrackBar.Value;
            channel4ValueLabel.Text = value.ToString();
            string hexValue = value.ToString("X2");
            string desiredColor = ControlState.Rgbw.DesiredColor;
            string newDesiredColor = desiredColor.Substring(0, 6) + hexValue + desiredColor.Substring(8);
            SetDesiredColor(newDesiredColor);
        }

        private void Channel5TrackBar_ValueChanged(object sender, EventArgs e)
        {
            int value = channel5TrackBar.Value;
            channel5ValueLabel.Text = value.ToString();
            string hexValue = value.ToString("X2");
            string desiredColor = ControlState.Rgbw.DesiredColor;
            string newDesiredColor = desiredColor.Substring(0, 8) + hexValue;
            SetDesiredColor(newDesiredColor);
        }
        #endregion

        #region FavColors
        private void RedButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.RED);
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.GREEN);
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.BLUE);
        }

        private void WhiteWarmButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.WHITE_WARM);
        }

        private void WhiteColdButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.WHITE_COLD);
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.OFF);
        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.PINK);

        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.YELLOW);
        }
        private void CyanButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.CYAN);
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.ORANGE);
        }

        private void AzureButton_Click(object sender, EventArgs e)
        {
            SetDesiredColor(FavColors.AZURE);
        }
        #endregion

        private void SetEffectID(EffectNames effectNames)
        {
            ControlState.Rgbw.EffectID = effectNames;
            postWait = true;
        }

        #region Effects
        private void NoneButton_Click(object sender, EventArgs e)
        {
            SetEffectID(EffectNames.NONE);
        }

        private void FadeButton_Click(object sender, EventArgs e)
        {
            SetEffectID(EffectNames.FADE);
        }

        private void RgbButton_Click(object sender, EventArgs e)
        {
            SetEffectID(EffectNames.RGB);
        }

        private void PoliceButton_Click(object sender, EventArgs e)
        {
            SetEffectID(EffectNames.POLICE);
        }

        private void RelaxButton_Click(object sender, EventArgs e)
        {
            SetEffectID(EffectNames.RELAX);
        }

        private void StroboButton_Click(object sender, EventArgs e)
        {
            SetEffectID(EffectNames.STROBO);
        }

        private void BellButton_Click(object sender, EventArgs e)
        {
            SetEffectID(EffectNames.BELL);
        }
        #endregion

    }
}
