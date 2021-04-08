using System;
using System.Collections.Generic;

namespace KitchenApi
{
    public interface IMenuService
    {
        ICollection<MenuItem> GetMenu();
        
        ICollection<MenuItem> GetMenu(MenuType type);

        ICollection<MenuItem> GetMenu(DateTime time);

        MenuItem GetMenuItem(int id);

        MenuItem UpsertMenuItem(MenuItem name);

        void DeleteMenuItem(int id);
    }
}
