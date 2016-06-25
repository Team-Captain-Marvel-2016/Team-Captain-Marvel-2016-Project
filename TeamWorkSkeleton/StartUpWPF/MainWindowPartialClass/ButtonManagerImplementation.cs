namespace StartUpWPF
{
    using Game.Tracker;
    using System;
    using UI.Element.Manager.UIManager;

    public partial class MainWindow
    {
        private ElementManager Buttons { get; set; }

        private event EventHandler DisplayUIWithBall;
        private event EventHandler DisplayUIWithoutBall;
        private event EventHandler DisplayUIDefense;
        private event EventHandler DisplayUINoActions;
        private event EventHandler DisplayUIZeroAP;

        /// <summary>
        /// Display sets of buttons depending on Game State
        /// 1. Display All
        /// 2. Enable All
        /// 3. Display Action Buttons
        /// </summary>
        private void DisplayUI()
        {
            this.Buttons.Display();
            this.Buttons.Enable();

            this.DisplayActionButtons();
        }

        /// <summary>
        /// Display Action buttons depending on Game State
        /// 1. With Ball - > Display Pass and Shoot
        /// 2. Without Ball > Display Call For Pass
        /// 3. Ball in enemy team and Enemy player with ball - > display Tackle
        /// 4. Ball in enemy team and no enem with ball -> display none
        /// </summary>
        private void DisplayActionButtons()
        {
            if (GameStateTracker.SelectedFootballPlayer.HasBall)
            {
                this.DisplayUIWithBall?.Invoke(this, null);
            }
            else if (GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.HasBallPossession)
            {
                this.DisplayUIWithoutBall?.Invoke(this, null);
            }
            else
            {
                var startRow = GameStateTracker.SelectedFootballPlayer.GridPosition.X - 1;
                var startCol = GameStateTracker.SelectedFootballPlayer.GridPosition.Y - 1;

                // Check for enemy player in range
                if (this.GetEnemeiesForTackle(startRow, startCol))
                {
                    this.DisplayUIDefense?.Invoke(this, null);
                }
                else
                {
                    this.DisplayUINoActions?.Invoke(this, null);
                }
            }
        }

        /// <summary>
        /// Initialize the ButtonManager object
        /// 1. Add all buttons to manage in groups
        /// 2. Add button actions to appropriate events to trigger
        /// </summary>
        private void InitializeButtonManager()
        {
            this.Buttons = new ElementManager();

            this.Buttons.Add(new ButtonGroup("Movement"));
            this.Buttons["Movement"].Add(this.MoveUpBtn);
            this.Buttons["Movement"].Add(this.MoveDownBtn);
            this.Buttons["Movement"].Add(this.MoveLeftBtn);
            this.Buttons["Movement"].Add(this.MoveRightBtn);

            this.Buttons.Add(new ButtonGroup("Ball"));
            this.Buttons["Ball"].Add(this.PassBtn);
            this.Buttons["Ball"].Add(this.ShootBtn);

            this.Buttons.Add(new ButtonGroup("NoBall"));
            this.Buttons["NoBall"].Add(this.CallForPassBtn);

            this.Buttons.Add(new ButtonGroup("Defense"));
            this.Buttons["Defense"].Add(this.TackleBtn);

            this.Buttons.Add(new ButtonGroup("EndTurn"));
            this.Buttons["EndTurn"].Add(this.EndTurnBtn);
            this.Buttons["EndTurn"].Add(this.ResetBtn);

            this.InitializeDisplayUIWithBall();
            this.InitializeDisplayUIWithoutBall();
            this.InitializeDisplayUIDefense();
            this.InitializeDisplayUIZeroAP();
            this.InitializeDisplayUINoActions();
        }

        private void InitializeDisplayUIWithBall()
        {
            this.Buttons["Defense"]
                .SubscribeHide(ref this.DisplayUIWithBall);
            this.Buttons["NoBall"]
                .SubscribeHide(ref this.DisplayUIWithBall);
        }

        private void InitializeDisplayUIWithoutBall()
        {
            this.Buttons["Defense"]
                .SubscribeHide(ref this.DisplayUIWithoutBall);
            this.Buttons["Ball"]
                .SubscribeHide(ref this.DisplayUIWithoutBall);
        }

        private void InitializeDisplayUIDefense()
        {
            this.Buttons["NoBall"]
                .SubscribeHide(ref this.DisplayUIDefense);
            this.Buttons["Ball"]
                .SubscribeHide(ref this.DisplayUIDefense);
        }

        private void InitializeDisplayUIZeroAP()
        {
            this.Buttons["Defense"]
                .SubscribeHide(ref this.DisplayUIZeroAP);
            this.Buttons["Ball"]
                .SubscribeHide(ref this.DisplayUIZeroAP);
            this.Buttons["NoBall"]
                .SubscribeHide(ref this.DisplayUIZeroAP);
            this.Buttons["Movement"]
                .SubscribeHide(ref this.DisplayUIZeroAP);
        }

        private void InitializeDisplayUINoActions()
        {
            this.Buttons["Defense"]
                .SubscribeHide(ref this.DisplayUINoActions);
            this.Buttons["Ball"]
                .SubscribeHide(ref this.DisplayUINoActions);
            this.Buttons["NoBall"]
                .SubscribeHide(ref this.DisplayUINoActions);
        }
    }
}
