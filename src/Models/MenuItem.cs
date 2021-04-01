namespace KitchenApi
{
    public class MenuItem
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public string Description { get; init; }
        public MenuType Menu { get; init; }
    }
    public enum MenuType
    {
        Breakfast,
        Lunch,
        HappyHour,
        Dinner
    }
}
