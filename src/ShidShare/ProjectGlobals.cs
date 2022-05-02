namespace ShidShare
{
    public class ProjectGlobals
    {
        public string DefaultImageUploadLocation { get; } = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images");
        public long MaxUploadFileSize { get; } = 1024 * 1024 * 1024 * 2L; //2GB
        public int MaxUploadAllowedFiles { get; } = 4;
    }
}
