using EventBusSystem;

namespace Example
{
    public interface IQuickSaveLoadHandler : IGlobalSubscriber
    {
        void HandleQuickSave();
        void HandleQuickLoad();
    }
}