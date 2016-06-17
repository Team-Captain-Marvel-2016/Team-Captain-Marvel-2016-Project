# How to Apply Species Bonus Stats 
## within the current object creation structure.
-------

## Structure
1. GenericFootballPlayer object ( inheritor of FootballPlayer)
2. Passed to [Species][Position] object constructur, then
3. Passed to [Species] abstract class constructor, then
4. Passed to the base FootballPlayer abstract class constructor. <br>
( base constructor runs first )

## Species bonuses application
Apply bonus stats  on [Species] constructor level. 
Inside the constructor taking a GenericFootballPlayer Argument.
The stat modification is applied after the base constructor has been
 successfully completed.

Example: internal Neptunian(FootballPlayerFactory.GenericFootballPlayer player) 
            : base(player)

        {
          StatPass += 5;
          StatTackle -= 5;
        }
