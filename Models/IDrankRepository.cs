using System;
using System.Collections.Generic;

namespace DrankAPI.Models{
    public interface IDrankRepository
    {
        Drank GetDrank(int Id);

        IEnumerable<Drank> GetAllDrank();

        Drank Add(Drank drank);
        Drank Remove(Drank model);
    }
}