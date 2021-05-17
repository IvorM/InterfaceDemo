using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class CrudOperacije
    {
        private ICrud _crudOperacije { get; set; }
        public CrudOperacije(ICrud crudOperacije)
        {
            _crudOperacije = crudOperacije;
        }

        public CrudOperacije()
        {

        }

        public void SetInterface(ICrud crudOperacije)
        {
            _crudOperacije = crudOperacije;
        }
        public void Create()
        {
            _crudOperacije.Create();
        }
    }
}
