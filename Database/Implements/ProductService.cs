using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Database.Implements
{
    public class ProductService
    {
        private DapperConnection _dapperConnection;
        private IDbConnection _connect;

        public ProductService()
        {
            _dapperConnection = new DapperConnection();
            _connect
        }
    }
}
