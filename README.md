13. Классы (Ферма)
Срок заканчивается 1 августа 2020 г., 23:59
Инструкции
Задача № 1 Ферма
Создать абстрактный класс Animal
Поля класса (доступны только для чтения вне класса)
    Имя
    Пол
    
Абстрактные поля:
    Возраст
    Вес
    
Конструкторы:
    добавить конструктор с параметрами (Имя, Возраст, Пол, Вес)
    
Методы:
    добавить абстрактный метод Eat()
    
Создать класс Horse, Sheep, Cow наследовать от Animal
Методы класса:
    реализовать абстрактный метод для каждого класса (При вызове метода вывести на консоль какое животное какой корм ест)
        
Конструкторы:
    добавить конструктор с параметрами (Имя, Возраст, Пол, Вес) : base (Имя, Возраст, Пол, Вес)
    
Дополнительные проверки:
    реализовать абстрактное свойство Возраст (Property) (для всех животных минимальный возраст больше 0)
        Максимальные возраст овцы: 10 лет
        Максимальный возраст лошади: 30 лет
        Максимальный возраст коровы 20 лет
            если условия неверные по возрасту напишите в консоль сообщение об ошибке
            
    реализовать абстрактное свойство Вес (Property) (для всех животных минимальный вес больше 0)
        Максимальные вес овцы: 45 кг
        Максимальный вес лошади: 740 кг 
        Максимальный вес коровы 850 кг
            если условия неверные по весу напишите в консоль сообщение об ошибке
    
Создать класс Farm
Поля класса:
    Название фермы
    Адрес фермы
    
Приватные поля класса:
    Список из Horses
    Список из SheepFlock
    Список из Cows
    
Конструктор:
    добавить конструктор с параметрами (Название фермы, Адрес фермы)
    
Методы класса:
    AddHorse() добавляет Horse в табун
    AddCow(); добавляет Cow в стадо
    AddSheep(); добавляет Sheep в стадо
    FullInfo(); Полная информация о ферме (Название фермы, адрес и вывести по отдельности всех животных)
 
Нужно чтобы пользователь выбирал через консоль какое животное добавить в ферму и так же вывод полной информации о ферме.

Задание нужно предоставить через github.com 