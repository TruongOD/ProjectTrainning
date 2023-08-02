using System.ComponentModel.DataAnnotations;

namespace ProjectTrainning.Entities
{
    public class Base
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime LastModifiedBy { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}