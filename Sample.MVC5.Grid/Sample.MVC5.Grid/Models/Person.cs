﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sample.MVC5.Grid.Models
{
    public class Person
    {
        [Display(Name = "Id")]
        public Int32 Id { get; set; }

        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Surname")]
        public String Surname { get; set; }


        [Display(Name = "Age")]
        public Int32 Age { get; set; }

        [Display(Name = "Activatedate")]
        public DateTime ActivateDate { get; set; }

        [Display(Name = "Email confirmed")]
        public Boolean Confirmed { get; set; }

        ////[Display(Name = "Marital status")]
        ////public MaritalStatus? MaritalStatus { get; set; }

        public List<Person> Children { get; set; }

        public Person()
        {
            Children = new List<Person>();
            this.Confirmed = false;
        }
    }
}