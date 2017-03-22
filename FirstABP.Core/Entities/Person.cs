using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FirstABP.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Person : Entity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 这个人所属的省份
        /// </summary>
        public virtual Province Province { get; set; }
    }
}
