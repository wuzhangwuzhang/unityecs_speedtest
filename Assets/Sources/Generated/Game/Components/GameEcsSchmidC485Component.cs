//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C485Component ecsSchmidC485 { get { return (EcsSchmid.C485Component)GetComponent(GameComponentsLookup.EcsSchmidC485); } }
    public bool hasEcsSchmidC485 { get { return HasComponent(GameComponentsLookup.EcsSchmidC485); } }

    public void AddEcsSchmidC485(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC485;
        var component = CreateComponent<EcsSchmid.C485Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC485(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC485;
        var component = CreateComponent<EcsSchmid.C485Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC485() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC485);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC485;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC485 {
        get {
            if (_matcherEcsSchmidC485 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC485);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC485 = matcher;
            }

            return _matcherEcsSchmidC485;
        }
    }
}
