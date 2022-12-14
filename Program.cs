using Microsoft.CodeAnalysis.CSharp;

await WriteCompilationUnitSyntaxMembers("endif-at-the-end.cs");
Console.WriteLine("========================================");
await WriteCompilationUnitSyntaxMembers("endif-not-at-the-end.cs");

static async Task WriteCompilationUnitSyntaxMembers(string filepath)
{
    Console.WriteLine($"---> {filepath}:");

    var root = CSharpSyntaxTree.ParseText(await File.ReadAllTextAsync(filepath)).GetCompilationUnitRoot();

    foreach (var member in root.Members)
    {
        Console.Write(member.ToFullString());
    }
}
