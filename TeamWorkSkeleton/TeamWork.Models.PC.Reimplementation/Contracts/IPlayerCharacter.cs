namespace TeamWork.Models.PC.Reimplementation.Contracts
{
    using System.Collections.Generic;
    using System.Windows.Media;
    using Global.Contracts;
    using Global.DataStructures;

    public interface IPlayerCharacter
    {
        string Name { get; }

        ITeam Team { get; }

        SolidColorBrush Color { get; set; }

        int CurrentPlayer { get;  }

        void NextPlayer();

        void ResetVisualTokenColor();

        void ResetVisualTokenSize();

        List<IFootballPlayer> GetPlayersOnPositionsList(IEnumerable<PositionXY> positionsList);
    }
}