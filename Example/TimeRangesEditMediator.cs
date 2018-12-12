using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public class TimeRangesEditMediator
    {
        private TimeRangesChartEdit _timeRangesChartEdit;
        private UserControlITimeRangeObjectEdit _timeRangeObjectEdit;
        private SimpleTimeRangeObject _currentSelectedTimeRangeObject;

        public TimeRangesEditMediator(TimeRangesChartEdit timeRangesChartEdit, UserControlITimeRangeObjectEdit timeRangeObjectEdit)
        {
            _timeRangesChartEdit = timeRangesChartEdit;
            _timeRangeObjectEdit = timeRangeObjectEdit;
            timeRangeObjectEdit.SetCallBackSomethingChanged(OnTimeRangeObjectChanges);
            timeRangesChartEdit.SetCallBackSomethingChanged(OnTimeRangeChartChanges);
        }

        public bool ChartMouseDown(object sender, MouseEventArgs e)
        {
            var newCurrentTimeRangeObject = _timeRangesChartEdit.ChartMouseDown(sender, e);
            if (newCurrentTimeRangeObject != _currentSelectedTimeRangeObject && newCurrentTimeRangeObject != null)
            {
                _currentSelectedTimeRangeObject = newCurrentTimeRangeObject;
                _timeRangeObjectEdit.SetCurrentItem(_currentSelectedTimeRangeObject);
                return true;
            }
            return false;
        }
        public void ChartMouseUp()
        {
            _currentSelectedTimeRangeObject = null;
        }

        public void ChartMouseMove(object sender, MouseEventArgs e, bool isMove)
        {
            _timeRangesChartEdit.ChartMouseMove(sender, e, isMove);
        }

        private void OnTimeRangeObjectChanges(SimpleTimeRangeObject timeRangeObject)
        {
            _timeRangesChartEdit.UpdateSeries(timeRangeObject);
        }

        private void OnTimeRangeChartChanges(SimpleTimeRangeObject timeRangeObject)
        {
            _timeRangeObjectEdit.SetCurrentItem(timeRangeObject);
        }
    }
}
