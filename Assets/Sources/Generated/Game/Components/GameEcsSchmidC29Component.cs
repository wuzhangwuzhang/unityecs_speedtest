//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C29Component ecsSchmidC29 { get { return (EcsSchmid.C29Component)GetComponent(GameComponentsLookup.EcsSchmidC29); } }
    public bool hasEcsSchmidC29 { get { return HasComponent(GameComponentsLookup.EcsSchmidC29); } }

    public void AddEcsSchmidC29(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC29;
        var component = CreateComponent<EcsSchmid.C29Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC29(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC29;
        var component = CreateComponent<EcsSchmid.C29Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC29() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC29);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC29;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC29 {
        get {
            if (_matcherEcsSchmidC29 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC29);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC29 = matcher;
            }

            return _matcherEcsSchmidC29;
        }
    }
}
