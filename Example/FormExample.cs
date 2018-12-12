using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class FormExample : Form
    {
        public FormExample()
        {
            InitializeComponent();
        }

        private void ShowTimeRangeObjects(List<ITimeRangeObject> timeRangeObjects, int count)
        {
            listBox1.Items.Clear();
            foreach (var timeRangeObject in timeRangeObjects)
            {
                listBox1.Items.Add(timeRangeObject);
            }
        }       

        private void ButtonClick(object sender, EventArgs e)
        {
            var timeRangeList = new List<ITimeRangeObject>()
            {
                new SimpleTimeRangeObject(new DateTime(2018,10,18,12,00,0), new DateTime(2018,10,18,12,10,0), 0),
                new SimpleTimeRangeObject(new DateTime(2018,10,18,12,30,0), new DateTime(2018,10,18,12,40,0), 1),
                new SimpleTimeRangeObject(new DateTime(2018,10,18,12,20,0), new DateTime(2018,10,18,12,30,0), 2)
            };

            userControlITimeRangeObjectTuning1.InitializeInfo(ShowTimeRangeObjects, timeRangeList);
        }
        
    }
}
