namespace TiempoDeFolderDiagram.Models;

public class LineItem
{
    public string Text { get; set; }
    public int Indentation { get; set; }
    public string Icon { get; set; }
    public bool IsRoot { get; set; }
    public bool IsFile { get; set; }
    public bool IsComment { get; set; }
}