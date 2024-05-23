using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oksana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            long totalMemory = GC.GetTotalMemory(false);
            double memoryInMegabytes = totalMemory / (1024.0);
            textBox1.Text = $"Используемая память: {memoryInMegabytes:F1} МБ";
            //12312323131231322312312312
            //wsdfsdfsdfsdf
        }
    }
}