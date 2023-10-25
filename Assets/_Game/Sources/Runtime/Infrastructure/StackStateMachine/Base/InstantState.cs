namespace Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base
{
    public abstract class InstantState : IState
    {
        public abstract void Enter(IStackStateMachine stateMachine);
        public virtual void Exit() { }
    }
}