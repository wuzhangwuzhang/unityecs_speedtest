//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C66Component ecsSchmidC66 { get { return (EcsSchmid.C66Component)GetComponent(GameComponentsLookup.EcsSchmidC66); } }
    public bool hasEcsSchmidC66 { get { return HasComponent(GameComponentsLookup.EcsSchmidC66); } }

    public void AddEcsSchmidC66(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC66;
        var component = CreateComponent<EcsSchmid.C66Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC66(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC66;
        var component = CreateComponent<EcsSchmid.C66Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC66() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC66);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC66;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC66 {
        get {
            if (_matcherEcsSchmidC66 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC66);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC66 = matcher;
            }

            return _matcherEcsSchmidC66;
        }
    }
}
