namespace Game.Sources.UI.Base.Transitions
{
    public interface ITransition<T>
    {
        public void Restart(T component);
        public void Pause();
    }
}