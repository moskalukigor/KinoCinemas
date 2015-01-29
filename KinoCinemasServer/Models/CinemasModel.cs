using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemasProj.Models
{
    public class CinemasModel
    {
        #region Ctor
        public CinemasModel(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        #endregion Ctor

        #region Data Properties
        public int ID { get; set; }
        public string Name { get; set; }
        #endregion Data Properties

    }
}
