using Microsoft.Extensions.Configuration;

namespace IndoCybreShop.General
{
    public class Base
    {
        public IConfigurationRoot Configuration { get; set; }
        public Base()
        {
            
        }
    }
}