using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAdal.Domain.Entities
{
    public class ReleaseRequest
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please select a build")]
        public string Product { get; set; }
        public string Branch { get; set; }
        [Required(ErrorMessage = "Please enter a version number")]
        public string VersionNumber { get; set; }
        [Required(ErrorMessage = "Please enter the Release Notes")]
        public string ReleaseNotes { get; set; }
    }
}
