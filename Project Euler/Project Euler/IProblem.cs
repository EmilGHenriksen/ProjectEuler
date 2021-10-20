using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    interface IProblem<T>
    {
        T Solution();
    }
}
