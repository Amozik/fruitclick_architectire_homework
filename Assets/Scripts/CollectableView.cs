using UnityEngine;

namespace DefaultNamespace
{
    public abstract class CollectableView : MonoBehaviour
    {
        public abstract void Collect(int points);
    }
}