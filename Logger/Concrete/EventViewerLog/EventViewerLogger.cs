using Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger.Concrete.EventViewerLog
{
    public class EventViewerLogger : ILogger
    {
        public void Write(string message)
        {
            MessageBox.Show("EventViewerLogger : " + message);
        }

        public void Write(Exception ex)
        {
            MessageBox.Show("EventViewerLogger : " + ex.Message);
        }
    }
}
