namespace StartUpWPF
{
    using System;
    using Game.Tracker;
    using UI.Element.Manager.UIManager;

    public partial class MainWindow
    {
        private ElementManager Buttons { get; set; }

        private event EventHandler DisplayUIWithBall;
        private event EventHandler DisplayUIWithoutBall;
        private event EventHandler DisplayUIDefense;
        private event EventHandler DisplayUINoActions;
        private event EventHandler DisplayUIZeroAP;

        private void DisplayUI()
        {
            this.Buttons.Display();
            this.Buttons.Enable();

            this.DisplayActionButtons();
        }

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
                .SubscribeDisable(ref this.DisplayUIWithBall);
            this.Buttons["NoBall"]
                .SubscribeDisable(ref this.DisplayUIWithBall);
        }

        private void InitializeDisplayUIWithoutBall()
        {
            this.Buttons["Defense"]
                .SubscribeDisable(ref this.DisplayUIWithoutBall);
            this.Buttons["Ball"]
                .SubscribeDisable(ref this.DisplayUIWithoutBall);
        }

        private void InitializeDisplayUIDefense()
        {
            this.Buttons["NoBall"]
                .SubscribeDisable(ref this.DisplayUIDefense);
            this.Buttons["Ball"]
                .SubscribeDisable(ref this.DisplayUIDefense);
        }

        private void InitializeDisplayUIZeroAP()
        {
            this.Buttons["Defense"]
                .SubscribeDisable(ref this.DisplayUIZeroAP);
            this.Buttons["Ball"]
                .SubscribeDisable(ref this.DisplayUIZeroAP);
            this.Buttons["NoBall"]
                .SubscribeDisable(ref this.DisplayUIZeroAP);
            this.Buttons["Movement"]
                .SubscribeDisable(ref this.DisplayUIZeroAP);
        }

        private void InitializeDisplayUINoActions()
        {
            this.Buttons["Defense"]
                .SubscribeDisable(ref this.DisplayUINoActions);
            this.Buttons["Ball"]
                .SubscribeDisable(ref this.DisplayUINoActions);
            this.Buttons["NoBall"]
                .SubscribeDisable(ref this.DisplayUINoActions);
        }
    }
}
