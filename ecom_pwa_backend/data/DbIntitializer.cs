using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ecom_pwa_backend.data
{
    public class DbIntitializer
    {
        public void InitDb(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
        }
    }
}