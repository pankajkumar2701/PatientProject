using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PatientProject.Entities
{
#pragma warning disable
    /// <summary> 
    /// Represents a city entity with essential details
    /// </summary>
    public class City
    {
        /// <summary>
        /// Initializes a new instance of the City class.
        /// </summary>
        public City()
        {
            Flagged = false;
        }

        /// <summary>
        /// Required field TenantId of the City 
        /// </summary>
        [Required]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the City 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field EntityCode of the City 
        /// </summary>
        [Required]
        public string EntityCode { get; set; }

        /// <summary>
        /// Required field EntitySubTypeCode of the City 
        /// </summary>
        [Required]
        public string EntitySubTypeCode { get; set; }

        /// <summary>
        /// Required field Flagged of the City 
        /// </summary>
        [Required]
        public bool Flagged { get; set; }

        /// <summary>
        /// Required field CreatedBy of the City 
        /// </summary>
        [Required]
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the City 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Required field IsStandard of the City 
        /// </summary>
        [Required]
        public bool IsStandard { get; set; }
        /// <summary>
        /// ParentId of the City 
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// UpdatedBy of the City 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the City 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Code of the City 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the City 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the City belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
        /// <summary>
        /// Foreign key referencing the State to which the City belongs 
        /// </summary>
        public Guid? StateId { get; set; }

        /// <summary>
        /// Navigation property representing the associated State
        /// </summary>
        [ForeignKey("StateId")]
        public State? StateId_State { get; set; }
        /// <summary>
        /// MunicipalityId of the City 
        /// </summary>
        public Guid? MunicipalityId { get; set; }
        /// <summary>
        /// Active of the City 
        /// </summary>
        public Guid? Active { get; set; }
    }
}