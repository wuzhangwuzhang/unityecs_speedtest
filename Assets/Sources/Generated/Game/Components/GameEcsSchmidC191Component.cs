//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C191Component ecsSchmidC191 { get { return (EcsSchmid.C191Component)GetComponent(GameComponentsLookup.EcsSchmidC191); } }
    public bool hasEcsSchmidC191 { get { return HasComponent(GameComponentsLookup.EcsSchmidC191); } }

    public void AddEcsSchmidC191(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC191;
        var component = CreateComponent<EcsSchmid.C191Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC191(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC191;
        var component = CreateComponent<EcsSchmid.C191Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC191() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC191);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC191;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC191 {
        get {
            if (_matcherEcsSchmidC191 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC191);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC191 = matcher;
            }

            return _matcherEcsSchmidC191;
        }
    }
}
