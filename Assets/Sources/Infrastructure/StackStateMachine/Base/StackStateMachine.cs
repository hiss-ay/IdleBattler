using System.Collections.Generic;

namespace Game.Sources.Infrastructure.StackStateMachine.Base
{
    public class StackStateMachine : IStackStateMachine
    {
        private bool _isStarted;
        private readonly Stack<IState> _stackStates;

        private IState CurrentState => _stackStates.Count == 0 || !_isStarted ? null : _stackStates.Peek();
        
        private StackStateMachine()
        {
            _stackStates = new Stack<IState>();
        }
        
        public static StackStateMachine CreateAndRun(params IState[] states)
        {
            var sequence = new StackStateMachine();
            sequence.PushStates(states);
            sequence.Start();
            return sequence;
        }
        
        public void ReplaceStates(params IState[] states)
        {
            _stackStates.Pop();
            PushStates(states);
        }

        public void StateCompleted(IState state)
        {
            if (!StateCheck(state))
            {
                return;
            }

            _stackStates.Pop();
            if (_stackStates.Count == 0)
            {
                Complete();
                return;
            }

            if (_isStarted)
                _stackStates.Peek().Enter(this);
        }
        
        private void Start()
        {
            if (_isStarted)
                return;

            if (_stackStates.Count == 0)
            {
                Complete();
                return;
            }

            _isStarted = true;
            _stackStates.Peek().Enter(this);
            
            //UpdateAsync();
        }
        
        private void PushStates(params IState[] steps)
        {
            for (int i = steps.Length - 1; i >= 0; i--)
            {
                _stackStates.Push(steps[i]);
            }

            if (_isStarted)
                _stackStates.Peek().Enter(this);
        }

        // private async void UpdateAsync()
        // {
        //     while (true)
        //     {
        //         await Task.Yield();
        //         CurrentState?.Update();
        //     }
        // }
    
        private bool StateCheck(IState state)
        {
            return state == CurrentState;
        }
        
        private void Complete()
        {
            _stackStates.Clear();
        }
    }
}