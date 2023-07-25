using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.AspNetCore.Hosting;

namespace FactoryPlatform.Library
{
    public class ListObjects
    {
        public LKQMXFPAPPContext _fpContext;
        public StoresProceduresDbContext _SpContext;
        public ApplicationDbContext _appContext;
        public IWebHostEnvironment _environment;
    }
}
