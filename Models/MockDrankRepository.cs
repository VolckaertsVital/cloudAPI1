using System.Collections.Generic;
using System.Linq;

namespace DrankAPI.Models{
    public class MockDrankRepository : IDrankRepository
    {
        private List<Drank> _DrankList;

        public MockDrankRepository(){
            _DrankList = new List<Drank>(){
                new Drank() {
                    Id = 1,
                    NameBrand = "Bacardi",
                    name = "Oakheart",
                    type = "Rum",
                    Quantity = 5,
                    AlcoholPersentage = 35
                },
                new Drank() {
                    Id = 2,
                    NameBrand = "IORDANOV",
                    name = "/",
                    type = "Vodka",
                    Quantity = 19,
                    AlcoholPersentage = 40,
                },
                new Drank() {
                    Id = 3,
                    NameBrand = "Absolut.",
                    name = "Original Vodka",
                    type = "Vodka",
                    Quantity = 15,
                    AlcoholPersentage = 40,
                },
                new Drank() {
                    Id = 4,
                    NameBrand = "Filliers",
                    name = "Cavaillon",
                    type = "Jenever",
                    Quantity = 10,
                    AlcoholPersentage = 20,
                },
                new Drank() {
                    Id = 5,
                    NameBrand = "Trojka",
                    name = "Pink",
                    type = "Vodka",
                    Quantity = 44,
                    AlcoholPersentage = 17,
                },
                new Drank() {
                    Id = 6,
                    NameBrand = "Jack Daniels",
                    name = "Tennessee Fire",
                    type = "Wiskey",
                    Quantity = 110,
                    AlcoholPersentage = 35,
                },
                new Drank() {
                    Id = 7,
                    NameBrand = "Peterman",
                    name = "Cuberdon / neuzen",
                    type = "Jenever",
                    Quantity = 55,
                    AlcoholPersentage = 15,
                },
                new Drank() {
                    Id = 8,
                    NameBrand = "Bols",
                    name = "Banana",
                    type = "Liqueur",
                    Quantity = 21,
                    AlcoholPersentage = 17,
                },
                new Drank() {
                    Id = 9,
                    NameBrand = "Jagermeister",
                    name = "/",
                    type = "herbal liqueur",
                    Quantity = 57,
                    AlcoholPersentage = 35,
                }
            };
        }

        public IEnumerable<Drank> GetAllDrank()
        {
            return _DrankList;
        }

        public Drank GetDrank(int Id)
        {
            return _DrankList.FirstOrDefault(e => e.Id == Id);
        }
    }
}