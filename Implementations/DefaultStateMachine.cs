using UnityEngine;
using XNode;

namespace FedoraDev.NodeState.Implementations
{
    [CreateAssetMenu(fileName = "New State Graph", menuName = "State Machine Graph")]
    public class DefaultStateMachine : NodeGraph, IStateMachine
    {
        public IState CurrentState { get; private set; }

        public void GoToState(IState targetState)
		{
            //
		}
    }
}