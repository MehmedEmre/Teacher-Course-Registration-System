using FirstEntitiyFrameworkCore.RedisCacheManagers.Abstract;
using FirstEntityFrameworkCore.Buisness.Manager;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstEntitiyFrameworkCore.RedisCacheManagers
{

    //Neden Redis?
    // Redis verileri öncelikli olarak kendi makinemizin RAM’inde tutar. Bunun dışında isteğe bağlı olarak verilerimizi belirli zaman aralıklarında diske de kaydedebilir.Böylelikle istediğimiz zaman verilerimize diskten ulaşabilir, aynı zamanda veri kaybı gibi problemlerin de önüne geçebiliriz. Redis’in verileri bellekte tutmasının en önemli avantajlarından bir diğeri ise okuma ve yazma işlemlerini milisaniyelere kadar düşürebilmesidir.

    public class RedisCacheManager : IRedisCacheService
    {

        private string ConntectionString { set; get; }
        private readonly IConfiguration _configuration;
        private RedisCacheOptions options;
        private RedisCache redisCache;
        private LessonManager lessonManager = new LessonManager();
        private InstructorManager instructorManager = new InstructorManager();
        private BranchManager branchManager = new BranchManager();

        public RedisCacheManager(IConfiguration configuration)
        {
            _configuration = configuration;

            ConntectionString = configuration["ConnectionStringRedisCache:Redis"];

            options = new RedisCacheOptions()
            {
                Configuration = ConntectionString
            };

            this.redisCache = new RedisCache(options);
        }

        public List<Teacher> SetInstructors()
        {
            List<Teacher> model = instructorManager.List();

            var jsonModel = JsonConvert.SerializeObject(model);

            var options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(20));

            redisCache.Set("instructor-list", Encoding.UTF8.GetBytes(jsonModel), options);

            return model;
        }

        public List<Teacher> GetInstructors()
        {
            var value = redisCache.Get("instructor-list");

            if (value != null)
            {
                string cacheItem = Encoding.UTF8.GetString(value);//Byte Array To String

                return JsonConvert.DeserializeObject<List<Teacher>>(cacheItem);
            }

            return SetInstructors();
        }

        public void RemoveInstructors()
        {
            redisCache.Remove("instructor-list");
        }

        public List<Lessons> SetLessons()
        {
            List<Lessons> model = (from lesson in lessonManager.List()
                                   join teacher in instructorManager.List()
                                   on lesson.TeacherId equals teacher.id
                                   select new Lessons
                                   {
                                       id = lesson.id,
                                       name = lesson.name,
                                       ownerTeacherName = lesson.name,
                                       ownerTeacherSurname = lesson.ownerTeacherSurname,
                                       ownerBranch = lesson.ownerBranch
                                   }).ToList();

            var jsonModel = JsonConvert.SerializeObject(model);

            var options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(20));

            redisCache.Set("lesson-list", Encoding.UTF8.GetBytes(jsonModel), options);

            return model;
        }


        public List<Lessons> GetLessons()
        {
            var value = redisCache.Get("lesson-list");

            if (value != null)
            {
                string cacheItem = Encoding.UTF8.GetString(value);

                return JsonConvert.DeserializeObject<List<Lessons>>(cacheItem);
            }

            return SetLessons();

        }

        public void RemoveLessons()
        {
            redisCache.Remove("lesson-list");
        }

        public List<Branch> SetBranchs()
        {
            List<Branch> model = branchManager.List();

            var jsonModel = JsonConvert.SerializeObject(model);

            var options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(20));

            redisCache.Set("branch-list", Encoding.UTF8.GetBytes(jsonModel), options);

            return model;
        }

        public List<Branch> GetBranchs()
        {
            var value = redisCache.Get("branch-list");

            if (value != null)
            {
                string cacheItem = Encoding.UTF8.GetString(value);//Byte Array To String

                return JsonConvert.DeserializeObject<List<Branch>>(cacheItem);
            }

            return SetBranchs();
        }

        public void RemoveBranchs()
        {
            redisCache.Remove("branch-list");
        }

    }
}
