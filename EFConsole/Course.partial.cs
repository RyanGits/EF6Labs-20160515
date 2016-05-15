using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public partial class Course
    {
        partial void Initialize()
        {
            this.Credits = 5;

            this.CreatedOn = DateTime.Now.AddDays(-30);

        }
    }
}
