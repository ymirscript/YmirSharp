namespace YmirSharp;

public static class Extensions
{
    public static ProjectNode? GetProjectNode(this string[] args)
    {
        return ProjectNode.Deserialize(args[0]);
    }
}