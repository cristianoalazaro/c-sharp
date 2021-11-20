using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System.Linq;
using System;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.SalesRecord.Any() ||
                _context.Seller.Any())
            {
                return; //DB has been seede
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Cristiano Aparecido Lázaro", "cristianoalazaro@hotmail.com", new DateTime(1976, 8, 2), 1000.0, d1);
            Seller s2 = new Seller(2, "Elenice Cardoso Lázaro", "niceclazaro@gmail.com", new DateTime(1978, 7, 29), 2000.0, d3);
            Seller s3 = new Seller(3, "Cristiane Cardoso Lázaro", "cristianeclazaro@gmail.com", new DateTime(2005, 4, 4), 1500.0, d4);
            Seller s4 = new Seller(4, "Bruno Cardoso Lázaro", "brunoclazaro2010@gmail.com", new DateTime(2010, 5, 28), 2750.5, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2021, 8, 10), 11000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2021, 8, 23), 10500.0, SaleStatus.Billed, s1);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2021, 8, 31), 8750.0, SaleStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2021, 9, 10), 25000.0, SaleStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2021, 9, 11), 9631.0, SaleStatus.Billed, s3);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2021, 9, 02), 7890.0, SaleStatus.Billed, s2);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2021, 10, 01), 31000.0, SaleStatus.Billed, s3);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2021, 10, 01), 11987.0, SaleStatus.Billed, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2021, 10, 13), 15600.0, SaleStatus.Billed, s1);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2021, 11, 10), 13500.0, SaleStatus.Billed, s2);

            _context.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10);

            _context.SaveChanges();
        }
    }
}
