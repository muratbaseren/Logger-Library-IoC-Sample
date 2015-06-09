using Logger.Abstract;
using Logger.Concrete.DatabaseLog;
using Logger.Concrete.FileLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoCSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FileLogger fileLogger = new FileLogger();
            //fileLogger.Write("Button 1 'e basıldı.");

            //ILogger logger = new DatabaseLogger();
            //logger.Write("Button 1 'e basıldı.");

            ILogger logger = LoggerFactory.Container.Resolve<ILogger>();
            logger.Write("Button 1 'e basıldı.");
        }
    }
}
