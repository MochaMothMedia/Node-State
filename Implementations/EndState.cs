using UnityEngine;
using XNode;

namespace FedoraDev.NodeState.Implementations
{
    [CreateNodeMenu("End State")]
    public class EndState : BaseState, IState
    {
        [Input, SerializeField] string _previousNode;
    }
}