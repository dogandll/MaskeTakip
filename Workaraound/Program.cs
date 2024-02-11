using Business.Concrete;
using Entities.Concrete;

#region Degiskenler
//string message= "Merhaba";
//double total = 100000;
//int price = 100;
//bool IsLogined = true;

//string name = "Doğan";
//string surName = "Dellal";
//int birthDate = 1991;
//long Identity = 12412312423;

//Console.WriteLine(price*1.29);


#endregion




Person p = new Person() { FirstName = "Doğan", LastName = "Dellal", DateOfBirthYear = 1991, Identity = 1 };
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(p);