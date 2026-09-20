namespace SMIS.Application.DTO.Categories
{
    public class CategoryCreateDto
    {
        /// <summary>
        /// Optional client-generated identifier. Offline-first clients create the
        /// row locally before the API is reachable, so they must be able to keep
        /// the same stable identifier when the write is uploaded later.
        /// Online clients may omit this value and keep the existing server-ID flow.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        //[Translatable]
        public string Name { get; set; } = string.Empty;

        public string? Code { get; set; } = string.Empty;

        //[Translatable]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}