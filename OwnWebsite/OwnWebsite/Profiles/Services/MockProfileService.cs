using OwnWebsite.Profiles.Models;

namespace OwnWebsite.Profiles.Services;

public sealed class MockProfileService : IProfileService
{
    private readonly IReadOnlyDictionary<string, UserProfile> profiles =
        new Dictionary<string, UserProfile>(StringComparer.OrdinalIgnoreCase)
        {
            ["user1"] = new UserProfile
            {
                Id = "profile-001",
                Slug = "user1",
                FullName = "Gowthami Chinthamani",
                ProfessionalTitle = "Freelance Full-Stack Developer",
                ProfileImageUrl = "/Images/gowthu1.jpeg",
                CoverImageUrl = "https://images.unsplash.com/photo-1497366811353-6870744d04b2?auto=format&fit=crop&w=1800&q=85",
                ShortDescription = "I build thoughtful digital products that turn complex ideas into simple, useful experiences.",
                About = "I am an independent full-stack developer who partners with ambitious teams to design, build, and improve web products. From the first sketch to a reliable production release, I bring a product-minded approach, clear communication, and modern engineering practices.",
                BusinessName = "Gowthu Creative Studio",
                Location = "Austin, Texas",
                Email = "hello@mayathompson.dev",
                PhoneNumber = "+1 (512) 555-0148",
                WebsiteUrl = "https://mayathompson.dev",
                YearsOfExperience = 9,
                AvailabilityStatus = "Available for select projects",
                Skills = new[] { "C#", ".NET", "Blazor", "TypeScript", "Azure", "UX-minded development" },
                Services = new[]
                {
                    new ServiceItem { Title = "Web application development", Description = "Scalable, accessible applications built around your customers and business goals.", IconClass = "code" },
                    new ServiceItem { Title = "Product prototyping", Description = "Fast, focused prototypes that turn a promising idea into something your team can test.", IconClass = "spark" },
                    new ServiceItem { Title = "Technical consulting", Description = "Practical architecture and delivery guidance for teams growing their digital products.", IconClass = "guide" }
                },
                Projects = new[]
                {
                    new PortfolioProject { Title = "Northstar Analytics", Category = "SaaS platform", Description = "A calm, focused reporting workspace that helps distributed teams make faster decisions.", ImageUrl = "https://images.unsplash.com/photo-1551288049-bebda4e38f71?auto=format&fit=crop&w=900&q=85", ProjectUrl = "https://example.com/northstar" },
                    new PortfolioProject { Title = "Field Notes", Category = "Digital experience", Description = "A content platform that makes sharing research and stories feel effortless.", ImageUrl = "https://images.unsplash.com/photo-1499750310107-5fef28a66643?auto=format&fit=crop&w=900&q=85", ProjectUrl = "https://example.com/field-notes" }
                },
                SocialLinks = new[]
                {
                    new SocialLink { Platform = "LinkedIn", Url = "https://www.linkedin.com", IconClass = "in" },
                    new SocialLink { Platform = "GitHub", Url = "https://github.com", IconClass = "gh" }
                }
            },
            ["creative-studio"] = new UserProfile
            {
                Id = "profile-002",
                Slug = "creative-studio",
                FullName = "Brightside Creative",
                ProfessionalTitle = "Creative & Digital Marketing Studio",
                ProfileImageUrl = "https://images.unsplash.com/photo-1556761175-b413da4baf72?auto=format&fit=crop&w=480&q=85",
                CoverImageUrl = "https://images.unsplash.com/photo-1497366754035-f200968a6e72?auto=format&fit=crop&w=1800&q=85",
                ShortDescription = "Brand stories, campaigns, and digital experiences for businesses ready to grow with confidence.",
                About = "Brightside Creative is a small, senior-led studio helping thoughtful businesses find their voice and show up consistently. We blend strategy, design, and content to create marketing that feels as good as it performs.",
                BusinessName = "Brightside Creative Co.",
                Location = "Portland, Oregon",
                Email = "hello@brightsidecreative.co",
                WebsiteUrl = "https://brightsidecreative.co",
                YearsOfExperience = 12,
                AvailabilityStatus = "Booking autumn projects",
                Skills = new[] { "Brand strategy", "Content design", "Social campaigns", "Web design", "Creative direction" },
                Services = new[]
                {
                    new ServiceItem { Title = "Brand strategy", Description = "A clear point of view and practical positioning that helps your brand stand apart.", IconClass = "strategy" },
                    new ServiceItem { Title = "Campaign creative", Description = "Memorable campaign concepts and assets that connect with the people you want to reach.", IconClass = "campaign" },
                    new ServiceItem { Title = "Content systems", Description = "Flexible content frameworks that help small teams publish with consistency.", IconClass = "content" }
                },
                Projects = new[]
                {
                    new PortfolioProject { Title = "Juniper & Co.", Category = "Brand refresh", Description = "A warm, confident identity system for a modern home goods company.", ImageUrl = "https://images.unsplash.com/photo-1494438639946-1ebd1d20bf85?auto=format&fit=crop&w=900&q=85", ProjectUrl = "https://example.com/juniper" },
                    new PortfolioProject { Title = "Good Ground Market", Category = "Launch campaign", Description = "A joyful launch campaign that introduced a neighborhood market to its community.", ImageUrl = "https://images.unsplash.com/photo-1556742049-0cfed4f6a45d?auto=format&fit=crop&w=900&q=85", ProjectUrl = "https://example.com/good-ground" }
                },
                SocialLinks = new[]
                {
                    new SocialLink { Platform = "Instagram", Url = "https://www.instagram.com", IconClass = "ig" },
                    new SocialLink { Platform = "LinkedIn", Url = "https://www.linkedin.com", IconClass = "in" }
                }
            }
        };

    public Task<UserProfile?> GetProfileBySlugAsync(string slug, CancellationToken cancellationToken = default)
    {
        profiles.TryGetValue(slug.Trim(), out var profile);
        return Task.FromResult(profile);
    }
}
