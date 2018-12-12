using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class UserControlITimeRangeObjectTuning : UserControl
    {
        private Action<List<ITimeRangeObject>, int> _CallBack;
        private List<ITimeRangeObject> _originalTimeRangeObjects;
        private List<ITimeRangeObject> _changesTimeRangeObjects;
        private List<SimpleTimeRangeObject> _copyTimeRangeObjects;
        private TimeRangesEditMediator _timeRangesEditMediator;
        private bool _isMove = false;
        public UserControlITimeRangeObjectTuning()
        {
            //InitializeComponent();
        }
        public void InitializeInfo(Action<List<ITimeRangeObject>, int> CallBack,
            List<ITimeRangeObject> timeRangeObjects)
        {
            InitializeComponent();
            _CallBack = CallBack;
            _originalTimeRangeObjects = timeRangeObjects;
            _copyTimeRangeObjects = SimpleTimeRangeObject.Converting(timeRangeObjects);
            _timeRangesEditMediator = new TimeRangesEditMediator(new TimeRangesChartEdit(_copyTimeRangeObjects, chart1), userControlITimeRangeObjectEdit1);

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            SimplestLogic();
            _CallBack(_changesTimeRangeObjects, 1);
        }
        private void SimplestLogic()
        {
            _changesTimeRangeObjects = new List<ITimeRangeObject>();
            //_originalTimeRangeObjects.ForEach(x => _changesTimeRangeObjects.Add(new SimpleTimeRangeObject(x)));
            foreach (var originalTimeRangeObject in _originalTimeRangeObjects)
            {
                var copyTimeRangeobject = new SimpleTimeRangeObject(originalTimeRangeObject);
                _changesTimeRangeObjects.Add(copyTimeRangeobject);
            }
        }

        private void ChartMouseMove(object sender, MouseEventArgs e)
        {
            _timeRangesEditMediator.ChartMouseMove(sender, e, _isMove);
        }

        private void ChartMouseDown(object sender, MouseEventArgs e)
        {
            _isMove = _timeRangesEditMediator.ChartMouseDown(sender, e);
        }

        private void ChartMouseUp(object sender, MouseEventArgs e)
        {
            _isMove = false;
            _timeRangesEditMediator.ChartMouseUp();
        }
    }
}
