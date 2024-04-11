using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TagService
    {
        TagRepository repository = new TagRepository();
        public List<(string tenTag, string maGiaoViec, string moTa)> getAllTag()
        {
            return repository.GetAllTags();
        }

        public List<(string tenTag, string maGiaoViec, string moTa)> getTaskTagInfo(string ID)
        {
            return repository.GetTagsByMaGiaoViec(ID);
        }

        public bool createNewTab(string name, string description)
        {
            return repository.Create(name, description);
        }

        public bool addTag(string name, string ID, string description)
        {
            return repository.Add(name, ID, description);
        }
    }
}
