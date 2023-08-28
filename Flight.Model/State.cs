using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public interface State
    {
        UserControl Content { get; }
        bool PageValid { get; }
        string ValidationMessage { get; }
    }
}
