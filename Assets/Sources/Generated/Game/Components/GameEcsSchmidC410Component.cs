//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C410Component ecsSchmidC410 { get { return (EcsSchmid.C410Component)GetComponent(GameComponentsLookup.EcsSchmidC410); } }
    public bool hasEcsSchmidC410 { get { return HasComponent(GameComponentsLookup.EcsSchmidC410); } }

    public void AddEcsSchmidC410(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC410;
        var component = CreateComponent<EcsSchmid.C410Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC410(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC410;
        var component = CreateComponent<EcsSchmid.C410Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC410() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC410);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC410;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC410 {
        get {
            if (_matcherEcsSchmidC410 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC410);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC410 = matcher;
            }

            return _matcherEcsSchmidC410;
        }
    }
}
