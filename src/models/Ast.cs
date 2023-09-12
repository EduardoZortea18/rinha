using System.Text.Json.Serialization;

public class Ast
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("expression")]
    public RinhaNode Expression { get; set; }
    [JsonPropertyName("location")]
    public Location Location { get; set; }
}