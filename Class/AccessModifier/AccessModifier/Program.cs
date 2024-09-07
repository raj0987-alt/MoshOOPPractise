using AccessModifier;

Person person = new Person();

person.SetBirthDate(new DateTime(2000, 3, 30));

ExtraPerson extraPerson = new ExtraPerson();



Console.WriteLine(person.GetBirthDate());
extraPerson.Name = "Raj";
Console.WriteLine(extraPerson.Name);

PersonInfo personInfo = new PersonInfo(new DateTime(1993, 10, 1));
//personInfo.BirthDate = /*new DateTime(1993, 10, 1)*/;
Console.WriteLine(personInfo.Age);