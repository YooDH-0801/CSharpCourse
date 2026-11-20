namespace Task_TextRPG.Core.Scene
{
    internal abstract class Scene
    {
        public abstract void OnEnter();
        public abstract void OnExit();
        public abstract void OnRender();
        public abstract void OnUpdate();
    }
}
