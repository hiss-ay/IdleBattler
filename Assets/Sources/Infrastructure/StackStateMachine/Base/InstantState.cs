﻿namespace Game.Sources.Infrastructure.StackStateMachine.Base
{
    public abstract class InstantState : IState
    {
        public abstract void Enter(IStackStateMachine stateMachine);
        public virtual void Exit() { }
    }
}