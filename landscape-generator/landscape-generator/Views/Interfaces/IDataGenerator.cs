using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace landscape_generator.Views.Interfaces
{
    public interface IDataGenerator
    {
        event Func<bool> tempEvent;
    }
}
