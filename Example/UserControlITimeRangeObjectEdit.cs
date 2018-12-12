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
    public partial class UserControlITimeRangeObjectEdit : UserControl
    {
        private SimpleTimeRangeObject _timeRangeObject;
        private Action<SimpleTimeRangeObject> _CallBack;
        public UserControlITimeRangeObjectEdit()
        {
            InitializeComponent();
        }

        public void SetCallBackSomethingChanged(Action<SimpleTimeRangeObject> CallBack)
        {
            _CallBack = CallBack;
        }

        public void SetCurrentItem(SimpleTimeRangeObject timeRangeObject)
        {
            _timeRangeObject = timeRangeObject;
            _UpdateGui();
        }

        private void _UpdateGui()
        {
            dateTimePickerGetStBegin.Value = _timeRangeObject.GetStartTimeUtc();
            dateTimePickerGetStEnd.Value = _timeRangeObject.GetEndTimeUtc();
            textBoxEntityId.Text = _timeRangeObject.GetEntityId().ToString();
        }

        private void _OnSomethingChanges()
        {
            if (dateTimePickerGetStBegin.Value <= dateTimePickerGetStEnd.Value)
            {
                _UpdateCurrentTimeTangeObject();
                _CallBack(_timeRangeObject);
            }
            else
            {
                MessageBox.Show("Некорректные даты.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void _UpdateCurrentTimeTangeObject()
        {
            try
            {
                _timeRangeObject.startTimeUtc = dateTimePickerGetStBegin.Value;
                _timeRangeObject.endTimeUtc = dateTimePickerGetStEnd.Value;
                _timeRangeObject.EntityId = Convert.ToInt32(textBoxEntityId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _OnSomethingChanges();
        }
    }
}
