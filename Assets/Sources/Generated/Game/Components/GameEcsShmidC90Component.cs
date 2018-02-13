//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C90Component ecsShmidC90 { get { return (EcsShmid.C90Component)GetComponent(GameComponentsLookup.EcsShmidC90); } }
    public bool hasEcsShmidC90 { get { return HasComponent(GameComponentsLookup.EcsShmidC90); } }

    public void AddEcsShmidC90(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC90;
        var component = CreateComponent<EcsShmid.C90Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC90(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC90;
        var component = CreateComponent<EcsShmid.C90Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC90() {
        RemoveComponent(GameComponentsLookup.EcsShmidC90);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC90;

    public static Entitas.IMatcher<GameEntity> EcsShmidC90 {
        get {
            if (_matcherEcsShmidC90 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC90);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC90 = matcher;
            }

            return _matcherEcsShmidC90;
        }
    }
}