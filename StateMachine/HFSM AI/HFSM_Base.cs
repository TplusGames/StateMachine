using UnityEngine;

namespace TPlus.StateMachine
{
    public abstract class HFSM_Base : MonoBehaviour
    {
        protected StateMachine_Base _currentStateMachine;

        protected virtual void Update()
        {
            _currentStateMachine?.StateUpdate();
        }

        public void ChangeStateMachine(StateMachine_Base stateMachine)
        {
            _currentStateMachine?.OnStateExit();
            _currentStateMachine = stateMachine;
            _currentStateMachine?.OnStateEnter();
        }
    }
}

