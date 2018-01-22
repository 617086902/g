using Core.Entities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public interface IApplication
    {
        GSEntities DbContext { get; }

        BaseUser CurrentUser { get; }
    }
}
