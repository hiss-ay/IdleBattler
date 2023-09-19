namespace Game.Sources.Infrastructure.StackStateMachine.Base
{
    public interface IStackStateMachine
    {
        public void ReplaceStates(params IState[] states);
        public void StateCompleted(IState state);
    }
}