using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Attempt1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : TabbedPage
    {
        private System.Timers.Timer timer = new Timer();
        int time;
        public TestPage()
        {
            InitializeComponent();
            timer = new Timer();
        }
        private void Run(object sender, EventArgs e)
        {
            timer.Interval = 1;
            timer.Elapsed += Timer_count;
            timer.Enabled = true;
        }
        private void Timer_count(object sender, EventArgs e)
        {
            time++;
            Numbers.Text = time.ToString();
        }
        private void Stop(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}