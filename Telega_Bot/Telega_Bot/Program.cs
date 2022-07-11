using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;


var botClient = new TelegramBotClient("5212417980:AAEi2MbtKO9bWPBo26fbENYmaobVPbRqd7U");

using var cts = new CancellationTokenSource();

// StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
var receiverOptions = new ReceiverOptions
{
    AllowedUpdates = Array.Empty<UpdateType>() // receive all update types
};
botClient.StartReceiving(
    updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorAsync,
    receiverOptions: receiverOptions,
    cancellationToken: cts.Token
);

var me = await botClient.GetMeAsync();

Console.WriteLine($"Start listening for @{me.Username}");
Console.ReadLine();

// Send cancellation request to stop bot
cts.Cancel();

async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
{

    // Only process Message updates: https://core.telegram.org/bots/api#message
    if (update.Message is not { } message)
        return;
    // Only process text messages
    if (message.Text is not { } messageText)
        return;

    var chatId = message.Chat.Id;

    Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");

    // Echo received message text
    string[] Hi = new string[] {"Hello", "Hi", "Здравствуйте", "Привет",
                                "привет", "ПРИВЕТ", "HELLO", "HI",
                                "hi", "hello", "здравствуйте", "ЗДРАВСТВУЙТЕ",
                                "Добрый вечер", "Доброе утро", "Добрый день",
                                "ДОБРЫЙ ВЕЧЕР", "ДОБРОЕ УТРО", "ДОБРЫЙ ДЕНЬ",
                                "добрый вечер", "доброе утро", "добрый день",
                                "Bonjour", "Ciao", "Hola", "bonjour",
                                "BONJOUR", "ciao", "CIAO", "HOLA", "hola"};

    foreach (var hi in Hi)
    {
        if (message.Text == hi)
        {
            Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: messageText,
                cancellationToken: cancellationToken);
        }
    }
    if(message.Text == "Фото"|| message.Text == "фото" || message.Text == "ФОТО" || message.Text == "PHOTO" || message.Text == "Photo" || message.Text == "photo" || message.Text == "/фото" || message.Text == "/photo")
    {
        Random rnd = new Random();
        int value = rnd.Next(0, 5);
        if (value == 0)
        {
            Message sentmessage = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/145JZ91vsXm9iUEUMMB0VeGtw0dlpN5uf/view?usp=sharing",
                caption: "<b>~96 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

            Message sentmessage_1 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1JzbTWWUeZUiFaGcNaOYnU6Tu5JoFx-Ya/view?usp=sharing",
                caption: "<b>~72 тысячи рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 1)
        {
            Message sentmessage = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1VRSaLSy2vGmsWOGdfGK6TkmB4-OrKBn2/view?usp=sharing",
                caption: "<b>~120 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

            Message sentmessage_1 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1reTnnmHiTmSt9ibiCgBlIhdED7xLKPnz/view?usp=sharing",
                caption: "<b>~85 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 2)
        {
            Message sentmessage = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1CXsVTKjLxOmBkEQj1dRXczR17aU2Ijia/view?usp=sharing",
                caption: "<b>~144 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

            Message sentmessage_1 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1b6mQu_h4jFMJXEdJ_4DZMzxeEEPbrcWJ/view?usp=sharing",
                caption: "<b>~112 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 3)
        {
            Message sentmessage = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1r9-btqXi3vjKoF7_SZL3qdirmODtT-n_/view?usp=sharing",
                caption: "<b>~166 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

            Message sentmessage_1 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1b7-P_uSCTd1WWYNotAWNde2uXW_0SdxO/view?usp=sharing",
                caption: "<b>~118 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 4)
        {
            Message sentmessage = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/18xUQIvTjBfByaileNCZHIwuiwpbG6gL9/view?usp=sharing",
                caption: "<b>~215 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

            Message sentmessage_1 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/18IR92aINyfHcsW7XGsshpL7UOeA3c26f/view?usp=sharing",
                caption: "<b>~162 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else
        {
            Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Не повезло, не фортануло",
                cancellationToken: cancellationToken);
        }

    }

    if (message.Text == "Видео" || message.Text == "видео" || message.Text == "ВИДЕО" || message.Text == "Video" || message.Text == "video" || message.Text == "VIDEO" || message.Text == "/видео" || message.Text == "/video")
    {

        Random rnd = new Random();
        int value = rnd.Next(0,10);
        Console.WriteLine(value);
        if (value == 0)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Подбор комплектующиих. Сама сборка ПК. Тесты. \nhttps://www.youtube.com/embed/OssUIrrOHI0?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 1)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Подбор комплектующиих.\n https://www.youtube.com/embed/wuyugaedYsY?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 2)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Подбор комплектующиих.\n https://www.youtube.com/embed/wuyugaedYsY?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 3)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Сборка ПК. Тесты.\n https://www.youtube.com/embed/MZOBTjA9UG0?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 4)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Разгон процессора.\n https://www.youtube.com/embed/I8YHUP_L6dY?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 5)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор материнской платы.\n https://www.youtube.com/embed/t0kBKDF3KAQ?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 6)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор SSD.\n https://www.youtube.com/embed/FJaZdw6AuUc?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 7)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор оперативной памяти.\n https://www.youtube.com/embed/Lb_ge3Rf1kw",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 8)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор блока питания.\n https://www.youtube.com/embed/_J9OIMXQJ4U?controls=0",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else if (value == 9)
        {
            Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Почему опасно брать видеокарту на алиэкспрессе\n https://www.youtube.com/embed/IdkOcBT_JMo",
            cancellationToken: cancellationToken);
            Console.WriteLine(value);
        }

        else
        {
            Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Не повезло, не фортануло",
                cancellationToken: cancellationToken);
        }
    }

    if (message.Text == "Все видео" || message.Text == "все видео" || message.Text == "ВСЕ ВИДЕО" || message.Text == "all videos" || message.Text == "All videos" || message.Text == "ALL VIDEOS"|| message.Text == "/all_videos"|| message.Text == "/все_видео") 
    {
        Message sentmessage = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Подбор комплектующиих. Сама сборка ПК. Тесты. \nhttps://www.youtube.com/embed/OssUIrrOHI0?controls=0",
            cancellationToken: cancellationToken);

        Message sentmessage1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Подбор комплектующиих.\n https://www.youtube.com/embed/wuyugaedYsY?controls=0",
            cancellationToken: cancellationToken);

        Message sentmessage2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Подбор комплектующиих.\n https://www.youtube.com/embed/wuyugaedYsY?controls=0",
            cancellationToken: cancellationToken);

        Message sentmessage3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Сборка ПК. Тесты.\n https://www.youtube.com/embed/MZOBTjA9UG0?controls=0",
            cancellationToken: cancellationToken);

        Message sentmessage4 = await botClient.SendTextMessageAsync(
             chatId: chatId,
             text: "Разгон процессора.\n https://www.youtube.com/embed/I8YHUP_L6dY?controls=0",
             cancellationToken: cancellationToken);

        Message sentmessage5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор материнской платы.\n https://www.youtube.com/embed/t0kBKDF3KAQ?controls=0",
            cancellationToken: cancellationToken);

        Message sentmessage6 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор SSD.\n https://www.youtube.com/embed/FJaZdw6AuUc?controls=0",
            cancellationToken: cancellationToken);

        Message sentmessage7 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор оперативной памяти.\n https://www.youtube.com/embed/Lb_ge3Rf1kw",
            cancellationToken: cancellationToken);

        Message sentmessage8 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбор блока питания.\n https://www.youtube.com/embed/_J9OIMXQJ4U?controls=0",
            cancellationToken: cancellationToken);

        Message sentmessage9 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Почему опасно брать видеокарту на алиэкспрессе\n https://www.youtube.com/embed/IdkOcBT_JMo",
            cancellationToken: cancellationToken);
    }

    if (message.Text == "Все фото" || message.Text == "все фото" || message.Text == "ВСЕ ФОТО" || message.Text == "all photos" || message.Text == "ALL PHOTOS" || message.Text == "All photos" || message.Text == " /все_фото" || message.Text == " /all_photos")
    {
        Message sentmessage = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/145JZ91vsXm9iUEUMMB0VeGtw0dlpN5uf/view?usp=sharing",
                caption: "<b>~96 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

        Message sentmessage1 = await botClient.SendPhotoAsync(
            chatId: chatId,
            photo: "https://drive.google.com/file/d/1JzbTWWUeZUiFaGcNaOYnU6Tu5JoFx-Ya/view?usp=sharing",
            caption: "<b>~72 тысячи рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
            parseMode: ParseMode.Html,
            cancellationToken: cancellationToken);
        Message sentmessage2 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1VRSaLSy2vGmsWOGdfGK6TkmB4-OrKBn2/view?usp=sharing",
                caption: "<b>~120 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

        Message sentmessage3 = await botClient.SendPhotoAsync(
            chatId: chatId,
            photo: "https://drive.google.com/file/d/1reTnnmHiTmSt9ibiCgBlIhdED7xLKPnz/view?usp=sharing",
            caption: "<b>~85 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
            parseMode: ParseMode.Html,
            cancellationToken: cancellationToken);

        Message sentmessage4 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1CXsVTKjLxOmBkEQj1dRXczR17aU2Ijia/view?usp=sharing",
                caption: "<b>~144 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

        Message sentmessage5 = await botClient.SendPhotoAsync(
            chatId: chatId,
            photo: "https://drive.google.com/file/d/1b6mQu_h4jFMJXEdJ_4DZMzxeEEPbrcWJ/view?usp=sharing",
            caption: "<b>~112 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
            parseMode: ParseMode.Html,
            cancellationToken: cancellationToken);

        Message sentmessage6 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/1r9-btqXi3vjKoF7_SZL3qdirmODtT-n_/view?usp=sharing",
                caption: "<b>~166 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

        Message sentmessage7 = await botClient.SendPhotoAsync(
            chatId: chatId,
            photo: "https://drive.google.com/file/d/1b7-P_uSCTd1WWYNotAWNde2uXW_0SdxO/view?usp=sharing",
            caption: "<b>~118 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
            parseMode: ParseMode.Html,
            cancellationToken: cancellationToken);

        Message sentmessage8 = await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://drive.google.com/file/d/18xUQIvTjBfByaileNCZHIwuiwpbG6gL9/view?usp=sharing",
                caption: "<b>~215 тысяч рублей</b>. <i>Покупка в САМОМ главном онлайн-магазине по компьютерам в России</i> <i>Source</i>: <a href=\"https://hyperpc.ru/epix\">hyperpc</a>",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

        Message sentmessage9 = await botClient.SendPhotoAsync(
            chatId: chatId,
            photo: "https://drive.google.com/file/d/18IR92aINyfHcsW7XGsshpL7UOeA3c26f/view?usp=sharing",
            caption: "<b>~162 тысяч рублей</b>. <i>Ручная сборка через ДНС</i> <i>Source</i>: <a href=\"https://brigpc.ru/\">brigpc</a>",
            parseMode: ParseMode.Html,
            cancellationToken: cancellationToken);
    }

    if (message.Text == "/start")
    {
        await botClient.SendTextMessageAsync(message.Chat.Id, text: "Вы можете вызвать клавиатуру: /keyboard\nВы можете запросить /фото, /видео, /все_фото , /все_видио, /photo, /video, /all_photos, /all_videos \n" +
            "Или вы можете поприветсвовать бота любым из этих приветствий: Hi, Hello, Hola, Bonjour, Привет, Добрый день");
    }

    if (message.Text == "/keyboard")
    {
        ReplyKeyboardMarkup keyboard = new(new[]
        {
            new KeyboardButton[] {"Видео", "Фото"},
            new KeyboardButton[] {"Все видео", "Все фото" }
        })
        {
            ResizeKeyboard = true
        };
        await botClient.SendTextMessageAsync(message.Chat.Id, text: "Choose", replyMarkup: keyboard);
    }
}
Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    var ErrorMessage = exception switch
    {
        ApiRequestException apiRequestException
            => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
        _ => exception.ToString()
    };

    Console.WriteLine(ErrorMessage);
    return Task.CompletedTask;
}