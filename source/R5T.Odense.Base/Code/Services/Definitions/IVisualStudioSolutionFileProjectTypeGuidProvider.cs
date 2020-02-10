using System;


namespace R5T.Odense
{
    public interface IVisualStudioSolutionFileProjectTypeGuidProvider
    {
        Guid GetCSharpNetStandardLibraryProjectTypeGuid();
        Guid GetOldCSharpNetStandardLibraryProjectTypeGuid();
    }
}
