namespace Runtime._Game.Sources.Runtime.UI.Base.Transitions
{
    public interface ITransition<T>
    {
        public void Restart(T component);
        public void Pause();
    }
}