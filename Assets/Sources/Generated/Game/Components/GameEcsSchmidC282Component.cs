//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C282Component ecsSchmidC282 { get { return (EcsSchmid.C282Component)GetComponent(GameComponentsLookup.EcsSchmidC282); } }
    public bool hasEcsSchmidC282 { get { return HasComponent(GameComponentsLookup.EcsSchmidC282); } }

    public void AddEcsSchmidC282(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC282;
        var component = CreateComponent<EcsSchmid.C282Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC282(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC282;
        var component = CreateComponent<EcsSchmid.C282Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC282() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC282);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC282;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC282 {
        get {
            if (_matcherEcsSchmidC282 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC282);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC282 = matcher;
            }

            return _matcherEcsSchmidC282;
        }
    }
}
