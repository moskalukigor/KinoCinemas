//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinemas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cinemas
    {
        public Cinemas()
        {
            this.Movie = new HashSet<Movie>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Movie> Movie { get; set; }
    }
}
