using System.Collections.Generic;
using Core;

public static class ResourceBank
{
    public static Dictionary<GameResource, ObservableInt> Resources = new();
    
    public static void AddResourceToDict(GameResource resource, int value)
    {
        Resources.Add(resource, new ObservableInt(value));
    }
    
    public static void ChangeResource(GameResource resource, int value)
    {
        Resources[resource].Value += value;
    }


    public static ObservableInt GetResource(GameResource resource)
    {
        return Resources[resource];
    }
}