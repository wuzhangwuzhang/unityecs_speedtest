//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C291Component ecsSchmidC291 { get { return (EcsSchmid.C291Component)GetComponent(GameComponentsLookup.EcsSchmidC291); } }
    public bool hasEcsSchmidC291 { get { return HasComponent(GameComponentsLookup.EcsSchmidC291); } }

    public void AddEcsSchmidC291(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC291;
        var component = CreateComponent<EcsSchmid.C291Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC291(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC291;
        var component = CreateComponent<EcsSchmid.C291Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC291() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC291);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC291;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC291 {
        get {
            if (_matcherEcsSchmidC291 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC291);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC291 = matcher;
            }

            return _matcherEcsSchmidC291;
        }
    }
}
