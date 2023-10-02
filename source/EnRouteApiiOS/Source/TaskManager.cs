using Glympse.Toolbox;

namespace Glympse.EnRoute.iOS;

internal class TaskManager : GTaskManager, CommonSource.GGlySource
{
    GlyTaskManager _raw;

    CommonSource _source;

    public TaskManager(GlyTaskManager raw)
    {
        _raw = raw;        
        _source = new CommonSource(this);
    }

    /**
     * GTaskManager section
     */       

    public GArray<GTask> getTasks() =>
        new Array<GTask>(_raw.getTasks());

    public GArray<GTask> getPendingTasks() =>
        new Array<GTask>(_raw.getPendingTasks());

    public GArray<GOperation> getActiveOperations() =>
        new Array<GOperation>(_raw.getActiveOperations());

    public GTask findTaskById(long id) =>
        (GTask)ClassBinder.bind(_raw.findTaskById(id));

    public bool startTask(GTask task) =>
        _raw.startTask((GlyTask)task.raw());

    public bool setTaskPhase(GTask task, string phase) =>
        _raw.setTaskPhase((GlyTask)task.raw(), phase);

    public bool completeOperation(GOperation operation) =>
        _raw.completeOperation((GlyOperation)operation.raw());

    public bool completeOperation(GOperation operation, int reasonCode) =>
        _raw.completeOperation((GlyOperation)operation.raw(), reasonCode);

    public void setTravelModeForTask(GTask task, string travelMode)
    {
        _raw.setTravelModeForTask((GlyTask)task.raw(), travelMode);
    }

    public string getTravelModeForTask(GTask task) =>
        _raw.getTravelModeForTask((GlyTask)task.raw());

    public bool sendMessage(GTask task, string message) =>
        _raw.sendMessage((GlyTask)task.raw(), message);

    /**
     * GSource section
     */

    public bool addListener(GListener listener) =>
        _source.addListener(listener);

    public bool removeListener(GListener listener) =>
        _source.removeListener(listener);

    public bool addListener(GlyListener listener) =>
        _raw.addListener(listener);

    public bool removeListener(GlyListener listener) =>
        _raw.removeListener(listener);

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}