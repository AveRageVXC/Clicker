using System.Collections.Generic;
using Core;

public static class ResourceBank
{
    public static Dictionary<GameResource, ObservableInt> Resources = new();
    
    public static void AddResourceToDict(GameResource resource, int value)
    {
        Resources.Add(resource, new ObservableInt(value));
    }

    static ResourceBank()
    {
        AddResourceToDict(GameResource.Gold, 0);
        AddResourceToDict(GameResource.Wood, 5);
        AddResourceToDict(GameResource.Stone, 0);
        AddResourceToDict(GameResource.Humans, 10);
        AddResourceToDict(GameResource.Food, 5);
    }
    
    public static void ChangeResource(GameResource resource, int value)
    {
        Resources[resource].Value += value;
    }


    public static ObservableInt GetResource(GameResource resource)
    {
        if (!Resources.ContainsKey(resource))
        {
            return null;
        }
        return Resources[resource];
    }
}