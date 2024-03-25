using UnityEngine;
using Core;
public class GameManager: MonoBehaviour
{
    private void Awake()
    {
        if (ResourceBank.GetResource(GameResource.Gold) == null)
        {
            ResourceBank.AddResourceToDict(GameResource.Gold, 0);
            ResourceBank.AddResourceToDict(GameResource.Wood, 5);
            ResourceBank.AddResourceToDict(GameResource.Stone, 0);
            ResourceBank.AddResourceToDict(GameResource.Humans, 10);
            ResourceBank.AddResourceToDict(GameResource.Food, 5);
            ResourceProductionAmountsBank.AddResourceToDict(GameResource.Gold, new ObservableInt(1));
            ResourceProductionAmountsBank.AddResourceToDict(GameResource.Wood, new ObservableInt(1));
            ResourceProductionAmountsBank.AddResourceToDict(GameResource.Stone, new ObservableInt(1));
            ResourceProductionAmountsBank.AddResourceToDict(GameResource.Humans, new ObservableInt(1));
            ResourceProductionAmountsBank.AddResourceToDict(GameResource.Food, new ObservableInt(1));
        }
        
    }
}