namespace Content.Server._Omu.Shipyard;

[RegisterComponent]
public sealed partial class DockyardBeaconComponent : Component
{
    /// <summary>
    /// How far it looks for another beacon.
    /// </summary>
    [DataField]
    public float MaxLength = 6F;
}
