//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C365Component ecsSchmidC365 { get { return (EcsSchmid.C365Component)GetComponent(GameComponentsLookup.EcsSchmidC365); } }
    public bool hasEcsSchmidC365 { get { return HasComponent(GameComponentsLookup.EcsSchmidC365); } }

    public void AddEcsSchmidC365(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC365;
        var component = CreateComponent<EcsSchmid.C365Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC365(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC365;
        var component = CreateComponent<EcsSchmid.C365Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC365() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC365);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC365;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC365 {
        get {
            if (_matcherEcsSchmidC365 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC365);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC365 = matcher;
            }

            return _matcherEcsSchmidC365;
        }
    }
}