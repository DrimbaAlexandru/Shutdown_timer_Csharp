using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        bool is_window_open = false;
        bool is_shutdown_engaged=false;
        private DateTime shutdown_time;


        public Form1()
        {
            InitializeComponent();
            lbl_shutdown_time.Text = "DEZACTIVAT";
            Time_picker.Value = DateTime.Now;
            is_window_open = true;
            Thread othread = new Thread(new ThreadStart(Clock_Thread));
            othread.Start();

        }
        delegate void SetTextCallback();

        private void update_current_time()
        {
            if (this.lbl_time.InvokeRequired)
            {
                try
                {
                    SetTextCallback d = new SetTextCallback(update_current_time);
                    this.Invoke(d, new object[] { });
                }
                catch (ObjectDisposedException e)
                { 
                    Console.Write(e.ToString()); 
                }

            }
            else
            {
                this.lbl_time.Text = System.DateTime.Now.ToLongTimeString();
                if (is_window_open == false)
                    Close();
            }
        }

        private void Clock_Thread()
        {
            while (is_window_open)
            {
                if ((is_shutdown_engaged == true) && (DateTime.Now >= shutdown_time) && (DateTime.Now <= shutdown_time.AddSeconds(5)))
                {
                    try
                    {
                        Process proc=new Process();
                        proc.StartInfo.Arguments = "-s -f -t 0";
                        proc.StartInfo.FileName = "shutdown";
                        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        proc.Start();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    is_window_open = false;
                }
                else
                    Thread.Sleep(250);
                update_current_time();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            is_window_open = false;
        }

        private void btn_cancel_shutdown_Click(object sender, EventArgs e)
        {
            is_shutdown_engaged = false;
            lbl_shutdown_time.Text = "DEZACTIVAT";
        }

        private void btn_set_shutdown_Click(object sender, EventArgs e)
        {
            shutdown_time = Time_picker.Value;
            is_shutdown_engaged = true;
            lbl_shutdown_time.Text = shutdown_time.ToLongTimeString();
        }
    }
}
