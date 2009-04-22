using System;
using System.Collections.Generic;
using System.Text;

namespace SPCS
{
    public interface SPCSIRecordObject
    {
        bool SaveIfNotAvailable();
        bool Save();
        bool Exists();
    }
}
