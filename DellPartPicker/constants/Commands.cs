using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker.constants
{
    public class Commands
    {
        public const String FIND = "find";
        public const String DISPOSE = "dispose";
    }

    public enum CommandType
    {
        FIND,
        DISPOSE
    }
}
