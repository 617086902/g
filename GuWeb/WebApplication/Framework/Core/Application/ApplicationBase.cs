using Core.Entities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application {
    public abstract class ApplicationBase : IApplication {
        public virtual BaseUser CurrentUser {
            get {
                return null;
            }
        }

        public GSEntities DbContext {
            get {
                return new GSEntities();
            }
        }
    }
}
