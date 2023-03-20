using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories
{
    public abstract class BaseRepository //abstract calss --> only work through inheritance
    {
        protected string connectionString;
        protected BaseRepository() { }
    }
}
