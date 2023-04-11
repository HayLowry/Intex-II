using System;
namespace Mummies.Models.Repo
{
	public interface IMummyRepository
	{
		IQueryable<Burialmain> burialdata { get; }
	}
}

