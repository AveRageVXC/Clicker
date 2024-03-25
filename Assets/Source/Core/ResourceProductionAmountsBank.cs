using System.Collections.Generic;

namespace Core
{
    public static class ResourceProductionAmountsBank
    {
        public static Dictionary<GameResource, ObservableInt> resourceProductionAmounts = new();

        public static ObservableInt GetProductionAmount(GameResource resource)
        {
            return resourceProductionAmounts[resource];
        }

        public static void UpgradeProductionAmount(GameResource resource, ObservableInt value)
        {
            resourceProductionAmounts[resource].Value += value.Value;
        }
        
        public static void AddResourceToDict(GameResource resource, ObservableInt value)
        {
            resourceProductionAmounts.Add(resource, new ObservableInt(value.Value));
        }
    }
}