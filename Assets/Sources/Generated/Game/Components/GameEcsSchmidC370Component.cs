//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C370Component ecsSchmidC370 { get { return (EcsSchmid.C370Component)GetComponent(GameComponentsLookup.EcsSchmidC370); } }
    public bool hasEcsSchmidC370 { get { return HasComponent(GameComponentsLookup.EcsSchmidC370); } }

    public void AddEcsSchmidC370(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC370;
        var component = CreateComponent<EcsSchmid.C370Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC370(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC370;
        var component = CreateComponent<EcsSchmid.C370Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC370() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC370);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC370;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC370 {
        get {
            if (_matcherEcsSchmidC370 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC370);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC370 = matcher;
            }

            return _matcherEcsSchmidC370;
        }
    }
}
