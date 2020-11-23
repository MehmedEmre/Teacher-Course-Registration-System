using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEntitiyFrameworkCore.RedisCacheManagers.Abstract
{
    public interface IRedisCacheService
    {
        List<Lessons> GetLessons();

        List<Lessons> SetLessons();

        void RemoveLessons();

        List<Teacher> SetInstructors();

        List<Teacher> GetInstructors();

        void RemoveInstructors();

        List<Branch> SetBranchs();

        List<Branch> GetBranchs();

        void RemoveBranchs();

        void GetAllRemove();
    }
}
