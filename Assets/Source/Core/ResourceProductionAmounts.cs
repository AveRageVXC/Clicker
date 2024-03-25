using System.Collections.Generic;

namespace Core
{
    public static class ResourceProductionAmounts
    {
        public static Dictionary<GameResource, ObservableInt> ResourceProductionAmount = new();
        static ResourceProductionAmounts()
        {
            ResourceProductionAmount.Add(GameResource.Gold, new ObservableInt(1));
            ResourceProductionAmount.Add(GameResource.Wood, new ObservableInt(1));
            ResourceProductionAmount.Add(GameResource.Stone, new ObservableInt(1));
            ResourceProductionAmount.Add(GameResource.Humans, new ObservableInt(1));
            ResourceProductionAmount.Add(GameResource.Food, new ObservableInt(1));
        }

        public static int GetProductionAmount(GameResource resource)
        {
            return ResourceProductionAmount[resource].Value;
        }

        public static void UpgradeProductionAmount(GameResource resource, int value)
        {
            ResourceProductionAmount[resource].Value += value;
        }
    }
}