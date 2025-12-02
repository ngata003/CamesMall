using CamesMall.Models;
using CommunityToolkit.Mvvm.Input;

namespace CamesMall.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}