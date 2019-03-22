using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        public static string username = "";
        public static byte hero = 1;
        public static byte pol = 1;
        public static bool rog = true;
        public static bool kompas = true;
        public static byte otvet = 1;
        public static bool try_again = false;
        public static bool ohrannik_die = false;
        public static bool continue_mission = false;

        static void Main(string[] args)
        {

            Console.WriteLine("Наконец-то в 2184 году создали Виртуальную реальность с полным погружением в игру. Готовы ли вы погрузиться в мир параллельной реальности? \n 1.Да \n 2.Нет");
            otvet = Convert.ToByte(Console.ReadLine());

            switch (otvet)
            {
                case 1:
                    Soc_Opros(out username);
                    Console.Clear();
                    Vstuplenie(username);
                    //Thread.Sleep(100000);
                    Vonucheye_Wetland();
                    Thread.Sleep(5000);
                    Console.Clear();
                    Alpiyskie_Mountains(username);
                    Thread.Sleep(5000);
                    Console.Clear();
                    Castle();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        public static void Soc_Opros(out string name)
        {
            Console.WriteLine("Введите имя игрока:");
            name = Console.ReadLine();
            //Console.WriteLine("Кем бы вы хотели быть? \n 1. Воин \n 2. Маг (НА СТАДИИ РАЗРАБОТКИ!!! P.s. Его кароч ещё нету :( )");
            //hero = Convert.ToByte(Console.ReadLine());
        }
        public static void Vstuplenie(string name)
        {
            Console.WriteLine("Меня зовут " + name + ". Мой отец был воином высшего класса, который погиб в схватке с драконом, захватившим главную крепость города. \n После дракон был согнан, но не убит. Я поступил в рыцарскую академию чтобы отмстить за своего отца. Через 6 лет я получил звание оруженосца. Я пришёл в оружейную лавку, чтобы купить себе какой-нибудь меч. Продавцом был бывший генерал воинской части. Он был очень старым, но мудрым. У меня было в кармане 3 серебряные монеты, а стоимость любого меча превышала 5 монет. Я рассказал всю ситуацию продавцу. Он сжалился и не взяв с меня ни одной монеты выдал мне хороший стальной меч. Я спросил, знает ли он что-нибудь о драконе. Он сказал идти мне через Вонючее Болото в Дремучий Лес дальше на Альпийские горы, а с них я уже увижу замок дракона. Он, напоследок, пожелал мне удачи и дал волшебный компас, сказав: «Не вздумай потерять его! А то сам потеряешься!». Ещё он мне выдал волшебный рог и сказал: «Если всё будет совсем плохо, то дунь в этот рог из последних сил, но запомни, что компас и рог можно использовать только 1 раз!».  Я собрал все нужные вещи и выдвинулся за драконом.");
        }
        public static void Vonucheye_Wetland()
        {
            Console.WriteLine("Я пришёл к Вонючему болоту. Что мне делать? \n 1. Попытаться быстро перебежать его \n 2. Обойти");
            otvet = Convert.ToByte(Console.ReadLine());
            switch (otvet)
            {
                case 1:
                    try_again = false;
                    otvet = 0;
                    Console.Clear();
                    Console.WriteLine("Я увяз в болоте! АААААААА! Я тону! Что делать!? \n 1. Дунуть в рог \n 2. Ничего не делать ");
                    otvet = Convert.ToByte(Console.ReadLine());
                    switch (otvet)
                    {
                        case 1:
                            rog = false;
                            Console.WriteLine("Сгустились тучи. Над вами собрался рой птиц. И в один момент они опустились на вас и вытащили вас на берег.");
                            Thread.Sleep(5000);
                            break;
                        case 2:
                            Console.WriteLine("Вы утонули в болоте!");
                            break;
                            //default:
                            //    try_again = true;
                            //    Console.WriteLine("Попробуйте ещё раз");
                            //    Thread.Sleep(3000);
                            //    break;
                    }
                    //if (try_again == true)
                    //{
                    //    goto case 1;
                    //}
                    if (rog == false)
                    {
                        goto case 2;
                    }
                    //else
                    //{
                    break;
                //}

                case 2:
                    otvet = 0;
                    
                    Console.Clear();
                    Console.WriteLine("Вы долго обходили болото. И вот вы подошли к Дремучему Лесу, но уже стемнело. \n 1. Разбить лагерь и переждать ночь \n 2. Сразу же пойти в лес ");
                    otvet = Convert.ToByte(Console.ReadLine());
                    try_again = false;
                    switch (otvet)
                    {
                        case 1:
                            Console.WriteLine("Настало утро.Вы, полные сил, выдвинулись в дремучий лес.Там было не так темно, как ночью, и вы спокойно, но долго двигались в сторону Альпийских гор");
                            break;
                        case 2:
                            otvet = 0;
                            Console.Clear();
                            Console.WriteLine("Вы долго блуждали по тёмному лесу и, пару раз ударившись лбом об стволы деревьев, поняли, что вы заблудились \n 1. Использовать компас \n 2. Ничего не делать ");
                            otvet = Convert.ToByte(Console.ReadLine());
                            try_again = false;
                            switch (otvet)
                            {
                                case 1:
                                    kompas = false;
                                    Console.Clear();
                                    Console.WriteLine("Компас осветил ярким светом выход");
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Блуждав по лесу, вы наткнулись на капкан местных охотников. Схватив вас за ноги, он сделал глубокие порезы. Вы долго кричали и просили о помощи, но так никто и не пришёл.  Вы умерли от кровотечения...");
                                    Die();
                                    break;
                                    //default:
                                    //    try_again = true;
                                    //    Console.WriteLine("Попробуйте ещё раз");
                                    //    Thread.Sleep(3000);
                                    //    break;
                            }
                            //if (try_again == true)
                            //{
                            //    try_again = false;
                            //    goto case 2;
                            //}
                            break;

                            //default:
                            //    try_again = true;
                            //    Console.WriteLine("Попробуйте ещё раз");
                            //    Thread.Sleep(3000);
                            //    if (try_again == true)
                            //    {
                            //        try_again = false;
                            //        goto case 2;
                            //    }
                            //    break;

                    }
                    break;

                    //default:
                    //    try_again = true;
                    //    Console.WriteLine("Попробуйте ещё раз");
                    //    Thread.Sleep(3000);
                    //    if (try_again == true)
                    //    {
                    //        try_again = false;
                    //        goto case 2;
                    //    }
                    //    break;
            }
        }
        public static void Alpiyskie_Mountains(string name)
        {
            otvet = 0;
            Console.Clear();
            Console.WriteLine("Пройдя лес, вы наткнулись на отвесной склон Альпийских гор:");
            Console.WriteLine(name + ": Так, нужно вспомнить, что говорил продавец… А, точно!Он говорил, что если я заберусь на Альпийские горы, то увижу логово дракона.Что же мне делать ? \n 1. Обойти гору и найти более пологий склон. \n 2. Подняться на гору, используя меч.");
            otvet = Convert.ToByte(Console.ReadLine());
            //try_again = false;
            switch (otvet)
            {
                case 1:
                    otvet = 0;
                    Console.Clear();
                    Console.WriteLine("Вы преодолели большое расстояние, и не зря! Потому что вы нашли пологий склон! \n 1. Попытать удачу и попробовать угадать направление, в котором находится замок. \n 2. Подняться на гору");
                    otvet = Convert.ToByte(Console.ReadLine());
                    switch (otvet)
                    {
                        case 1:
                            bool try_kompas = false;
                            otvet = 0;
                            Console.Clear();
                            Console.WriteLine("Вы пошли в каком-то неизвестном направлении. Пройдясь пару десятков минут, вы поняли, что потерялись. \n 1. Использовать компас. \n 2. Позвать на помощь.");
                            otvet = Convert.ToByte(Console.ReadLine());
                            switch (otvet)
                            {
                                case 1:
                                    if (kompas == true)
                                    {
                                        Console.WriteLine("Компас показал вам путь, вы пошли к замку");
                                    }
                                    else
                                    {
                                        try_kompas = false;
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Вы совершили множество отчаянных попыток позвать на помощь, но это было бессмысленно");
                                    Die();
                                    break;
                            }
                            if (try_kompas == false)
                            {
                                Console.WriteLine("Вы уже использовали компас!");
                                Thread.Sleep(3);
                                goto case 1;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Вы поднялись на достаточную высоту чтобы увидеть замок и, спустившись, отправились в путь");
                            break;
                            
                    }
                    break;
                case 2:
                    otvet = 0;
                    Console.Clear();
                    Console.WriteLine("Поднявшись на гору, вы увидели замок:");
                    Console.WriteLine(name + ": Смотря на замок, невольно вспоминаются ночные кошмары. Когда я был маленьким, отец мне показывал его. Там велась очередная ожесточённая битва. отряд «Альфа» сражался с драконом за права владения сокровищницей замка. На той битве было пролито много крови. Тогда мне было около 6 лет. Меня поражало с каким безумием и отчаянием сражались воины, подчиняясь приказу: «Биться насмерть» … Возвращаясь в реальность продолжил путь по горе. Далее склон был более пологий и я, услышав шум воды, направился вниз. На пол пути я увидел водопад, за которым была пещера. Уже начинало темнеть. \n 1. Продолжить спускаться с горы. \n 2. Переночевать в пещере и наточить меч.");
                    otvet = Convert.ToByte(Console.ReadLine());
                    switch (otvet)
                    {
                        case 1:
                            Console.WriteLine("Было очень темно. Вы не видели, что у вас было под ногами и, споткнувшись, вы упали вниз и разбились насмерть");
                            Die();
                            break;
                        case 2:
                            otvet = 0;
                            Console.Clear();
                            Console.WriteLine("Настало утро. Вы, полные сил, отправились вниз по горе. Дальше вы увидели, что этот водопад впадает в озеро. Это озеро простиралось вдоль всей горы. Оно было очень холодное. Рядом было множество поваленных деревьев, а с собой вы прихватили десяток метров верёвки. \n 1. Попытаться переплыть озеро вплавь \n 2. Соорудить плот из подручных материалов");
                            otvet = Convert.ToByte(Console.ReadLine());
                            switch (otvet)
                            {
                                case 1:
                                    otvet = 0;
                                    Console.Clear();
                                    Console.WriteLine("Вы переплыли почти половину озера, но вдруг из-за холода у вас на ноге взяла судорога. \n 1. Поколоть себя в ногу острым камнем \n 2. Попытаться перетерпеть боль");
                                    otvet = Convert.ToByte(Console.ReadLine());
                                    switch (otvet)
                                    {
                                        case 1:
                                            Console.WriteLine("Вы успешно переплыли озеро и отправились к замку");
                                            break;
                                        case 2:
                                            Console.WriteLine("Вы попытались, но ваша боль разрослась на столько, что вы не могли двигаться........  \n Вы утонули в озере");
                                            Die();
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Вы успешно переплыли озеро и отправились к замку");
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public static void Castle()
        {
            otvet = 0;
            Console.Clear();
            Console.WriteLine("Вы подошли к замку. У входа в него стоял задремавший толстый охранник. Вы заметили, что отверстия решётки ворот достаточного размера чтобы пролезть в них \n 1. Тихо пролезть через решётку. \n 2. Ударить охранника мечом и пролезть в отверстие решётки.");
            otvet = Convert.ToByte(Console.ReadLine());
            switch (otvet)
            {
                case 1:
                    continue_mission = false;
                    otvet = 0;
                    Console.Clear();
                    Console.WriteLine("Пройдя через решётку, вы увидели то, ради чего сюда пришли – дракона. Его и ваши глаза уже наполнились огнём гнева и ярости. \n 1. Ударить дракона в грудь мечом. \n 2. Бежать из замка.");
                    otvet = Convert.ToByte(Console.ReadLine());
                    switch (otvet)
                    {
                        case 1:
                            Console.WriteLine("\t Дракон повержен! \n \t Теперь весь замок вместе с сокровищницей подчинён вам!");
                            Die();
                            break;
                        case 2:
                            if (ohrannik_die == true)
                            {
                                otvet = 0;
                                Console.Clear();
                                Console.WriteLine("Вы бежали из замка. Но чувство долга вас сильно мучает. \n 1. Вернуться и завершить своё дело! \n 2. Вернуться обратно в родной город");
                                otvet = Convert.ToByte(Console.ReadLine());
                                switch (otvet)
                                {
                                    case 1:
                                        continue_mission = true;
                                        break;
                                    case 2:
                                        Console.WriteLine("Вы вернулись в город. Там вы начали вести оседлый образ жизни работая пастухом. Но состарившись вы поняли, что упустили свой шанс – отомстить за отца. Так вы и умерли с чувством не выполненного долга.");
                                        Die();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы пролезли через решётку, но проснувшийся охранник поймал вас. Вас посадили в темницу, находящуюся под замком, и там вы провели всю свою оставшуюся жизнь.");
                                Die();
                            }
                            
                            //otvet = 0;
                            //Console.Clear();
                            //Console.WriteLine("");
                            //otvet = Convert.ToByte(Console.ReadLine());
                            //switch (otvet)
                            //{
                            //    case 1:
                            //        break;
                            //}
                            break;
                    }
                    if (continue_mission == true)
                    {
                        goto case 1;
                    }
                    break;
                case 2:
                    ohrannik_die = true;
                    goto case 1;
            }
        }
        public static void Die()
        {
            otvet = 0;
            Console.WriteLine("Хотите попробовать ещё раз? \n 1. Да \n 2. Нет");
            otvet = Convert.ToByte(Console.ReadLine());
            switch (otvet)
            {

                case 1:
                    Console.Clear();
                    Vonucheye_Wetland();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
