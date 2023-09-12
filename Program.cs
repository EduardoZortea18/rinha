
using System.Text.Json;

Console.WriteLine("Welcome to the RINHA \n\n");
    var jsonFile = File.ReadAllText("var/rinha/source.rinha.json");
    Console.WriteLine(jsonFile);
    var tree = JsonSerializer.Deserialize<Ast>(jsonFile, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});

    if (tree == null)
    {
        Console.WriteLine("Something went wrong :/ \n\n");
        return;
    }
    RinhaInterpreter(tree.Expression);
    Console.WriteLine("It seems ok until now");

string RinhaInterpreter(dynamic node){
    var log = node.Kind switch 
    {
        "Print" => PrintFunction(node),
        "Str" => node.Value.ToString(),
        _ => string.Empty,
    };

    if (!string.IsNullOrEmpty(log))
        Console.WriteLine(log);
    
    return log;
}

string PrintFunction(dynamic node){
    return RinhaInterpreter(node);
}