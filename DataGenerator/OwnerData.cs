using OwnerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnerAPI.DataGenerator
{
    public class OwnerData
    {
        public List<Owner> GetAllOwners()
        {
            return new List<Owner>
            {
                new Owner
                {
                    Id = 1,
                    NameSurname = "İlber Ortaylı",
                    CreatedDate = DateTime.Now,
                    Genre = "History",
                    Description = "Lorem ipsum description"
                },
                new Owner
                {
                    Id = 2,
                    NameSurname = "Celal Şengör",
                    CreatedDate = DateTime.Now,
                    Genre = "Geologist",
                    Description = "Lorem ipsum description hack"
                },
                new Owner
                {
                    Id = 3,
                    NameSurname = "Şadi Evren Şeker",
                    CreatedDate = DateTime.Now,
                    Genre = "Artificial Intelligence",
                    Description = "Lorem ipsum description"
                },
                new Owner
                {
                    Id = 4,
                    NameSurname = "Atsız",
                    CreatedDate = DateTime.Now,
                    Genre = "History",
                    Description = "Lorem ipsum description hack"
                }
            };
        }
    }
}
