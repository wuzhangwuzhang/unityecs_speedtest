//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C438Component ecsSchmidC438 { get { return (EcsSchmid.C438Component)GetComponent(GameComponentsLookup.EcsSchmidC438); } }
    public bool hasEcsSchmidC438 { get { return HasComponent(GameComponentsLookup.EcsSchmidC438); } }

    public void AddEcsSchmidC438(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC438;
        var component = CreateComponent<EcsSchmid.C438Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC438(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC438;
        var component = CreateComponent<EcsSchmid.C438Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC438() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC438);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC438;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC438 {
        get {
            if (_matcherEcsSchmidC438 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC438);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC438 = matcher;
            }

            return _matcherEcsSchmidC438;
        }
    }
}
