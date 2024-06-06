using ABC.API.Model;

namespace ABC.API
{
    public static class Data
    {
        public static List<Building> buildings = new List<Building>()
        {
            new Building(){ Id=1,Name="Örnek 1", Description="Örnek 1 Açıklama",Location=Location.Istanbul,Price=3000000,PropertyType=PropertyType.Private},
            new Building(){ Id=2,Name="Örnek 2", Description="Örnek 2 Açıklama",Location=Location.Ankara,Price=12000000,PropertyType=PropertyType.Masion},
            new Building(){ Id=3,Name="Örnek 3", Description="Örnek 3 Açıklama",Location=Location.Izmir,Price=15000000,PropertyType=PropertyType.Villa},
            new Building(){ Id=4,Name="Örnek 4", Description="Örnek 4 Açıklama",Location=Location.Adana,Price=1800000,PropertyType=PropertyType.Apartment},
        };

    }
}
