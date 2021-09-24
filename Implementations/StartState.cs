using UnityEngine;
using XNode;

namespace FedoraDev.NodeState.Implementations
{
    [CreateNodeMenu("Start State")]
    public class StartState : BaseState, IState
    {
        [Output, SerializeField] string _nextNode;
    }
}