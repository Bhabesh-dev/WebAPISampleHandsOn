using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPISampleHandsOn.Models
{
    public  interface IEntity
    {

        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }

        public string CreatedBY { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBY { get; set; }

    }


    public class BaseEntity : IEntity
    {
        public Guid ID { get; set; } = new Guid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string CreatedBY { get; set; } = "Application";

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBY { get; set; }
    }
}
