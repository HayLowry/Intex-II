using System;
using Mummies.Controllers;

namespace Mummies.Models.Repo
{
	public class EFMummyRepository : IMummyRepository
	{
        private MummiesDatabaseContext _context { get; set; }

        public EFMummyRepository(MummiesDatabaseContext temp)
        {
            _context = temp;
        }

        public IQueryable<Burialmain> burialdata => _context.Burialmains;
	}
}

