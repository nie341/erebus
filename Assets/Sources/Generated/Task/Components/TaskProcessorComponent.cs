//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TaskEntity {

    public ProcessorComponent processor { get { return (ProcessorComponent)GetComponent(TaskComponentsLookup.Processor); } }
    public bool hasProcessor { get { return HasComponent(TaskComponentsLookup.Processor); } }

    public void AddProcessor(TaskProcessor newValue) {
        var index = TaskComponentsLookup.Processor;
        var component = CreateComponent<ProcessorComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProcessor(TaskProcessor newValue) {
        var index = TaskComponentsLookup.Processor;
        var component = CreateComponent<ProcessorComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProcessor() {
        RemoveComponent(TaskComponentsLookup.Processor);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TaskMatcher {

    static Entitas.IMatcher<TaskEntity> _matcherProcessor;

    public static Entitas.IMatcher<TaskEntity> Processor {
        get {
            if (_matcherProcessor == null) {
                var matcher = (Entitas.Matcher<TaskEntity>)Entitas.Matcher<TaskEntity>.AllOf(TaskComponentsLookup.Processor);
                matcher.componentNames = TaskComponentsLookup.componentNames;
                _matcherProcessor = matcher;
            }

            return _matcherProcessor;
        }
    }
}