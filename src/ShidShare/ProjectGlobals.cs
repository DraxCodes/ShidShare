namespace ShidShare
{
    public class ProjectGlobals
    {
        public string DefaultImageUploadLocation { get; } = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images");
    }
}
