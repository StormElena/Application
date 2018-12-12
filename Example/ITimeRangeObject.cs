using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// Интерфейс для объектов, у которых можно будет править время начала и время конца.
    /// Вместо начала и конца можно подумать об использовании TimeRange
    /// GetRecordId() - подразумевается, что методв возвращает номер записи в БД
    /// </summary>
    public interface ITimeRangeObject
    {
        DateTime GetStartTimeUtc();
        DateTime GetEndTimeUtc();
        long GetRecordId();
        long GetEntityId();
    }
}
