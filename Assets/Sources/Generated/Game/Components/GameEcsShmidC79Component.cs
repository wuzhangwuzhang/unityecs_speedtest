//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C79Component ecsShmidC79 { get { return (EcsShmid.C79Component)GetComponent(GameComponentsLookup.EcsShmidC79); } }
    public bool hasEcsShmidC79 { get { return HasComponent(GameComponentsLookup.EcsShmidC79); } }

    public void AddEcsShmidC79(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC79;
        var component = CreateComponent<EcsShmid.C79Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC79(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC79;
        var component = CreateComponent<EcsShmid.C79Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC79() {
        RemoveComponent(GameComponentsLookup.EcsShmidC79);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC79;

    public static Entitas.IMatcher<GameEntity> EcsShmidC79 {
        get {
            if (_matcherEcsShmidC79 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC79);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC79 = matcher;
            }

            return _matcherEcsShmidC79;
        }
    }
}
