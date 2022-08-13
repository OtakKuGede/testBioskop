using Bioskop.Models;
using Bioskop.Models.Studio;
using System;

namespace Bioskop.IService
{
    public interface IMsStudioService
    {
        StudioResponseDto GetStudio();
        StudioResponseDto2 AddStudio(MsStudio po);
        StudioResponseDto2 UpdateStudio(MsStudio o);
        StudioResponseDto2 DeleteStudio(Guid IdStudio);
    }
}
