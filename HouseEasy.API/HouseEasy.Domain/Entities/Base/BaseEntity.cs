using System.ComponentModel.DataAnnotations.Schema;

namespace HouseEasy.Domain.Entities.Base
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}