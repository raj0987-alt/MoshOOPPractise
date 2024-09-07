using DictionaryKV;

Person person1 = new Person()
{
    Id = 1,
    Name = "John",
    Address = "Dhaka"
};
Person person2 = new Person()
{
    Id = 2,
    Name = "Mike",
    Address = "Delhi"
};
Person person3 = new Person()
{
    Id = 1,
    Name = "Tawhid",
    Address = "Katar"
};

Dictionary<int, Person> personDictionary = new Dictionary<int, Person>();

personDictionary.Add(1, person1);
personDictionary.Add(2, person2);
personDictionary.Add(3, person3);

foreach(KeyValuePair<int, Person> person in personDictionary)
{
    Console.WriteLine(person.Value.Name);
    
}