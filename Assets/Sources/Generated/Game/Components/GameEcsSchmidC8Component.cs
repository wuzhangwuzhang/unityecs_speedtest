//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C8Component ecsSchmidC8 { get { return (EcsSchmid.C8Component)GetComponent(GameComponentsLookup.EcsSchmidC8); } }
    public bool hasEcsSchmidC8 { get { return HasComponent(GameComponentsLookup.EcsSchmidC8); } }

    public void AddEcsSchmidC8(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC8;
        var component = CreateComponent<EcsSchmid.C8Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC8(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC8;
        var component = CreateComponent<EcsSchmid.C8Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC8() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC8);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC8;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC8 {
        get {
            if (_matcherEcsSchmidC8 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC8);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC8 = matcher;
            }

            return _matcherEcsSchmidC8;
        }
    }
}
