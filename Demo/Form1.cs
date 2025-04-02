namespace Demo
{
    public partial class Form1 : Form
    {
        public PLCSetting CurrentPLCSettings { get; set; } = new PLCSetting();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitPLC();
        }

        private async void PlcTriggerValueChanged(object sender, Gentex.IO.AllenBradley.SymbolEventArgs e)
        {
            try
            {
                var readTrig = Convert.ToBoolean(e.Value);
                if (readTrig)
                {
                    await Task.Run(() => Console.WriteLine($"PLC Trigger Changed at {DateTime.Now.ToString()}"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error in PlcTriggerValueChanged: {ex.Message} ");
            }
        }

        private async void PlcPartNumberValueChanged(object sender, Gentex.IO.AllenBradley.SymbolEventArgs e)
        {
            try
            {
                await Task.Run(() => Console.WriteLine($"Part Number Changed: {e.Value}"));
                if (labelPartNumber.InvokeRequired)
                {
                    // Use Invoke to call the method on the UI thread
                    labelPartNumber.Invoke(new Action(() => labelPartNumber.Text = e.Value.ToString()));
                }
                else
                {
                    // If already on the UI thread, update the label directly
                    labelPartNumber.Text = e.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error PlcPartNumberValueChanged: {ex.Message}");
            }
        }

        private async void PlcHeartBeatValueChanged(object sender, Gentex.IO.AllenBradley.SymbolEventArgs e)
        {
            try
            {
                await Task.Run(() => Console.WriteLine($"HeartBeat Changed: {e.Value}"));

                if (btnHeartBeat.InvokeRequired)
                {
                    // Use Invoke to call the method on the UI thread
                    btnHeartBeat.Invoke(new Action(() => btnHeartBeat.Text = e.Value.ToString()));
                }
                else
                {
                    // If already on the UI thread, update the label directly
                    btnHeartBeat.Text = e.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error PlcHeartBeatValueChanged: {ex.Message}");
            }
        }

        private void InitPolling()
        {
            try
            {
                tmrPLCHeartbeat.Interval = 5000;
                tmrPLCHeartbeat.Enabled = true;

                //add to polling for PLC tags
                PLCHelper.PLCClient.ReadTag(CurrentPLCSettings.PartNumberTag, true, true);
                PLCHelper.PLCClient.ReadTag(CurrentPLCSettings.HeartBeatTag, true, true);
                PLCHelper.PLCClient.ReadTag(CurrentPLCSettings.TriggerTag, true, true);

                //setup PLC tag change event handlers. 
                PLCHelper.PLCClient.Symbols[CurrentPLCSettings.PartNumberTag].ValueChanged -= plcPartNumberValueChanged!;
                PLCHelper.PLCClient.Symbols[CurrentPLCSettings.PartNumberTag].ValueChanged += plcPartNumberValueChanged!;

                PLCHelper.PLCClient.Symbols[CurrentPLCSettings.HeartBeatTag].ValueChanged -= plcHeartBeatValueChanged!;
                PLCHelper.PLCClient.Symbols[CurrentPLCSettings.HeartBeatTag].ValueChanged += plcHeartBeatValueChanged!;

                PLCHelper.PLCClient.Symbols[CurrentPLCSettings.TriggerTag].ValueChanged -= plcTriggerValueChanged!;
                PLCHelper.PLCClient.Symbols[CurrentPLCSettings.TriggerTag].ValueChanged += plcTriggerValueChanged!;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void plcTriggerValueChanged(object sender, Gentex.IO.AllenBradley.SymbolEventArgs e)
        {
            try
            {
                var readTrig = Convert.ToBoolean(e.Value);
                if (readTrig)
                {
                    Console.WriteLine($"PLC Trigger Changed at {DateTime.Now.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"errror in plcTriggerValueChange: {ex.Message} ");
            }
        }

        private async void plcPartNumberValueChanged(object sender, Gentex.IO.AllenBradley.SymbolEventArgs e)
        {
            try
            {
                Console.WriteLine($"Part Number Changed: {e.Value}");
                if (labelPartNumber.InvokeRequired)
                {
                    // Use Invoke to call the method on the UI thread
                    labelPartNumber.Invoke(new Action(() => labelPartNumber.Text = e.Value.ToString()));
                }
                else
                {
                    // If already on the UI thread, update the label directly
                    labelPartNumber.Text = e.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error plcPartNumberValueChanged: {ex.Message}");
            }
        }

        private async void plcHeartBeatValueChanged(object sender, Gentex.IO.AllenBradley.SymbolEventArgs e)
        {
            try
            {
                Console.WriteLine($"HeartBeat Changed: {e.Value}");

                if (btnHeartBeat.InvokeRequired)
                {
                    // Use Invoke to call the method on the UI thread
                    btnHeartBeat.Invoke(new Action(() => btnHeartBeat.Text = e.Value.ToString()));
                }
                else
                {
                    // If already on the UI thread, update the label directly
                    btnHeartBeat.Text = e.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error plcHeartBeatValueChanged: {ex.Message}");
            }
        }

        private void btnHeartBeat_Click(object sender, EventArgs e)
        {

        }

        private void labelPartNumber_Click(object sender, EventArgs e)
        {

        }
    }

}
