using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using sweet.log.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweet.log.Posts
{
    public class Post : AuditedEntity, IHasCreationTime
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }
        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
    }
}
