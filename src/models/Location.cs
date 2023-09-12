using System.Text.Json.Serialization;

public class Location{
    [JsonPropertyName("start")]
    public int Start { get; set; }
    [JsonPropertyName("end")]
    public int End { get; set; }

    [JsonPropertyName("fileName")]
    public string FileName { get; set; }
}