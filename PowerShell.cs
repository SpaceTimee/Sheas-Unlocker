using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sheas_Unlocker
{
    internal class PowerShell : SheasCore.Proc
    {
        private readonly MainForm MAIN_FORM;
        private bool IS_SUCCESSFUL = true;

        internal PowerShell(MainForm mainForm) : base("powershell")
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            MAIN_FORM = mainForm;
        }

        public override void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) => OutputError(e);
        public override void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e) => OutputError(e);
        public override void Process_Exited(object sender, EventArgs e)
        {
            if (IS_SUCCESSFUL)
                MAIN_FORM.Text = "解锁成功";
        }

        private void OutputError(DataReceivedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Data))
            {
                IS_SUCCESSFUL = false;
                MAIN_FORM.Text = "解锁失败";

                if (!MAIN_FORM.IgnoreCheckBox.Checked)
                    MessageBox.Show("Error: " + e.Data);
            }
        }
    }
}