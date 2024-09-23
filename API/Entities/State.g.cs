using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PatientProject.Entities
{
#pragma warning disable
    /// <summary> 
    /// Represents a state entity with essential details
    /// </summary>
    public class State
    {
        /// <summary>
        /// Initializes a new instance of the State class.
        /// </summary>
        public State()
        {
            Flagged = false;
        }

        /// <summary>
        /// Required field TenantId of the State 
        /// </summary>
        [Required]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the State 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field EntityCode of the State 
        /// </summary>
        [Required]
        public string EntityCode { get; set; }

        /// <summary>
        /// Required field EntitySubTypeCode of the State 
        /// </summary>
        [Required]
        public string EntitySubTypeCode { get; set; }

        /// <summary>
        /// Required field CreatedBy of the State 
        /// </summary>
        [Required]
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the State 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Required field IsStandard of the State 
        /// </summary>
        [Required]
        public bool IsStandard { get; set; }

        /// <summary>
        /// Required field Flagged of the State 
        /// </summary>
        [Required]
        public bool Flagged { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the State belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
        /// <summary>
        /// Active of the State 
        /// </summary>
        public Guid? Active { get; set; }
        /// <summary>
        /// ParentId of the State 
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// Code of the State 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the State 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// UpdatedBy of the State 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the State 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}