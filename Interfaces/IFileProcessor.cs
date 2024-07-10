using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS.HW6.Interfaces
{
    public interface IFileProcessor
    {
        Task<int> CountSpacesInFolder(string path);
    }
}
