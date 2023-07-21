using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicManagement.Models
{
    public class Settings
    {
        public static string UserName { get; set; }
        public static string CartId { get; set; }
        public static int UserId { get; set; }
        public static int Role { get; set; } = 0;
    }
}
