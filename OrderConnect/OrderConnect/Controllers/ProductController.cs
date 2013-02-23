using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderConnect.Controllers
{
    public class ProductController : ApiController
    {
        public IList<Product> Get()
        {
            return new List<Product>
                {
                    new Product{ImageSource = "/Content/images/StorageJar.jpg" ,Category = "Laboratory Products",Name ="Storage Jar For Applicators",Description = "Made of heavy-gauge stainless steel, this storage jar features a slip-on cover with a convenient strap handle. 3 1/8” dia. x 6 1/2” H (8 x 16.5cm). Height with cover: 6 3/4” (17.1cm)."},
                    new Product{ImageSource = "/Content/images/LiquidPeraceticAcid.jpg" ,Category = "Laboratory Products",Name ="Liquid Peracetic Acid Chemical Indicator",Description = "(3M) This single-use chemical indicator is for use in the STERIS SYSTEM 1® processor. It provides assurance that items have been exposed to the appropriate concentration of sterilant. The indicator changes from red to lime green when processed. The distinct color change makes it easy to interpret, and its large size allows for easy retrieval from the processor. The indicator results can be read for up to 30 minutes after processing. Supplied in a pouch of 50. Four pouches (200 indicators) per case."}
                };
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
