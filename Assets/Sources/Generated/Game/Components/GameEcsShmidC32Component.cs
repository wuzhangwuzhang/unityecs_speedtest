//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C32Component ecsShmidC32 { get { return (EcsShmid.C32Component)GetComponent(GameComponentsLookup.EcsShmidC32); } }
    public bool hasEcsShmidC32 { get { return HasComponent(GameComponentsLookup.EcsShmidC32); } }

    public void AddEcsShmidC32(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC32;
        var component = CreateComponent<EcsShmid.C32Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC32(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC32;
        var component = CreateComponent<EcsShmid.C32Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC32() {
        RemoveComponent(GameComponentsLookup.EcsShmidC32);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC32;

    public static Entitas.IMatcher<GameEntity> EcsShmidC32 {
        get {
            if (_matcherEcsShmidC32 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC32);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC32 = matcher;
            }

            return _matcherEcsShmidC32;
        }
    }
}
