using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class SimpleTimeRangeObject : ITimeRangeObject
    {
        public DateTime startTimeUtc; 
        public DateTime endTimeUtc; 
        public long RecordId;
        public long EntityId;

        public SimpleTimeRangeObject(ITimeRangeObject timeRangeRecord)
        {
            startTimeUtc = timeRangeRecord.GetStartTimeUtc();
            endTimeUtc = timeRangeRecord.GetEndTimeUtc();
            RecordId = timeRangeRecord.GetRecordId();
            EntityId = timeRangeRecord.GetEntityId();
        }
        public SimpleTimeRangeObject(DateTime startTimeUtc, DateTime endTimeUtc, long EntityId)
        {
            this.startTimeUtc = startTimeUtc;
            this.endTimeUtc = endTimeUtc;
            this.EntityId = EntityId;
            RecordId = -1;
        }

        public DateTime GetStartTimeUtc()
        {
            return startTimeUtc;
        }
        public DateTime GetEndTimeUtc()
        {
            return endTimeUtc;
        }
        public long GetRecordId()
        {
            return RecordId;
        }
        public long GetEntityId()
        {
            return EntityId;
        }

        public override string ToString()
        {
            return string.Format("EntityId = {0} RecordId = {1} StartTimeUtc = {2} EndTimeUtc = {3}",
                EntityId, RecordId, startTimeUtc, endTimeUtc);
        }

        public static List<SimpleTimeRangeObject> Converting(List<ITimeRangeObject> listOfObject)
        {
            var convertingTimeRangeObjects = new List<SimpleTimeRangeObject>();
            foreach (var obj in listOfObject)
            {
                var copyTimeRangeobject = new SimpleTimeRangeObject(obj);
                convertingTimeRangeObjects.Add(copyTimeRangeobject);
            }
            return convertingTimeRangeObjects;
        }
    }
}
