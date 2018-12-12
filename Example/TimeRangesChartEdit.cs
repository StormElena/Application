using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Example
{
    public class TimeRangesChartEdit
    {
        private Chart _chart;
        private List<SimpleTimeRangeObject> _timeRangeObjects;
        private List<HitTestResult> _results;
        private Action<SimpleTimeRangeObject> _CallBack;

        public TimeRangesChartEdit(List<SimpleTimeRangeObject> copyTimeRangeObjects, Chart chart)
        {
            _timeRangeObjects = copyTimeRangeObjects;
            _chart = chart;
            AddToTheChart();
        }

        public void SetCallBackSomethingChanged(Action<SimpleTimeRangeObject> CallBack)
        {
            _CallBack = CallBack;
        }

        private void AddToTheChart()
        {
            _chart.Series.Clear();
            foreach (var timeRangeObject in _timeRangeObjects)
            {
                AddTheSeriesToTheChart(timeRangeObject);
            }
        }

        private void AddTheSeriesToTheChart(SimpleTimeRangeObject timeRangeObject)
        {
            var series = new Series()
            {
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle,
                MarkerColor = Color.Black,
                MarkerSize = 10,
                BorderWidth = 4,
                Color = Color.Red
            };

            series.Points.AddXY(timeRangeObject.GetStartTimeUtc(), timeRangeObject.GetEntityId());
            series.Points.AddXY(timeRangeObject.GetEndTimeUtc(), timeRangeObject.GetEntityId());
            series.Tag = timeRangeObject;
            _chart.Series.Add(series);
        }

        public void UpdateSeries(SimpleTimeRangeObject timeRangeObject)
        {

            if (_chart.Series.ToList().Find(x => (x.Tag as SimpleTimeRangeObject) == timeRangeObject) != null) // Tag должен быть уникальным 
            {
                _chart.Series.ToList().Find(x => (x.Tag as SimpleTimeRangeObject) == timeRangeObject).Points[0].XValue = timeRangeObject.GetStartTimeUtc().ToOADate();
                _chart.Series.ToList().Find(x => (x.Tag as SimpleTimeRangeObject) == timeRangeObject).Points[1].XValue = timeRangeObject.GetEndTimeUtc().ToOADate();
            }


        }

        public void ChartMouseMove(object sender, MouseEventArgs e, bool isMove)
        {
            _chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yy HH:mm";
            _chart.ChartAreas[0].CursorY.SetCursorPixelPosition(new Point(e.X, e.Y), true);
            _chart.ChartAreas[0].CursorX.SetCursorPixelPosition(new Point(e.X, e.Y), true);
            if (isMove)
            {
                foreach (var result in _results)
                {
                    if (result.Series != null)
                    {
                        if (result.ChartElementType == ChartElementType.DataPoint)
                        {
                            var timeRangeObject = result.Series.Tag as SimpleTimeRangeObject;
                            if (timeRangeObject != null)
                            {
                                var pX = _chart.ChartAreas[0].CursorX.Position;
                                var differenceOfPointsEnd = Math.Abs(pX - result.Series.Points[1].XValue);
                                var differenceOfPointsBegin = Math.Abs(pX - result.Series.Points[0].XValue);
                                if (differenceOfPointsEnd < differenceOfPointsBegin)
                                {
                                    result.Series.Points[1].XValue = pX;
                                }
                                if (differenceOfPointsEnd > differenceOfPointsBegin)
                                {
                                    result.Series.Points[0].XValue = pX;
                                }

                                timeRangeObject.startTimeUtc = DateTime.FromOADate(result.Series.Points[0].XValue);
                                timeRangeObject.endTimeUtc = DateTime.FromOADate(result.Series.Points[1].XValue);
                                result.Series.Tag = timeRangeObject;
                                _CallBack(result.Series.Tag as SimpleTimeRangeObject);
                            }

                        }
                    }
                }
            }
        }

        public SimpleTimeRangeObject ChartMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pos = e.Location;
                _results = _chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint).ToList();
                if (_results != null)
                {
                    foreach (var result in _results)
                    {
                        if (result.Series != null)
                        {
                            if (result.ChartElementType == ChartElementType.DataPoint)
                            {
                                var timeRangeObject = result.Series.Tag as SimpleTimeRangeObject;
                                if (timeRangeObject != null)
                                {
                                    return timeRangeObject;
                                }
                            }
                        }
                    }
                }
                return null;
            }
            return null;
        }
    }
}
