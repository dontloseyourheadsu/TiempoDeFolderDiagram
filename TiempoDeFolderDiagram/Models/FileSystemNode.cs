namespace TiempoDeFolderDiagram.Models;

public class FileSystemNode
{
    public required FileSystemNodeType NodeType { get; set; }
    public required int DepthLevel { get; set; }
    public required string Text { get; set; }
    public required string Icon { get; set; }
    public FileSystemNode? Parent { get; set; }
    public List<FileSystemNode> Children { get; } = [];

    public bool AddChildNode(FileSystemNode child)
    {
        if (NodeType is not FileSystemNodeType.Folder)
        {
            return false;
        }
        
        Children.Add(child);
        child.Parent = this;
        return true;
    }
}