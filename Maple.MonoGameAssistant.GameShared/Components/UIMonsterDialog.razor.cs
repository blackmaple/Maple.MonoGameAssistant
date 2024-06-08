using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIMonsterDialog
    {
 
        [Parameter, EditorRequired, NotNull]
        public GameMonsterDisplayDTO? MonsterDisplayDTO { get; set; }

 


       

    }
}