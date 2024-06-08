using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.Common
{
    public interface IMapleGameService
    {
        ValueTask LoadService();
        ValueTask DestroyService();
    }




}
