//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C411Component ecsSchmidC411 { get { return (EcsSchmid.C411Component)GetComponent(GameComponentsLookup.EcsSchmidC411); } }
    public bool hasEcsSchmidC411 { get { return HasComponent(GameComponentsLookup.EcsSchmidC411); } }

    public void AddEcsSchmidC411(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC411;
        var component = CreateComponent<EcsSchmid.C411Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC411(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC411;
        var component = CreateComponent<EcsSchmid.C411Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC411() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC411);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC411;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC411 {
        get {
            if (_matcherEcsSchmidC411 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC411);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC411 = matcher;
            }

            return _matcherEcsSchmidC411;
        }
    }
}
