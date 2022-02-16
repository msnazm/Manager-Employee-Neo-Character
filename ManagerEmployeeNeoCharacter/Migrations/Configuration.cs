namespace ManagerEmployeeNeoCharacter.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using ManagerEmployeeNeoCharacter.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ManagerEmployeeNeoCharacter.DAL.ManagerEmployeeNeoCharacterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ManagerEmployeeNeoCharacter.DAL.ManagerEmployeeNeoCharacterContext context)
        {
            var employees = new List<Employee>
            {
                new Employee {  FirstMidName = "Carson",   LastName = "Alexander", 
                    EnetrDate = "1392-09-01", NameFather = "msn", BirthCertificateNumber = "Carson",    HomeAddress = "Alexander", 
                     MobileTell = "1392-09-01",  TheCompanyJobs = "msn", HomeTell = "Carson",    OfficeAddress = "Alexander", 
                     BirthDate = "1392-09-01",  Province = "msn", NationalCode = "Carson"  },
               
                

                
            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var neos = new List<Neo>
            {
            new Neo { N = 23,   E = 22, 
                    O = 44, A = 45, C = 33, EmployeeID= 1 },
          
              
            };
            neos.ForEach(s => context.Neos.AddOrUpdate(p => p.NeoID, s));
            context.SaveChanges();

            var characters = new List<Character>
            {
            new Character { A = 23,   B = 22, 
                    G = 44, D = 45, H = 33, EmployeeID= 1 },
           
              
            };
            characters.ForEach(s => context.Characters.AddOrUpdate(p => p.CharacterID, s));
            context.SaveChanges();

            var statuss = new List<Statuss>
            {
            new Statuss { NumberSend = 1,   Attach = "ok", 
                   Status = true, EmployeeID= 1 },
           
              
            };
            statuss.ForEach(s => context.Statusss.AddOrUpdate(p => p.StatussID, s));
            context.SaveChanges();
        }
    }
}
