//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C269Component ecsSchmidC269 { get { return (EcsSchmid.C269Component)GetComponent(GameComponentsLookup.EcsSchmidC269); } }
    public bool hasEcsSchmidC269 { get { return HasComponent(GameComponentsLookup.EcsSchmidC269); } }

    public void AddEcsSchmidC269(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC269;
        var component = CreateComponent<EcsSchmid.C269Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC269(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC269;
        var component = CreateComponent<EcsSchmid.C269Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC269() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC269);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC269;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC269 {
        get {
            if (_matcherEcsSchmidC269 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC269);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC269 = matcher;
            }

            return _matcherEcsSchmidC269;
        }
    }
}
