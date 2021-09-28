using Abp.Domain.Entities.Auditing;
using sweet.log.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweet.log.Collections
{
    public class Collection:AuditedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Post> Posts { get; set; }
    }
}
