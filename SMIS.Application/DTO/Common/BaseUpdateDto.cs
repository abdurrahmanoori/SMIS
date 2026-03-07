namespace SMIS.Application.DTO.Common
{
    /// <summary>
    /// Base DTO for Update operations with sync support.
    /// Includes audit fields to preserve original timestamps from mobile devices.
    /// </summary>
    public abstract class BaseUpdateDto
    {
        /// <summary>
        /// Last update timestamp from mobile device (sync only)
        /// </summary>
        public DateTime? UpdatedDate { get; set; } = null;

        /// <summary>
        /// Last updater from mobile device (sync only)
        /// </summary>
        public string? UpdatedBy { get; set; } = null;
    }
}
