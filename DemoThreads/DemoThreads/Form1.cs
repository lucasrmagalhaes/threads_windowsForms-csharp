using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace DemoThreads
{
    public partial class Frm_DemoThread : Form
    {
        private Thread trd;

        public Frm_DemoThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a thread principal do programa");
        }

        private void pgbThreads_Click(object sender, EventArgs e)
        {
            int stp;
            int novoValor;

            Random rnd = new Random();

            while (true)
            {
                stp = this.pgbThreads.Step * rnd.Next(-1, 2);
                novoValor = this.pgbThreads.Value + stp;

                if (novoValor > this.pgbThreads.Maximum)
                    novoValor = this.pgbThreads.Maximum;
                else if (novoValor < this.pgbThreads.Minimum)
                    novoValor = this.pgbThreads.Minimum;

                this.pgbThreads.Value = novoValor;

                Thread.Sleep(100);
            }
        }

        private void Frm_DemoThread_Load(object sender, EventArgs e)
        {
            Thread trd = new Thread(new ThreadStart(this.ThreadTarefa));

            trd.IsBackground = true;
            trd.Start();
        }

        private void ThreadTarefa()
        {
            int stp;
            int novoValor;

            Random rnd = new Random();

            while (true)
            {
                stp = this.pgbThreads.Step * rnd.Next(-1, 2);
                novoValor = this.pgbThreads.Value + stp;

                if (novoValor > this.pgbThreads.Maximum)
                    novoValor = this.pgbThreads.Maximum;
                else if (novoValor < this.pgbThreads.Minimum)
                    novoValor = this.pgbThreads.Minimum;

                SetControlPropertyValue(pgbThreads, "value", novoValor);

                Thread.Sleep(100);
            }
        }
        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);

        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);

                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();

                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }
    }
}
