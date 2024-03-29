#  doc-archive <br/> Система пошуку архівів та файлів
Версія 1.0

## Лист змін
| Дата | Версія | Опис | Автор |
| --- | --- | --- | --- |
| 27.02.2020 | 1.0 | Чернетка | Тимофеєнко Павло |

## Зміст

 [1.Вступ](#intro)
 + [1.1 Ціль](#intro-goal)
 + [1.2 Контекст](#intro-context)
 
[2. Короткий про продукт](#overview) <br/>
[3. Визначення та інформація](#definitions) <br/>
[4. Призначення пошукової системи по ключовим словам](#destination)
+ [4.1.Взаємовідносини з користувачами](#relationship)
+ [4.2.Схема взаємодії програми з користувачем](#relationship1)
+ [4.3.Схема заповнення бази](#scheme)

**[5. Функціональність](#practicality)**
+ [5.1.	Функціональні вимоги](#5-1)
+ [5.2.	Зручність роботи](#5-2)
+ [5.3.	Надійність роботи](#5-3)
+ [5.4.	Продуктивність програми ](#5-4)

**[Посилання](#links)**



## <a name="intro"></a> 1. Вступ

У цьому документі описуються запити зацікавленої особи, в якості якої виступає доцент Болдак А. О., по відношенню до розробляємої в рамках лаборатних робіт системи пошуку архівів та файлів.

### <a name="intro-goal"></a> 1.1 Ціль

Цілью документа є визначення основних задач, можливі варіанти реалізації даної теми. Визначеня потреб для функціональності, продуктивності та  зробити пошук файлів та документів легшим та швидшим.

### <a name="intro-context"></a> 1.2 Контекст

Перелік основних вимог наведенні нижче. Опис функціоналу який використовує користувач, опис надійності та швидкості отримання результаів.

## <a name="overview"></a> 2. Короткий огляд продукту

Система пошуку архівів та файлів дозволяє швидко пряцювати з великою кількістю файлів та архівів. Архіви та файли обробляються за допомогою додаткового сервісу *Створення Ключових Слів* і заносить результат обробки у базу у форматі файла який містить поля з ключовими словами.

## <a name="definitions"></a>3. Визначення та інформація
 + [Документ][1] - матеріальний об'єкт, що містить у зафіксованому вигляді інформацію, оформлений у зведеному порядку і має відповідно до чинного законодавства юридичну силу.
 + [Документообіг][2] - рух документів в установі від моменту створення або від одержання зі сторони до моменту передачі на зберігання до архіву.
 + [Архів][3] - установа, що здійснює приймання, опис і зберігання документів з метою використання ретроспективної документної інформації.
 + [Електронний архів][4]- система структурованого зберігання електронних документів, що забезпечує надійність зберігання, конфіденційність і розмежування прав доступу, відстеження історії використання документів, швидкий і зручний пошук.
 + [Обробка природної мови][5]- загальний напрям інформатики, штучного інтелекту та математичної лінгвістики. Він вивчає проблеми комп'ютерного аналізу та синтезу природної мови. Стосовно штучного інтелекту аналіз означає розуміння мови, а синтез — генерацію розумного тексту. Розв'язок цих проблем буде означати створення зручнішої форми взаємодії комп'ютера та людини.
 + [Розпізнавання іменованих утворень(NER)][6] - підзадача вилучення інформації, яка прагне знайти та класифікувати названі об’єкти в тексті на заздалегідь визначені категорії, такі як імена осіб, організацій, місця, вирази часу, кількості, грошових значень, відсотків тощо.

## <a name="destination"></a>4.Призначення Пошукової Системи по ключовим словам
Пошук по ключовим словам дає можливість скоротити обє’м пошуку інформації, коли користвач точно не знає який файл чи архів йому потрібен. Результатом буде список файлів, якій були відібрані нашою програмою. Чим більше інформації є у шукача про файл, тим швидше отримає результат і менший об’єм інформації йому доведеться обробити.

### <a name="relationship"></a>4.1.Взаємовідносини з користувачами
+ Програма буде містити зручні та інтуїтивно зрозумілі інструменти для пошуку. Тому користувачу не доведеться витрачати час на зайві дій і це прискорить його роботу з програмою.
### <a name="relationship1"></a>4.2.Схема взаємодії програми з користувачем
 +	Користувач вводить ключові слова.
+	Програма звертається до бази яка містить інфомацію про місце файлу та ключові слова про цей файл.
+	Программа виводить результи які містять ту інформацію яку вказав користувач.
+	Користувач отримує список файлів які містять вказані теги.


### <a name="scheme"></a>4.3.Схема заповнення бази 
  +	Программа використовує додактовий сервіс, який шукає ключові слова(імена,дати,міста.тощо).
+	Наш сервіс відправляє запит на сервіс(*Створення ключових слів*) по обробці файлів і отримує файл формату JSON  який містить поля з тегами. 
+	Программа оброблює JSON файли і записує рузультат у Базу у вигляді 
<p align="center">
  <img src="img1.png"/>
</p> Файл index.txt містить усі теги та шлях до обробленного  файлу. 

## <a name="functionality"></a>5. Функціональність
 ### <a name="5-1"></a>5.1.	Функціональні вимоги 
+ Запис ключових слів у Базу Даних які зберігаються у файлі. Також важливою складовою є можливість створення інтерфеса який дозволяє додавати і видалять файли та архіви.Створення авторизації 
### <a name="5-2"></a>5.2.	Зручність роботи 
+ Програма повинна мати простий, інтуітивно зрозумілий. Також  ля зручності використання програми створюємо фільтри для зручного та швидкого пошуку. Надати можливість користувачу переглянути результати пошуку(вибраний файл відкривається в окремому вікні). 
### <a name="5-3"></a>5.3.	Надійність роботи 
+ Частково завантажувати файли на сервіс(створення ключових слів), щоб уникнути перенавантаження системи.Повинне бути надійний зв'язок з базою
### <a name="5-4"></a>5.4.	Продуктивність програми 
+ Алгоритми обробки файлів та архівів
+ Оптимізація запросів у Базу
### <a name = "5.5"></a>5.5.	Менеджер Архіва
1.	Управління Архівами
2.	Перегляд Історії 
3.	Управління Правами Користувачів
4.	Регістрація Користувачів
### <a name = "5.5"></a>5.6.	Користувач Архіва
1.	Додати/Видалити Архів
2.	Пошук Архівів



### <a name="links"></a>Посилання
[1]: https://buklib.net/books/27318/
 [2]: https://uk.wikipedia.org/wiki/%D0%94%D0%BE%D0%BA%D1%83%D0%BC%D0%B5%D0%BD%D1%82%D0%BE%D0%BE%D0%B1%D1%96%D0%B3 
[3]: https://uk.wikipedia.org/wiki/%D0%90%D1%80%D1%85%D1%96%D0%B2
 [4]: https://uk.wikipedia.org/wiki/%D0%95%D0%BB%D0%B5%D0%BA%D1%82%D1%80%D0%BE%D0%BD%D0%BD%D0%B8%D0%B9_%D0%B0%D1%80%D1%85%D1%96%D0%B2
[5]: https://uk.wikipedia.org/wiki/%D0%9E%D0%B1%D1%80%D0%BE%D0%B1%D0%BA%D0%B0_%D0%BF%D1%80%D0%B8%D1%80%D0%BE%D0%B4%D0%BD%D0%BE%D1%97_%D0%BC%D0%BE%D0%B2%D0%B8
[6]: https://uk.wikipedia.org/wiki/%D0%A0%D0%BE%D0%B7%D0%BF%D1%96%D0%B7%D0%BD%D0%B0%D0%B2%D0%B0%D0%BD%D0%BD%D1%8F_%D1%96%D0%BC%D0%B5%D0%BD%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%85_%D1%81%D1%83%D1%82%D0%BD%D0%BE%D1%81%D1%82%D0%B5%D0%B9




