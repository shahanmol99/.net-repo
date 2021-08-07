using System;
using System.Collections.Generic;
using System.Text;
using ExhibitionLib.Model;
using ExhibitionLib.Repo;
using System.Collections;

namespace ExhibitionLib.Service
{
    public class ExhibitionService
    {
        ExhibitionRepositoryDbContext _repo;

        public ExhibitionService()
        {
            _repo = ExhibitionRepositoryDbContext.GetInstance();
        }

        public IEnumerable GetExhibitionsByOrganizerId(string organizerId)
        {
            return _repo.Get(organizerId);
        }

        public object GetExhibitionByExhibitionId(string organizerid, string exhibitionId)
        {
            return _repo.GetExhibition(organizerid, exhibitionId);
        }
    }
}
