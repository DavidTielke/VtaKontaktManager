using System.Collections.Generic;
using System.Linq;
using VTA.ContactManager.CrossCutting.DataClasses;
using VTA.ContactManager.Data.Repositories;

namespace VTA.ContactManager.Logic.PersonManagement
{
    public class PersonManager
    {
        private readonly PersonRepository _repository;

        public PersonManager()
        {
            _repository = new PersonRepository();
        }


        public List<Person> GetAllChildren()
        {
            return _repository.Load().Where(p => p.Age < 18).ToList();
        }

        public List<Person> GetAllAdults()
        {
            return _repository.Load().Where(p => p.Age >= 18).ToList();
        }
    }
}