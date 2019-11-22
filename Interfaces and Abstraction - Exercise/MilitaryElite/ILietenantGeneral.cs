namespace MilitaryElite
{
    using System.Collections.Generic;

    public interface ILietenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }
    }
}
