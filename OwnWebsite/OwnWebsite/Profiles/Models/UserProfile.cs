namespace OwnWebsite.Profiles.Models;

public sealed class UserProfile
{
    public required string Id { get; init; }
    public required string Slug { get; init; }
    public required string FullName { get; init; }
    public string? ProfessionalTitle { get; init; }
    public string? ProfileImageUrl { get; init; }
    public string? CoverImageUrl { get; init; }
    public string? ShortDescription { get; init; }
    public string? About { get; init; }
    public string? BusinessName { get; init; }
    public string? Location { get; init; }
    public string? Email { get; init; }
    public string? PhoneNumber { get; init; }
    public string? WebsiteUrl { get; init; }
    public int? YearsOfExperience { get; init; }
    public string? AvailabilityStatus { get; init; }
    public IReadOnlyList<string> Skills { get; init; } = Array.Empty<string>();
    public IReadOnlyList<ServiceItem> Services { get; init; } = Array.Empty<ServiceItem>();
    public IReadOnlyList<PortfolioProject> Projects { get; init; } = Array.Empty<PortfolioProject>();
    public IReadOnlyList<SocialLink> SocialLinks { get; init; } = Array.Empty<SocialLink>();
    public IReadOnlyList<CustomSection> CustomSections { get; init; } = Array.Empty<CustomSection>();
}
