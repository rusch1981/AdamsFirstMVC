using AdamsFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsFirstMVC.DAL
{
    interface IClickableAreaRepository: IDisposable
    {
        IEnumerable<ClickableArea> GetClickableAreas();
        ClickableArea GetClickableAreaByName(string clickableAreaName);
        ClickableArea GetClickableAreaByID(int clickableAreaID);
        void InsertClickableArea(ClickableArea clickableArea);
        void DeleteClickableArea(int clickableAreaID);
        void UpdateClickableArea(ClickableArea clickableArea);

        void Save();
    }
}
