//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C483Component ecsSchmidC483 { get { return (EcsSchmid.C483Component)GetComponent(GameComponentsLookup.EcsSchmidC483); } }
    public bool hasEcsSchmidC483 { get { return HasComponent(GameComponentsLookup.EcsSchmidC483); } }

    public void AddEcsSchmidC483(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC483;
        var component = CreateComponent<EcsSchmid.C483Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC483(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC483;
        var component = CreateComponent<EcsSchmid.C483Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC483() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC483);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC483;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC483 {
        get {
            if (_matcherEcsSchmidC483 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC483);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC483 = matcher;
            }

            return _matcherEcsSchmidC483;
        }
    }
}
