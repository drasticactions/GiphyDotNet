using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyDotNet.Sample
{
    public interface IAppDispatcher
    {
        bool Dispatch(Action action);
    }
}
