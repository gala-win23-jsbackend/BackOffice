using System.Text.Json.Serialization;
using System.Text.Json;

namespace BackOffice.GraphQL;

public class DynamicGraphQLResponse
{
    [JsonPropertyName("data")]
    public JsonElement Data { get; set; }
}
