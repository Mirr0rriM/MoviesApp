using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;

namespace MoviesApp.ViewModels
{

    public class InputActorViewModel
    {
        [NameValidation(4)]
        public string Name { get; set; }
        
        [NameValidation(4)]
        public string Surname { get; set; }

        [DataType(DataType.Date)] 
        public DateTime BirthDate { get; set; }
    }
}