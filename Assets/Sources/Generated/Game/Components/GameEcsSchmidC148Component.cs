//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C148Component ecsSchmidC148 { get { return (EcsSchmid.C148Component)GetComponent(GameComponentsLookup.EcsSchmidC148); } }
    public bool hasEcsSchmidC148 { get { return HasComponent(GameComponentsLookup.EcsSchmidC148); } }

    public void AddEcsSchmidC148(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC148;
        var component = CreateComponent<EcsSchmid.C148Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC148(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC148;
        var component = CreateComponent<EcsSchmid.C148Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC148() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC148);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC148;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC148 {
        get {
            if (_matcherEcsSchmidC148 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC148);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC148 = matcher;
            }

            return _matcherEcsSchmidC148;
        }
    }
}
