using System.Collections.Generic;

namespace KitchenApi
{
    public interface IMenuService
    {
        ICollection<MenuItem> GetMenu();
    }
}
