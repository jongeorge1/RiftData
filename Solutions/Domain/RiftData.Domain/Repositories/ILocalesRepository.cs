using System.Collections.Generic;
using System.Linq;
using RiftData.Domain.Entities;

namespace RiftData.Domain.Repositories
{
    public interface ILocalesRepository
    {
        IQueryable<Locale> List { get; }

        Locale GetById(int id);

        IList<Locale> GetLocalesWithSpecies(int speciesId);
    }
}