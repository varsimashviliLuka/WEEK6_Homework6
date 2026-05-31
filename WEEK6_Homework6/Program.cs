namespace WEEK6_Homework6;

class Program
{
    static void Main(string[] args)
    {
        #region task 0.1
        Console.WriteLine("Please enter a word");
        var word = Console.ReadLine();
        var characters_number = new Dictionary<char, int>();
        foreach (var character in word)
        {
            if (characters_number.TryGetValue(character, out var value))
            {
                characters_number[character] = value + 1;
            }
            else
            {
                characters_number[character] = 1;
            }
            
        }

        foreach (var item in characters_number)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
        #endregion

        #region task 0.2

        var cities = new List<string>()
        {
            "Tbilisi", "Batumi", "London", "Madrid", "Rome", "Barcelona", "Kutaisi", "Telavi"
        };

        Console.WriteLine("Please enter the starting letter");
        var start_letter = Console.ReadLine();
        Console.WriteLine("Please enter the ending letter");
        var end_letter = Console.ReadLine();

        var filtered_cities = cities.FindAll(x => x.StartsWith(start_letter, StringComparison.InvariantCultureIgnoreCase) && 
                                                x.EndsWith(end_letter, StringComparison.InvariantCultureIgnoreCase));

        foreach (var city in filtered_cities)
        {
            Console.WriteLine(city);
        }
        
        #endregion
        
        #region task 1

        var oddList = new List<int>();
        var evenList = new List<int>();
        Console.WriteLine("Please Enter Number");
        if (int.TryParse(Console.ReadLine(), out var n))
        {
            for (var i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
                else
                {
                    oddList.Add((i));
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Console.WriteLine("Even Numbers: ");
        foreach (var item in evenList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Odd Numbers: ");
        foreach (var item in oddList)
        {
            Console.WriteLine(item);
        }
        
        
        #endregion
        
        #region task 2

        var contacts_app_running = true;
        Console.WriteLine("Welcome to contacts app");
        var contacts = new Dictionary<string, int>() {{"Luka Varsimashvili", 599555505},{"Satesto", 599764890}};
        while (contacts_app_running){
        
        Console.WriteLine("Please choose option: 1 (add contact), 2 (remove contact), 3 (see all the contacts), 4 (exit app): ");
        if (int.TryParse(Console.ReadLine(), out var option))
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter contact name: ");
                    var contact_add_name = Console.ReadLine();
                    Console.WriteLine("Please enter contact number: ");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        contacts.Add(contact_add_name, number);
                        Console.WriteLine($"Contact added successfully\n{contact_add_name} : {number}");
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;
                case 2:
                    Console.WriteLine("Please type a name of contact");
                    var contact_delete_name = Console.ReadLine();
                    contacts.Remove(contact_delete_name);
                    Console.WriteLine("Contact removed successfully");
                    break;
                case 3:
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine($"{contact.Key} : {contact.Value}");
                    }
                    break;
                case 4:
                    contacts_app_running = false;
                    Console.WriteLine("Exiting app");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
                    
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        }
        #endregion
        
        #region task3

        var num_list = new List<int>()
        {
            1,1,1,2,2,2,2,3,3,3,6,6,6,6,4,4,5,5,8,1,2,9,7,5,3,7,9,3,5,12,12,6,13,13,13
        };

        var results = num_list.GroupBy(x => x);

        var counted = new Dictionary<int, int>();
        
        foreach (var item in results)
        {
            counted.Add(item.First(),item.Count());
        }

        foreach (var item in counted)
        {
            Console.WriteLine($"{item.Key} appears {item.Value} times sum {item.Key*item.Value}");
        }

        #endregion
        
        #region task 4
        
        Console.WriteLine("Please enter number");

        var list_of_numbers = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
        };
        
        if (int.TryParse(Console.ReadLine(), out var num))
        {
            var filtered = list_of_numbers.OrderByDescending(x=>x).Take(num);
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        #endregion

    }
}