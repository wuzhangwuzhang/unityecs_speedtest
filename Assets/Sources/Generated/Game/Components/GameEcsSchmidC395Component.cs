//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C395Component ecsSchmidC395 { get { return (EcsSchmid.C395Component)GetComponent(GameComponentsLookup.EcsSchmidC395); } }
    public bool hasEcsSchmidC395 { get { return HasComponent(GameComponentsLookup.EcsSchmidC395); } }

    public void AddEcsSchmidC395(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC395;
        var component = CreateComponent<EcsSchmid.C395Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC395(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC395;
        var component = CreateComponent<EcsSchmid.C395Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC395() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC395);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC395;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC395 {
        get {
            if (_matcherEcsSchmidC395 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC395);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC395 = matcher;
            }

            return _matcherEcsSchmidC395;
        }
    }
}
