namespace StartUpWPF
{
    using UI.Element.Manager.UIManager;

    public partial class MainWindow
    {
        private void InitializeButtonManager()
        {
            this.buttons = new ElementManager();

            this.buttons.Add(new ButtonGroup("Movement"));
            this.buttons["Movement"].Add(this.MoveUpBtn);
            this.buttons["Movement"].Add(this.MoveDownBtn);
            this.buttons["Movement"].Add(this.MoveLeftBtn);
            this.buttons["Movement"].Add(this.MoveRightBtn);
            
            this.buttons.Add(new ButtonGroup("Ball"));
            this.buttons["Ball"].Add(this.PassBtn);
            this.buttons["Ball"].Add(this.ShootBtn);

            this.buttons.Add(new ButtonGroup("NoBall"));
            this.buttons["NoBall"].Add(this.CallForPassBtn);

            this.buttons.Add(new ButtonGroup("Defense"));
            this.buttons["Defense"].Add(this.TackleBtn);

            this.buttons.Add(new ButtonGroup("EndTurn"));
            this.buttons["EndTurn"].Add(this.EndTurnBtn);
            this.buttons["EndTurn"].Add(this.ResetBtn);
        }
    }
}
