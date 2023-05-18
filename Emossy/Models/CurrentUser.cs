using System.Text.Json.Serialization;

namespace Emossy.Models
{
    public class CurrentUser
    {
        [JsonIgnore]
        public Guid UserId { get; set; }
    }
}
