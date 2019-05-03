using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;

namespace capadedatos
{
    public class bdConex
    {
        public bool conex()
        {
            bool correcto=false;
            try 
            {
                correcto=true; 
            }
            catch {}{
                correcto=false;
            }
            return correcto;
        }
    }
}
