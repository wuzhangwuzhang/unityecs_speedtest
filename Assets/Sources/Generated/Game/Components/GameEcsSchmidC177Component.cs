//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C177Component ecsSchmidC177 { get { return (EcsSchmid.C177Component)GetComponent(GameComponentsLookup.EcsSchmidC177); } }
    public bool hasEcsSchmidC177 { get { return HasComponent(GameComponentsLookup.EcsSchmidC177); } }

    public void AddEcsSchmidC177(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC177;
        var component = CreateComponent<EcsSchmid.C177Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC177(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC177;
        var component = CreateComponent<EcsSchmid.C177Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC177() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC177);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC177;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC177 {
        get {
            if (_matcherEcsSchmidC177 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC177);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC177 = matcher;
            }

            return _matcherEcsSchmidC177;
        }
    }
}
