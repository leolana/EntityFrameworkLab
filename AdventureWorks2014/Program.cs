using System;
using System.Data.Entity;
using System.Linq;
using AdventureWorks2014.Core.Entities;
using AdventureWorks2014.Core.Infrastructure.DataAccess;

namespace AdventureWorks2014
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                //Ele recebe função que retorna uma string
                //context.Database.Log = (s) => Console.WriteLine(s); // (s) => Console.WriteLine(s); -> pode ser uma classe que faz Log em um arquivo texto
                context.Database.Log = Console.WriteLine;

                //Uma consulta com ADO.net
                //var command = new SqlCommand("SELECT DepartmentId, Name, GroupName, ModifiedDate FROM Humans.Department WHERE DepartmentId = 1");

                foreach (var department in context.Departments.Where(d => d.Name.Contains("a")))
                {
                    Console.WriteLine("Departamento {0}", department.Name);
                }

                //Paginado
                var departments = context.Departments.OrderBy(d => d.Name)
                                                     .Skip(0) //Registro que será iniciado 
                                                     .Take(5); //Quantidade de registros retornados

                foreach (var department in departments)
                {
                    Console.WriteLine("Departamento {0}", department.Name);
                }

                //Atualizando apenas uma propriedade apenas
                context.Configuration.ValidateOnSaveEnabled = false;
                var depart = new Department { Id = 1 };
                context.Departments.Attach(depart);
                context.Entry(depart).State = EntityState.Unchanged;

                depart.Name = "Recursos Humanos";

                context.SaveChanges();

                //Dessa forma falamos para o EF, não fazer o tracking da lista de objetos, ou seja, ele não fica olhando e buscando por mudanças
                var departments2 = context.Departments.AsNoTracking().ToArray();

                Console.Read();
            }
        }
    }
}
