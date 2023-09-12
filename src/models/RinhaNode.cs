using System.Text.Json.Serialization;

public class RinhaNode {
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
    [JsonPropertyName("value")]
    public object Value { get; set; }
    [JsonPropertyName("location")]
    public Location Location { get; set; }
}