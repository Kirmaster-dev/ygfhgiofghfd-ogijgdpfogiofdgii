        
        string raceCharacter = "";
        string classCharacter = "";
        int  ageCharacter = 0;
        int  strength = 0;
        int  dexterity = 0;
        int  intelligence = 0;
        int globalSum = 0;
        int health = 0;
        int attack = 0;
        int mana = 0;
        int boost = 0;
        int endurance = 0;
        int recovery = 0;
        double maxHealth = 0;
        void characterType()
        {
              switch (classCharacter)
              {
                  case "Воин":
                        Console.WriteLine("Воин");
                        break;
                  case "Маг":
                        Console.WriteLine("Маг");
                        break;
                  case "Разбойник":
                        Console.WriteLine("Разбойник");
                        break;
                  default:
                        Console.WriteLine("Неизвестный класс");
                }


        }
        void statusCharacter(int health, double maxHealth)
        {
              Console.WriteLine("Проверка здоровья персонажа:");
              if (health > 70 * maxHealth / 100)
               {
                    Console.WriteLine("Здоровье отличное!");
               }
               else if (health >= 30 * maxHealth / 100 &&  health <= 70 * maxHealth /100 )
               {
                    Console.WriteLine("Здоровье тяжелое!");
               }
               else if (health <= 30 * maxHealth)
               {
                    Console.WriteLine("Здоровье критическое!");
               }
        }

        void characterGenerator()
        {
                Console.WriteLine("Character Generator");
                Console.WriteLine("Введите расу вашего персонажа:");
                raceCharacter =  Console.ReadLine();
                Console.WriteLine("Введите класс вашего персонажа:");
                classCharacter = Console.ReadLine();
                Console.WriteLine("Введите возраст персонажа:");
                ageCharacter = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите силу вашего персонажа:");
                strength = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ловкость персонажа:");
                dexterity = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите интеллект персонажа:");
                intelligence = int.Parse(Console.ReadLine());
                globalSum = strength + dexterity + intelligence;
                health = 100 + strength * 10;
                attack = strength * 2 + dexterity;
                mana = 50 + intelligence * 5;
                boost = (intelligence + attack + mana) * 10;
                endurance = health + intelligence + dexterity;
                recovery = (health + mana) / 100;
                maxHealth = 1000000000000000;

                Console.WriteLine("Ваш персонаж:");
                Console.WriteLine($"Общая сумма характеристик: {globalSum}");
                Console.WriteLine($"Здоровье: {health}");
                Console.WriteLine($"Атака: {attack}");
                Console.WriteLine($"Мана: {mana}");
                Console.WriteLine($"Раса: { raceCharacter}");
                Console.WriteLine($"Класс: {classCharacter}");
                Console.WriteLine($"Возраст: {ageCharacter}");
                Console.WriteLine($"Сила: { strength}");
                Console.WriteLine($"Ловкость: {dexterity}");
                Console.WriteLine($"Интеллект: {intelligence}");
                Console.WriteLine($"Мутация: {boost}");
                Console.WriteLine($"Выносливость: {endurance}");
                Console.WriteLine($"Восстановление: {recovery} %");
        }
        
        characterGenerator();
        statusCharacter(health, maxHealth);
