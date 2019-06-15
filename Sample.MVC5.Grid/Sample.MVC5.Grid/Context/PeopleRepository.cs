using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Sample.MVC5.Grid.Models;

namespace Sample.MVC5.Grid.Context
{
    public static class PeopleRepository
    {
        public static IEnumerable<Person> GetPeople()
        {
            ////search = (search ?? "").ToLower();

            return new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Joe",
                    Surname = "Crosswave",
                    ////MaritalStatus = MaritalStatus.Married,

                    //Age = (Int32) (DateTime.Now - new DateTime(1988, 01, 05)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 01),
                    Confirmed = false
                },
                new Person
                {
                    Id = 2,
                    Name = "Merry",
                    Surname = "Lisel",
                    ////MaritalStatus = MaritalStatus.Widowed,

                    ////Age = (Int32) (DateTime.Now - new DateTime(1978, 05, 06)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 02),
                },
                new Person
                {
                    Id = 3,
                    Name = "Henry",
                    Surname = "Crux",
                    ////MaritalStatus = MaritalStatus.Single,

                    ////Age = (Int32) (DateTime.Now - new DateTime(1990, 11, 19)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 03),
                    Confirmed = true
                },
                new Person
                {
                    Id = 4,
                    Name = "Cody",
                    Surname = "Jurut",

                    ////Age = (Int32) (DateTime.Now - new DateTime(1970, 08, 11)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 04),
                    Confirmed = false
                },
                new Person
                {
                    Id = 5,
                    Name = "Simon",
                    Surname = "Scranton",
                    ////MaritalStatus = MaritalStatus.Single,

                    ////Age = (Int32) (DateTime.Now - new DateTime(1985, 10, 10)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 05),
                },
                new Person
                {
                    Id = 6,
                    Name = "Leena",
                    Surname = "Laurent",
                    ////MaritalStatus = MaritalStatus.Divorced,

                    ////Age = (Int32) (DateTime.Now - new DateTime(2000, 07, 01)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 06),
                    Confirmed = false
                },
                new Person
                {
                    Id = 7,
                    Name = "Ode",
                    Surname = "Cosmides",
                    ////MaritalStatus = MaritalStatus.Married,

                    ////Age = (Int32) (DateTime.Now - new DateTime(1966, 04, 17)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 10),
                    Confirmed = true,
                    
                },
                new Person
                {
                    Id = 8,
                    Name = "Diandra",
                    Surname = "Mizner",
                    ////MaritalStatus = MaritalStatus.Single,

                    ////Age = (Int32) (DateTime.Now - new DateTime(1999, 08, 20)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 11),
                    Confirmed = false
                },
                new Person
                {
                    Id = 9,
                    Name = "Pete",
                    Surname = "Cassel",
                    ////MaritalStatus = MaritalStatus.Married,

                    ////Age = (Int32) (DateTime.Now - new DateTime(1997, 03, 13)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 12),
                    Confirmed = false
                },
                new Person
                {
                    Id = 10,
                    Name = "Nicky",
                    Surname = "Tremblay",
                    ////MaritalStatus = MaritalStatus.Married,

                    ////Age = (Int32) (DateTime.Now - new DateTime(1988, 01, 05)).TotalDays / 365,
                    ActivateDate = new DateTime(2019, 06, 13),
                    Confirmed = true,
                    
                }
            }.ToList();
        }

    }
}