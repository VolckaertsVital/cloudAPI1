using System.Collections.Generic;

namespace DrankAPI.Models{
    public interface IDrankRepository
    {
        Drank GetDrank(int Id);

        IEnumerable<Drank> GetAllDrank();
    }
}