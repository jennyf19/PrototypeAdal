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
        [Key]
        public int VersionId { get; set; }
        public string Name { get; set; }
        public int ApprovalStatusId { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDateTime { get; set; }
        public string ReleaseNotes { get; set; }
        public int BranchId { get; set; }
        public DateTime SubmissionDateTime { get; set; }
    }
    /*[Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please select a build")]
        public string Product { get; set; }
        public string Branch { get; set; }
        [Required(ErrorMessage = "Please enter a version number")]
        public string VersionNumber { get; set; }
        [Required(ErrorMessage = "Please enter the Release Notes")]
        public string ReleaseNotes { get; set; }*/
}
