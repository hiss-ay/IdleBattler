namespace Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base
{
    public interface IStackStateMachine
    {
        public void ReplaceStates(params IState[] states);
        public void StateCompleted(IState state);
    }
}