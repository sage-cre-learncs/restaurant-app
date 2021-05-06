using System;
using System.Collections.Generic;

namespace KitchenApi
{
    public class MenuService : IMenuService    
    {
        private int nextId = 4;
        private List<MenuItem> menu = new List<MenuItem> {
            new MenuItem {
                Id = 0,
                Name =  "Green Eggs and Ham",
                Description = "Our signature verde sauce over gently cooked sunnyside up premium farm fresh eggs with a side of grass fed free range ham.",
                Menu = MenuType.Breakfast,
                Price = 12.95M
            },
            new MenuItem {
                Id = 1,
                Name =  "Club Sandwich",
                Description = "Plate o'bacon with some bread on the side.",
                Menu = MenuType.Lunch,
                Price = 14.95M
            },
            new MenuItem {
                Id = 2,
                Name =  "Nachos",
                Description = "A plate of delicious regional specific chips imported from the depths of Latin America with cheese and stuff.",
                Menu = MenuType.HappyHour,
                Price = 9.95M
            },
            new MenuItem {
                Id = 3,
                Name =  "Filet Mignon",
                Description = "Our most pertentious cut of grain fed beef with a side of Willamette River greens.",
                Menu = MenuType.Dinner,
                Price = 29.95M
            }            
        };

        public void DeleteMenuItem(int id)
        {
            var item = this.menu.Find(m => m.Id == id);
            this.menu.Remove(item);
        }

        public IEnumerable<MenuItem> GetMenu()       
        {
            return this.menu;
        }

        public IEnumerable<MenuItem> GetMenu(MenuType type)
        {
            foreach (var item in menu)
            {
                if (item.Menu == type)
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<MenuItem> GetMenu(DateTime time)
        {                
            if (time.Hour < 11 && time.Hour > 6)
            {
                return GetMenu(MenuType.Breakfast);
            }
            if (time.Hour < 16)
            {
                return GetMenu(MenuType.Lunch);
            }
            if (time.Hour < 18)
            {
                return GetMenu(MenuType.HappyHour);
            }
            if (time.Hour < 22)
            {
                return GetMenu(MenuType.Dinner);
            }
            return null;
        }

        public MenuItem GetMenuItem(int id)
        {
            return this.menu.Find(m => m.Id == id);
        }

        public MenuItem UpsertMenuItem(MenuItem item)
        {
            var existingItem = this.menu.Find(m => m.Id == item.Id);
            if (existingItem == null)
            {
                this.menu.Add(item);
            }
            else 
            {
                existingItem.Description = item.Description;
                existingItem.Menu = item.Menu;
                existingItem.Price = item.Price;
                existingItem.Name = item.Name;
            }
            return item;
        }
    }
}
