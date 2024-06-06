namespace ABC.API.Model
{
    public class BuildingSearchVM
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public Location? Location { get; set; }
        public PropertyType? PropertyType { get; set; }
    }
}
