using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ExplicitImplementation
{
    public class StandardCatalog : ISaveable, IPersistable
    {
        public void Load()
        {

        }

        public string Save()
        {
            return "Catalog Save";
        }
    }

    public class ExplicitCatalog : ISaveable, IPersistable
    {
        private string Save()
        {
            return "Catalog Save";
        }

        string ISaveable.Save()
        {
            return "ISaveable Save";
        }

        string IPersistable.Save()
        {
            return "Ipersistable Save";
        }
    }

    public class Catalog : ISaveable, IVoidSaveable
    {
        public string Save()
        {
            throw new NotImplementedException();
        }

        void IVoidSaveable.Save()
        {
            throw new NotImplementedException();
        }
    }

    public class EnumerableCatalog : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            // Do something here.
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
