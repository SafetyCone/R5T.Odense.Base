using System;using R5T.T0064;


namespace R5T.Odense
{[ServiceDefinitionMarker]
    public interface IVisualStudioSolutionFileProjectTypeGuidProvider:IServiceDefinition
    {
        Guid GetCSharpNetStandardLibraryProjectTypeGuid();
        Guid GetOldCSharpNetStandardLibraryProjectTypeGuid();
    }
}
