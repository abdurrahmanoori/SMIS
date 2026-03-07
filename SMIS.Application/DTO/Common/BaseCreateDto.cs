namespace SMIS.Application.DTO.Common
{
    /// <summary>
    /// Base DTO for Create operations with sync support.
    /// Includes audit fields to preserve original timestamps from mobile devices.
    /// </summary>
    public abstract class BaseCreateDto
    {
        /// <summary>
        /// Client-provided ID for offline sync scenarios
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Original creation timestamp from mobile device (sync only)
        /// </summary>
        public DateTime? CreatedDate { get; set; } = null;

        /// <summary>
        /// Original creator from mobile device (sync only)
        /// </summary>
        public string? CreatedBy { get; set; } = null;
    } 
}
