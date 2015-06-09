using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Concrete.DatabaseLog.Entities
{
    [Table("LogData")]
    public class LogData
    {
        [Key]
        public int LogId { get; set; }

        [Required,StringLength(1000)]
        public string Message { get; set; }
    }
}
