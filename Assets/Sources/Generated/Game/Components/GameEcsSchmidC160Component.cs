//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C160Component ecsSchmidC160 { get { return (EcsSchmid.C160Component)GetComponent(GameComponentsLookup.EcsSchmidC160); } }
    public bool hasEcsSchmidC160 { get { return HasComponent(GameComponentsLookup.EcsSchmidC160); } }

    public void AddEcsSchmidC160(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC160;
        var component = CreateComponent<EcsSchmid.C160Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC160(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC160;
        var component = CreateComponent<EcsSchmid.C160Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC160() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC160);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC160;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC160 {
        get {
            if (_matcherEcsSchmidC160 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC160);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC160 = matcher;
            }

            return _matcherEcsSchmidC160;
        }
    }
}
