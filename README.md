#Team Captain Marvel 2016

| name | TALS | github 
| :------------------ | :-------------------: | :--------------------: |
| Златин Костов | owolp | [owolp](https://github.com/owolp) |
| Иван Китанов | optional303 | [optional303](https://github.com/optional303) |
| Илиян Гогов | Iliangogov | [iliangogov](https://github.com/iliangogov) |
| Михаил Маламов | mmalamov |  |
| Пламен Иванов | pivanov | |
| Спас Стоимиров | sstoimirov | [sstoimirov](https://github.com/sstoimirov) |
| Христо Тодоров | todorovh | [shakuu](https://github.com/shakuu) |

------------------
##[Team Captain Marvel on GitHub](https://github.com/Team-Captain-Marvel-2016)

------------------
##Project Description

SoccerRPG is a turn-based, stat-based football game. Players on each team take turns controlling one of their football players each turn.
Possible player actions - movement, pass, call for pass, shoot, tackle, depending on the current ball posseission.

Each team is manufactured out of a factory, based on a preset ( enum FormationType ) which determines the number of football players on each position.

Each position has a range for generating each statistic set in namespace TeamWork.Models.Factory.Settings. Each static class contains a set of readonly struct RangeMinMax() ranges.

The factory wraps the randomly generated set of stats in a GenericFootballPlayer and randomly picks a species to which constructor to pass those stats. 

The randomizer gets the size of enum SpeciesType, picks a random number in that range, takes the value as string and calls the method containing the string of the enum value refelctively.
As a bonus this made the process of "plugging in" new species quite straight forward.

Each species calls a unique Name generating method ( and should be applying a species unique stat bonuses ).

Each FootballPlayer implements the IDrawOnCanvas interface on the opposite end our Graphics class draws IDrawOnCanvas objects on it's encapsulated Canvas object.

IDrawOnCanvas contains a VisualToken property ( an Ellipse in this case ), the size and color of it. Also the FieldPosition ( position in pixels within the canvas ) and Grid Position on the PlayingField.
GridPosition allows us to track player position on a predetermined grid and implement game logic based on that, field position translates those positions for drawing, with the help of a position grid array, which contains the pixel position corresponding to each grid position and is generated based on the canvas size in pixels, wrapped in struct PositionXY objects. All sizes are kept in a static class as readonly properties ( private setters and a static constructor ).

We use the change of color to communicate ball possession and change of size to communicate the currently controlled football player.

We've implemented an ElementManager class which displays and hides UI elements ( the control buttons ) based on events invoked depending on the game state and player actions.
The ElementManager manages IUIElementGroup objects, which we've implemented through ButtonGroups. Each group has methods to subscribe and unsubscire it's elements to a passed event.

------------------
## Class Diagrams
  - [Football Players](https://github.com/Team-Captain-Marvel-2016/TeamWorkSkeletonSample/blob/master/TeamWorkSkeleton/FootballPlayerAssembly/FootballPlayerDiagram.cd0)

  