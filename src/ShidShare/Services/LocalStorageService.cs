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

        public async Task SaveImageAsync(string path, IBrowserFile image)
        {
            //TODO Validations (FileSize, Count, Type)


                await using FileStream fs = new(path, FileMode.Create);
                await image.OpenReadStream(maxAllowedSize: _projectGlobals.MaxUploadFileSize).CopyToAsync(fs);
                await fs.FlushAsync();
        }
    }
}
