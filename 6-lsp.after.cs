public class Project
{
  public Collection<ProjectFile> AllFiles { get; set; }
  public Collection<WriteableFile> WriteableFiles { get; set; }

  public void LoadAllFiles()
  {
    foreach (ProjectFile file in AllFiles)
    {
      file.LoadFileData();
    }
  }

  public void SaveAllWriteableFiles()
  {
    foreach (WriteableFile file in WriteableFiles)
    {
      file.SaveFileData();
    }
  }
}


public class ProjectFile
{
  public string FilePath { get; set; }

  public byte[] FileData { get; set; }

  public void LoadFileData()
  {
    // Retrieve FileData from disk
  }
}


public class WriteableFile : ProjectFile
{
  public void SaveFileData()
  {
    // Write FileData to disk
  }
}