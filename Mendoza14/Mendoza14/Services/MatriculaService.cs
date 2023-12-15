using Mendoza14;
using Mendoza14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mendoza14
{
    public class MatriculaService
    {
        private readonly AppDbContext _context;

        public MatriculaService() => _context = App.GetContext();


        public bool Create(Matricula item)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Matricula> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Matricula> Get()
        {
            return _context.People.ToList();
        }


        public List<Matricula> GetByText(string text)
        {
            return _context.People.Where(x => x.Nombre.Contains(text)).ToList();
        }



    }
}