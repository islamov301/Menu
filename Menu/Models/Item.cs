using System.Collections.ObjectModel;
namespace Menu.Models
{
    public sealed class Item
    {
        public string Image { get; set; }
        public string NameItem { get; set; }
        public string Description { get; set; }

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
                new Item(){Image="/Images/Data/Mysql.png", NameItem="MySql",Description="MySQL — это реляционная система управления базами данных с открытым исходным кодом. ... СУБД MySQL появилась в 1995. Написана на C и C++, протестирована на множестве различных компиляторов и работает на различных платформах. C 2010 года разработку и поддержку MySQL осуществляет корпорация Oracle."},
                new Item(){Image="/Images/Data/SqlLite.png", NameItem="SqlLite",Description="SQLite — компактная встраиваемая реляционная база данных. Исходный код библиотеки передан в общественное достояние. Является чисто реляционной базой данных."},
                new Item(){Image="/Images/Data/SqlServer.png", NameItem="Sql Server",Description="Microsoft SQL Server — система управления реляционными базами данных (РСУБД), разработанная корпорацией Microsoft. ... Используется для работы с базами данных размером от персональных до крупных баз данных масштаба предприятия; конкурирует с другими СУБД в этом сегменте рынка."},
            };
            return items;
        }

        public static ObservableCollection<Item> DocItems()
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>()
            {
                new Item(){Image="/Images/Doc/Ac.png", NameItem="Access", Description="Microsoft Access — это система управления базами данных (СУБД) от Microsoft, которая объединяет реляционный Microsoft Jet Database Engine с графическим интерфейсом пользователя и инструментами разработки программного обеспечения. ... Он хранит данные в своем собственном формате на основе ядра базы данных Access Jet."},
                new Item(){Image="/Images/Doc/Ex.png", NameItem="Excel",Description ="Excel – это универсальная программа, которая позволяет работать с различными форматами данных. ... Программа Excel входит в состав пакета Microsoft Office, который состоит из целого набора продуктов, позволяющих создавать различные документы, электронные таблицы, презентации и многое другое."},
                new Item(){Image="/Images/Doc/Power.png", NameItem="Power Point",Description="power point — убедительный доклад) — программа подготовки презентаций и просмотра презентаций, являющаяся частью Microsoft Office и доступная в редакциях для операционных систем Microsoft Windows и macOS, а также для мобильных платформ Android и IOS."},
                new Item(){Image="/Images/Doc/Vis.png", NameItem="Visio",Description="Microsoft Visio – программа, с помощью которой появляется возможность для составления графиков, чертежей, диаграмм, блок-схем. ... Это отличный графический редактор, позволяющий работать с диаграммами и схемами. Программа содержит мощный набор инструментов, который будет полезен для работы."},
                new Item(){Image="/Images/Doc/Word.png", NameItem="Word",Description="Microsoft Word (часто — MS Word, WinWord или просто Word) — текстовый процессор, предназначенный для создания, просмотра, редактирования и форматирования текстов статей, деловых бумаг, а также иных документов, с локальным применением простейших форм таблично-матричных алгоритмов."},
            };
            return items;
        }

        public static ObservableCollection<Item> GameItems()
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>()
            {
                new Item(){Image="/Images/Games/Dota2.png", NameItem="Dota 2", Description="Dota 2 — компьютерная многопользовательская командная игра жанра стратегия в реальном времени с элементами компьютерной ролевой игры, реализация известной карты DotA для игры Warcraft III в отдельном клиенте. В игре участвуют две команды по пять человек. Одна команда играет за светлую сторону, другая — за темную."},
                new Item(){Image="/Images/Games/Fortnite.png", NameItem="Fortnite", Description="Fortnite — это кооперативная песочница на выживание, основными механиками которой являются исследование, сбор ресурсов, строительство укрепленных зданий и борьба с волнами наступающих зомби. ... Строительство является основной механикой, при этом в игре «уйма лута»."},
                new Item(){Image="/Images/Games/GearsOfWar.png", NameItem="Gears of War",Description="Gears of War 3 — это как Quake или Unreal наших дней: жестокий, дерзкий мужской шутер, в котором запоминается не набор постановочных моментов, а в первую очередь сами сражения. Это идеальный способ завершить трилогию, и это, наконец, такой фантастический боевик, каких даже в кинотеатрах не показывают уже лет двадцать."},
                new Item(){Image="/Images/Games/GodOfWar.png", NameItem="God of War", Description="God of War (с англ. — «Бог войны») — компьютерная игра в жанре action-adventure, разработанная компанией SIE Santa Monica Studio, и изданная Sony Interactive Entertainment для игровой консоли PlayStation 4. Вышла 20 апреля 2018 года. Является восьмой игрой серии God of War, а также сиквелом к игре 2010 года God of War III. Игра является перезапуском, при этом продолжив события предыдущих игр, и перенесёт серию в мир скандинавской мифологии — все предыдущие игры серии были основаны на греческой мифологии. 16 сентября 2020 года было анонсировано продолжение игры."},
                new Item(){Image="/Images/Games/Halo.png", NameItem="Halo",Description="Halo - это фантастический шутер от первого лица, изначально вышедший для Xbox, а позже портированный на РС. История игры рассказывает о противостоянии людей и Ковенанта инопланетян с целью сохранения собственной планеты."},
                new Item(){Image="/Images/Games/Lol.png", NameItem="Liga of Legends",Description="League of Legends – это стратегическая кооперативная игра, в которой две команды из пяти могущественных чемпионов сражаются друг с другом, пытаясь уничтожить вражескую базу. Выбирайте персонажа из более чем 140 чемпионов, создавайте эпические моменты, зарабатывайте убийства и сносите башни на пути к победе."},
                new Item(){Image="/Images/Games/Minecraft.png", NameItem="Minecraft", Description="Minecraft - игра о создании. Игра о выживании, открытии, обществе, одиночестве, творчестве и отчаянии. Сначала вы попадаете в пустыню. Нет, это не та привычная пустыня, она расширяется после каждого шага, пока вы не пройдёте до пика и не попадёте в мир, раза в три больше родной Земли. Но этого, конечно же, не случится."},
                new Item(){Image="/Images/Games/SpiderMen.png", NameItem="Spider-Men", Description="Spider-Man — компьютерная игра в жанре приключенческого боевика, разработанная компанией Insomniac Games и изданная Sony Interactive Entertainment. Игра основана на персонаже комиксов Marvel, Человеке-пауке. Релиз игры состоялся 7 сентября 2018 года для PlayStation 4 и 12 ноября 2020 года для PlayStation 5."},
                new Item(){Image="/Images/Games/WorldOfWarcraft.png", NameItem="World of Warcraft",Description="World Of Warcraft - многопользовательская ролевая онлайн-игра, разработанная компанией Blizzard Entertainment. ... Игроки в WoW вольны выбирать сторону конфликта, расу персонажа и один из множества классов, а так же получают доступ к огромному и разнообразному миру Азерота."},
            };
            return items;
        }

        public static ObservableCollection<Item> FileItems()
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>()
            {
                new Item(){ Image="/Images/File/Rar.png", NameItem="Rar", Description="RAR — проприетарный формат сжатых данных и условно-бесплатная программа-архиватор. Версия для Microsoft Windows распространяется в составе многоформатного архиватора с графическим интерфейсом — WinRAR."},
                new Item(){ Image="/Images/File/Txt.png", NameItem="Txt", Description="Файл TXT - стандартный текстовый документ Windows. Содержит текст без форматирования. Может быть открыт любой программой для работы с текстом. Самая простая и доступная - Блокнот Windows, текстовые файлы по умолчанию ассоциированы именно с ней."},
                new Item(){ Image="/Images/File/Zip.png", NameItem="Zip", Description="ZIP — популярный формат архивации файлов и сжатия данных без потерь. Архив ZIP может содержать один или несколько файлов и каталогов, которые могут быть сжаты разными алгоритмами. Наиболее часто в ZIP используется алгоритм сжатия Deflate."}
            };
            return items;
        }
    }
}
