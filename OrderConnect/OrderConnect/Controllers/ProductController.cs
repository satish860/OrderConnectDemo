using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace OrderConnect.Controllers
{
    public class ProductController : ApiController
    {

        public IList<Product> productList = new List<Product>
                {
                    new Product{ImageSource = "/Content/images/StorageJar.jpg" ,Category = "Laboratory Products",Name ="Storage Jar For Applicators",Description = "Made of heavy-gauge stainless steel, this storage jar features a slip-on cover with a convenient strap handle. 3 1/8” dia. x 6 1/2” H (8 x 16.5cm). Height with cover: 6 3/4” (17.1cm)."},
                    new Product{ImageSource = "/Content/images/LiquidPeraceticAcid.jpg" ,Category = "Laboratory Products",Name ="Liquid Peracetic Acid Chemical Indicator",Description = "(3M) This single-use chemical indicator is for use in the STERIS SYSTEM 1® processor. It provides assurance that items have been exposed to the appropriate concentration of sterilant. The indicator changes from red to lime green when processed. The distinct color change makes it easy to interpret, and its large size allows for easy retrieval from the processor. The indicator results can be read for up to 30 minutes after processing. Supplied in a pouch of 50. Four pouches (200 indicators) per case."},
                    new Product{ImageSource = "/Content/images/omron-bp.jpg" ,Category = "Medical and Surgical Products",Name ="Omron M2 Classic Blood Pressure Monitor",
                        Description = "This compact unit with a large easy-to-read display and simple one-button operation features Omron's Intellisense technology that ensures the cuff inflates to the correct pressure to take a reading. It means it will not over inflate and avoids painful measurements. The Omron M2 Classic also features irregular heartbeat detection and has a hypertension level indicator for users who want to verify that their blood pressure is in the recommended level of under 135/85 mmHg.When using an Omron blood pressure monitor, please ensure that the cuff size is correct. The Omron M2 Classic is supplied with a standard size cuff for arm circumference 22 cm to 32 cm. An optional Omron large blood pressure monitor cuff, suitable for arm circumference 32 cm to 42 cm, is available to purchase separately."},
                    new Product{ImageSource = "/Content/images/thermometer.jpg" ,Category = "Medical and Surgical Products",Name ="Digital Thermometer",
                        Description = "Measure your Body Temperature accurately and very quickly with this superb electronic digital thermometer. Compared with the traditional glass mercury thermometer, it has the advantage of easy reading, quick response, secure and accurate measurement, memory and buzzer alarm, etc. It causes no harm to the environment or the user's body because no mercury is used. It is suitable for use on all the family, young or old. This Thermometer is brand new and supplied in a box with full instructions on how to use. Also included is a handy protective case to keep the Thermometer in when not in use"}
                };

        public IList<Product> Get()
        {
            return productList;
        }

        public IList<Product> GetSearch(string keywords)
        {
            return productList.Where(p => p.Name.Contains(keywords)).ToList();
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
