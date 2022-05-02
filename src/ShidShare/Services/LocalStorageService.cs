using Microsoft.AspNetCore.Components.Forms;

namespace ShidShare.Services
{
    public class LocalStorageService
    {
        private ProjectGlobals _projectGlobals;
        public LocalStorageService(ProjectGlobals projectGlobals)
        {
            _projectGlobals = projectGlobals;
        }

        public async Task SaveImageAsync(IReadOnlyList<IBrowserFile> images)
        {
            //TODO Validations (FileSize, Count, Type)

            foreach (var image in images)
            {
                var newFileName = $"{Path.GetRandomFileName()}.{image.Name.Split(".").Last()}";

                await using FileStream fs = new(@$"{_projectGlobals.DefaultImageUploadLocation}\{newFileName}", FileMode.Create);
                await image.OpenReadStream(maxAllowedSize: _projectGlobals.MaxUploadFileSize).CopyToAsync(fs);
                await fs.FlushAsync();
            }
        }
    }
}
