using OwnWebsite.Profiles.Models;

namespace OwnWebsite.Profiles.Services;

public interface IProfileService
{
    Task<UserProfile?> GetProfileBySlugAsync(string slug, CancellationToken cancellationToken = default);
}
