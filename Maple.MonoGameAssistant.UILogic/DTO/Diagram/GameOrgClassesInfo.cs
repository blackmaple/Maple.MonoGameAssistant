using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameOrgClassesInfo
{
    public HashSet<GameClassInfo> UseFieldClasses { get; } = new HashSet<GameClassInfo>(GameOrgClassesEqualityComparer.EqualityComparer);
    public HashSet<GameClassInfo> RefFieldClasses { get; } = new HashSet<GameClassInfo>(GameOrgClassesEqualityComparer.EqualityComparer);
    public HashSet<GameClassInfo> ParentClasses { get; } = new HashSet<GameClassInfo>(GameOrgClassesEqualityComparer.EqualityComparer);
    public HashSet<GameClassInfo> DerivedClasses { get; } = new HashSet<GameClassInfo>(GameOrgClassesEqualityComparer.EqualityComparer);
    public HashSet<GameClassInfo> UseMethodClasses { get; } = new HashSet<GameClassInfo>(GameOrgClassesEqualityComparer.EqualityComparer);
    public HashSet<GameClassInfo> RefMethodClasses { get; } = new HashSet<GameClassInfo>(GameOrgClassesEqualityComparer.EqualityComparer);


    public static bool LikeClassInfo(MonoClassInfoDTO x, MonoClassInfoDTO y)
    {
        return x.TypeName.AsSpan().IndexOf(y.TypeName.AsSpan()) != -1;
    }

    public static bool ExistUseField(GameClassInfo meClass, GameClassInfo useClass)
    {
        if (meClass.RawClassInfo.TypeName == useClass.RawClassInfo.TypeName)
        {
            return false;
        }
        if (meClass.FieldInfos?.Length > 0)
        {
            return meClass.FieldInfos
                    //.Where(f => f.RawFieldInfo.FieldType.TypeName != meClass.RawClassInfo.TypeName)
                    .Where(f => LikeClassInfo(f.RawFieldInfo.FieldType, useClass.RawClassInfo))
                    .Any();
        }
        return false;
    }
    public static bool ExistRefField(GameClassInfo meClass, GameClassInfo refClass)
    {

        return ExistUseField(refClass, meClass);
    }

    public static bool ExistParent(GameClassInfo meClass, GameClassInfo parentClass)
    {
        if (meClass.RawClassInfo.TypeName == parentClass.RawClassInfo.TypeName)
        {
            return false;
        }
        if (meClass.ParentClassInfos?.Length > 0)
        {
            return meClass.ParentClassInfos.Any(p => LikeClassInfo(p.RawClassInfo, parentClass.RawClassInfo));
        }
        return false;
    }
    public static bool ExistDerived(GameClassInfo meClass, GameClassInfo derivedClass)
    {
        return ExistParent(derivedClass, meClass);
    }


    public static bool ExistUseMethod(GameClassInfo meClass, GameClassInfo useClass)
    {
        if (meClass.RawClassInfo.TypeName == useClass.RawClassInfo.TypeName)
        {
            return false;
        }
        if (meClass.MethodInfos?.Length > 0)
        {
            foreach (var m in meClass.MethodInfos)
            {
                if (LikeClassInfo(m.RawMethodInfo.ReturnType, useClass.RawClassInfo) 
                    || m.RawMethodInfo.ParameterTypes.Any(p => LikeClassInfo(p, useClass.RawClassInfo)) )
                {
                    return true;
                }
               
            }
        }
        return false;
    }
    public static bool ExistRefMethod(GameClassInfo meClass, GameClassInfo refClass)
    {
        return ExistUseMethod(refClass, meClass);
    }

    class GameOrgClassesEqualityComparer : IEqualityComparer<GameClassInfo>
    {
        public static GameOrgClassesEqualityComparer EqualityComparer { get; } = new();

        public bool Equals(GameClassInfo? x, GameClassInfo? y)
        {
            if (x is null || y is null)
            {
                return false;
            }
            return x.RawClassInfo.TypeName == y.RawClassInfo.TypeName;
        }

        public int GetHashCode([DisallowNull] GameClassInfo obj)
        {
            return obj.GetHashCode();
        }

    }

}
