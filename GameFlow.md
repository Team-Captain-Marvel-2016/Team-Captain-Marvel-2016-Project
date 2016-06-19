#Game Flow Description

1. ##Initial - InitialState Class
    
  - Start button

2. ##Start game - InitializeGame Class
  - Display football players on the field.
------------------------------

##Start new turn:
1. ##Select player <br> 
  - Display Prev / Next buttons to select a player (?) <br>
  - Alternatively cycle through players automatically. <br> ( like this one better )

3. ##Confirmed Football Player - DissplayButtons Class
  - ###Display buttons <br>
    - Pass/ Shoot -> if player has the ball <br>
    - Call for pass -> if team has the ball <br>
    - Tackle -> if in range of a player with the ball <br>
    - Movement buttons

  - ###Display Player information: DisplayPlayerInfo Class
    - AP
    - Name
    - Visualize the ball 
    - Change color of selected player

4. ##Action -> Call Method(this, target) GameActions Class ( separate for each action )
  - Pass
  - Shoot
  - Call for pass ( same as pass probly)
  - Tackle
  - Move

5. ##End Of Turn Button - Start new turn with next player
  - Go to top with the next player
