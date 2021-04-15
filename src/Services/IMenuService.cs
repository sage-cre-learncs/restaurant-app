using System;
using System.Collections.Generic;

namespace KitchenApi
{
    public interface IMenuService
    {
        IEnumerable<MenuItem> GetMenu();
        
        IEnumerable<MenuItem> GetMenu(MenuType type);

        IEnumerable<MenuItem> GetMenu(DateTime time);

        MenuItem GetMenuItem(int id);

        MenuItem UpsertMenuItem(MenuItem name);

        void DeleteMenuItem(int id);
    }
}
