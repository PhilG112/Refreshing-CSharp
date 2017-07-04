using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ExplicitImplementation
{
    public class Main
    {
        StandardCatalog standardCatalog = new StandardCatalog();
        ISaveable saveable = new StandardCatalog();
        IPersistable persistable = new StandardCatalog();
    }
}
