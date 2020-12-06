using System.Collections.ObjectModel;
namespace Menu.Models
{
    public sealed class Item
    {
        public string Image { get; set; }
        public string NameItem { get; set; }

        public static ObservableCollection<Item> Items()
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>()
            {
                new Item(){Image="/Images/Data.png", NameItem="Базы данных"},
                new Item(){Image="/Images/Game.png", NameItem="Игры"},
                new Item(){Image="/Images/Doc.png", NameItem="Документы"},
                new Item(){Image="/Images/File.png", NameItem="Файлы"},
                new Item(){Image="/Images/En.png", NameItem="Англиский язык"}
            };
            return items;
        }

        public static ObservableCollection<Item> DataItems()
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>()
            {
                new Item(){Image="/Images/Data/Mysql.png", NameItem="MySql"},
                new Item(){Image="/Images/Data/SqlLite.png", NameItem="SqlLite"},
                new Item(){Image="/Images/Data/SqlServer.png", NameItem="Sql Server"},
            };
            return items;
        }

        public static ObservableCollection<Item> DocItems()
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>()
            {
                new Item(){Image="/Images/Doc/Ac.png", NameItem="Access"},
                new Item(){Image="/Images/Doc/Ex.png", NameItem="Excel"},
                new Item(){Image="/Images/Doc/Power.png", NameItem="Pwer Point"},
                new Item(){Image="/Images/Doc/Vis.png", NameItem="Visio"},
                new Item(){Image="/Images/Doc/Word.png", NameItem="Word"},
            };
            return items;
        }

        public static ObservableCollection<Item> GameItems()
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>()
            {
                new Item(){Image="/Images/Games/Dota2.png", NameItem="Dota 2"},
                new Item(){Image="/Images/Games/Fortnite.png", NameItem="Fortnite"},
                new Item(){Image="/Images/Games/GearsOfWar.png", NameItem="Gears of War"},
                new Item(){Image="/Images/Games/GodOfWar.png", NameItem="God of War"},
                new Item(){Image="/Images/Games/Halo.png", NameItem="Halo"},
                new Item(){Image="/Images/Games/Lol.png", NameItem="Liga of Legends"},
                new Item(){Image="/Images/Games/Minecraft.png", NameItem="Minecraft"},
                new Item(){Image="/Images/Games/SpiderMen.png", NameItem="Spider-Men"},
                new Item(){Image="/Images/Games/WorldOfWarcraft.png", NameItem="World of Warcraft"},
            };
            return items;
        }
    }
}
