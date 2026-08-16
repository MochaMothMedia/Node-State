using UnityEngine;
using XNode;

namespace MochaMoth.NodeState.Implementations
{
    [CreateNodeMenu("Start State")]
    public class StartState : BaseState, IState
    {
        [Output, SerializeField] string _nextNode;
    }
}