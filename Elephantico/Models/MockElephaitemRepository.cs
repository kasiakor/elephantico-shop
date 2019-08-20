using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    public class MockElephaitemRepository : IElephaitemRepository
    {
        private List<Elephaitem> _elephaitems;

        // the list will be initialized in the constructor if it is still null
        public MockElephaitemRepository()
        {
           if (_elephaitems == null)
            {
                InitializeElephaitems();
            }
        }

        // hardcoded data
        private void InitializeElephaitems()
        {
            _elephaitems = new List<Elephaitem>
            {
            new Elephaitem {Id = 1, Name = "Elephant My Sunshine T-shirt", Price = 12.99M, ShortDescription = "Grey Cotton T-shirt", LongDescription = "The graphic design is printed onto the shirt using our unique process. This process helps create the unique look of our shirts where the images appear to be part of the clothing instead of just pasted on. Our process provides customers with a superior product that ensures our clothing keeps looking good after surviving the onslaught from your washing machine and dryer.", ImageUrl = "https://scontent-lhr3-1.xx.fbcdn.net/v/t1.0-9/68964363_2313103368786978_2206298084042866688_n.jpg?_nc_cat=106&_nc_oc=AQl0beDLzPCW7jy-q6WlXIxz3n9slBVIhH3jmF9lCpsaOZo7AQ2yd6HDEW3UdOosXRJaNGh9GrRXsh4wQiC6NaJf&_nc_ht=scontent-lhr3-1.xx&oh=cb3dc4dacdea768988f6e469646bc41c&oe=5DCD5402", IsElephaitemOfTheWeek = true, ImageThumbnailUrl = "https://scontent-lhr3-1.xx.fbcdn.net/v/t1.0-9/68964363_2313103368786978_2206298084042866688_n.jpg?_nc_cat=106&_nc_oc=AQl0beDLzPCW7jy-q6WlXIxz3n9slBVIhH3jmF9lCpsaOZo7AQ2yd6HDEW3UdOosXRJaNGh9GrRXsh4wQiC6NaJf&_nc_ht=scontent-lhr3-1.xx&oh=cb3dc4dacdea768988f6e469646bc41c&oe=5DCD5402"},
            new Elephaitem {Id = 2, Name = "I love you to the Moon & back Mug", Price = 15.99M, ShortDescription = "Ceramic Mug", LongDescription = "Adding a splash of fun to your morning beverage, this lifelike Elephant Mug is artfully handcrafted in Thailand of durable earthenware. This unique and affordable piece will deliver big smiles even before the coffee is poured.", ImageUrl = "https://scontent-lhr3-1.xx.fbcdn.net/v/t1.0-9/15727311_1114880158609311_5170630230042243951_n.jpg?_nc_cat=102&_nc_oc=AQmEQshXZBFsNGlo5adVQnuQO1TXBinwose_9Ae1xhrnW0Ivt4lWIECOKHx3AzDj4PYeDvGEeFmbiKAVxaLtLwBK&_nc_ht=scontent-lhr3-1.xx&oh=719de032bab359aea1abf743e0887de0&oe=5DD480A9", IsElephaitemOfTheWeek = false, ImageThumbnailUrl = "https://scontent-lhr3-1.xx.fbcdn.net/v/t1.0-9/15727311_1114880158609311_5170630230042243951_n.jpg?_nc_cat=102&_nc_oc=AQmEQshXZBFsNGlo5adVQnuQO1TXBinwose_9Ae1xhrnW0Ivt4lWIECOKHx3AzDj4PYeDvGEeFmbiKAVxaLtLwBK&_nc_ht=scontent-lhr3-1.xx&oh=719de032bab359aea1abf743e0887de0&oe=5DD480A9"},
            new Elephaitem {Id = 3, Name = "Save the Elephants T-shirt", Price = 18.99M, ShortDescription = "White Cotton T-shirt", LongDescription = "This product is made-to-order and proudly printed with the best screenprinting or print to garment processes available. As such, it does not include embellishments such as rhinestones or glitter. ", ImageUrl = "https://scontent-lhr3-1.xx.fbcdn.net/v/t1.0-9/67417415_2269327536497895_6726561656240865280_n.jpg?_nc_cat=104&_nc_oc=AQkKCPI0X6pzMPLcCJWay-Kps-PbqMF3cOuxPkPg9qZnsI-a9Sa3-AzDcIzzUN0pwZfcDvvrskIz2RPIS9HNNsV-&_nc_ht=scontent-lhr3-1.xx&oh=484cd440a3dc7e3fb10ca40d43092bea&oe=5DD30E3C", IsElephaitemOfTheWeek = false, ImageThumbnailUrl = "https://scontent-lhr3-1.xx.fbcdn.net/v/t1.0-9/67417415_2269327536497895_6726561656240865280_n.jpg?_nc_cat=104&_nc_oc=AQkKCPI0X6pzMPLcCJWay-Kps-PbqMF3cOuxPkPg9qZnsI-a9Sa3-AzDcIzzUN0pwZfcDvvrskIz2RPIS9HNNsV-&_nc_ht=scontent-lhr3-1.xx&oh=484cd440a3dc7e3fb10ca40d43092bea&oe=5DD30E3C"},
            new Elephaitem {Id = 4, Name = "Elephant Beauty Phone Case", Price = 25.99M, ShortDescription = "Phone Case", LongDescription = "This case benefits from three card slots, for casual storage of a business card or travel ticket. There is also a hidden compartment for storage of a banknote. This case is not designed to replace a wallet or purse.", ImageUrl = "https://scontent-lhr3-1.cdninstagram.com/v/t51.2885-15/e35/66631511_2428710600518295_1242916115472403310_n.jpg?_nc_ht=scontent-lhr3-1.cdninstagram.com&se=7&oh=b25960f47f41758590271cad5d2b585a&oe=5DDAFAC5&ig_cache_key=MjA4OTAwMDg4MjM0NDgyNjUzNQ%3D%3D.2", IsElephaitemOfTheWeek = false, ImageThumbnailUrl = "https://scontent-lhr3-1.cdninstagram.com/v/t51.2885-15/e35/66631511_2428710600518295_1242916115472403310_n.jpg?_nc_ht=scontent-lhr3-1.cdninstagram.com&se=7&oh=b25960f47f41758590271cad5d2b585a&oe=5DDAFAC5&ig_cache_key=MjA4OTAwMDg4MjM0NDgyNjUzNQ%3D%3D.2"}
            };
        }
        public IEnumerable<Elephaitem> GetAllElephaitems()
        {
            return _elephaitems;
        }

        public Elephaitem GetElephaitemById(int elephaitemId)
        {
            return _elephaitems.FirstOrDefault(e => e.Id == elephaitemId);
        }
    }
}
