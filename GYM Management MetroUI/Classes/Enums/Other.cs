using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubManagement.Classes.Enums
{
    /// <summary>
    /// other class for any other enum we will need
    /// </summary>
    class Other
    {
        public enum Dir { RIGHT, LEFT, UP, DOWN }; // will handle diagonals later... ex: [TOPLEFT]
        public enum DirStyle { VERTICAL, HORIZONTAL }
    }
}
