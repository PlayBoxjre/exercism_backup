using System;
using System.Collections.Generic;
using System.Linq;

public enum StopwatchState
{
    Ready,
    Running,
    Stopped
}

public class SplitSecondStopwatch(TimeProvider time)
{
    private readonly List<TimeSpan> _previousLaps = new();
    private StopwatchState _state = StopwatchState.Ready;
    private TimeSpan _accumulated = TimeSpan.Zero;
    private DateTimeOffset? _startedAt;

    public StopwatchState State => _state;

    public TimeSpan CurrentLap
    {
        get
        {
            var running = _state == StopwatchState.Running
                ? time.GetUtcNow() - _startedAt!.Value
                : TimeSpan.Zero;
            return _accumulated + running;
        }
    }

    public IReadOnlyList<TimeSpan> PreviousLaps => _previousLaps.AsReadOnly();

      public TimeSpan Total => TimeSpan.FromMilliseconds(_previousLaps.Sum(t => t.TotalMilliseconds) ) + CurrentLap;


    public void Start()
    {
        if (_state == StopwatchState.Running)
            throw new InvalidOperationException("Cannot start a running stopwatch");

        _startedAt = time.GetUtcNow();
        _state = StopwatchState.Running;
    }

    public void Stop()
    {
        if (_state != StopwatchState.Running)
            throw new InvalidOperationException("Cannot stop a stopwatch that is not running");

        _accumulated += time.GetUtcNow() - _startedAt!.Value;
        _startedAt = null;
        _state = StopwatchState.Stopped;
    }

    public void Lap()
    {
        if (_state != StopwatchState.Running)
            throw new InvalidOperationException("Cannot lap a stopwatch that is not running");

        var now = time.GetUtcNow();
        _previousLaps.Add(_accumulated + (now - _startedAt!.Value));
        _accumulated = TimeSpan.Zero;
        _startedAt = now;
    }

    public void Reset()
    {
        if (_state != StopwatchState.Stopped)
            throw new InvalidOperationException("Cannot reset a stopwatch that is not stopped");

        _previousLaps.Clear();
        _accumulated = TimeSpan.Zero;
        _startedAt = null;
        _state = StopwatchState.Ready;
    }
}