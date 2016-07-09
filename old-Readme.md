Project Description

SoccerRPG is a turn-based, stat-based football game. Players on each team take turns controlling one of their football players each turn. Possible player actions - movement, pass, call for pass, shoot, tackle, depending on the current ball posseission.

Each team is manufactured out of a factory. We store options in enums, then generate random values within that range. First we pick a formation for the football team, based on that we generate the appropriate number of players for each position.

We store limitations for each position in a separate static class. The factory wraps those base stats in a GenericFootballPlayer objects, then picks a random species out of the enum SpeciesType and passes the generated stats to the appropriate constructing method.

We use IDrawOnCanvas to draw. Each FootballPlayer objects implements it, our Graphics class draws IDrawOnCanvas objects on its encapsulated Canvas. The interface requires each object implementing it have a visual token ( an Ellipse in this case ), have methods to manipulate it's size and color and store it's position.

We have an ElementManager class which manages IUIElementGroups, each group has methods for subscribing and unsubscring from events. We use these to display and hide appropriate control Button-s.

We also use MouseDown events on each appropriate Canvas.Children object to select a target for passing, indetifying the sender object to a FootballPlayer object through it's Canvas.Children index.

Our structs store positions on the canvas and on our PlayingField, also we have a struct MinMaxRange, which is used for storing the constaints for generating FootballPlayer objects.
