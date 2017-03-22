using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FirstABP.Entities
{
    public class Province : Entity
    {
        /// <summary>
        /// 省份名称
        /// </summary>
        [Required]
        public string ProvinceName { get; set; }
    }
}
