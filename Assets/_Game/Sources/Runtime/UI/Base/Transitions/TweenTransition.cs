using DG.Tweening;

namespace Runtime._Game.Sources.Runtime.UI.Base.Transitions
{
    public abstract class TweenTransition<T> : ITransition<T>
    {
        private Tween _tween;

        public void Restart(T component)
        {
            var settings = GetSettings();
            settings.OnPlay(component);
            
            _tween?.Kill();
            _tween = settings.CreateNewTween(component);
            _tween.Restart();
        }

        public void Pause()
        {
            if (_tween?.IsPlaying() ?? false)
            {
                _tween.Pause();
            }
        }
        
        protected abstract TweenTransitionSettings<T> GetSettings();
    }
}