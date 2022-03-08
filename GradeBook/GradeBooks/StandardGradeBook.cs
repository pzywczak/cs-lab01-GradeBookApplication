using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool enable) : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
