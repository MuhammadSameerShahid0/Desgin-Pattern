using Composite_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Files file1 = new Files("File1.Txt");
        Files file2 = new Files("File2.Txt");
        Files file3 = new Files("File3.Txt");

        Directorys root = new Directorys("Root");
        Directorys SubDir1 = new Directorys("SubDirectory1");
        Directorys SubDir2 = new Directorys("SubDirectory2");

        root.AddComponent(file1);
        root.AddComponent(SubDir1);
        root.AddComponent(file2);
        root.AddComponent(SubDir2);
        root.AddComponent(file3);

        root.Display(" ");
    }
}