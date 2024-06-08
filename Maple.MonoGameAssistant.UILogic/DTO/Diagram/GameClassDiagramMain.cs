namespace Maple.MonoGameAssistant.UILogic;

public class GameClassDiagramMain : GameClassDiagramDetail
{
    public bool Singleton { set; get; }
    public IReadOnlyList<GameClassDiagramDetail>? Details { get; set; }


    public bool HasTypeField(GameClassDiagramMain typeObj)
    {

        if (Details is null || Details.Count == 0)
        {
            return false;
        }
        return Details.Any(p => p.TypeCode == typeObj.Code);
    }



}



