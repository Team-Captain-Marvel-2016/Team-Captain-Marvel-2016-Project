namespace UI.Element.Manager.UIManager
{
    using System;
    using System.Windows;

    public partial class ButtonGroup
    {
        public void SubscribeEnable(ref EventHandler ev)
        {
            ev += this.OnEventEnable;
        }

        public void SubscribeDisable(ref EventHandler ev)
        {
            ev += this.OnEventDisable;
        }

        public void SubscribeDisplay(ref EventHandler ev)
        {
            ev += this.OnEventDisplay;
        }

        public void SubscribeHide(ref EventHandler ev)
        {
            ev += this.OnEventHide;
        }

        public void UnsubscribeEnable(ref EventHandler ev)
        {
            ev -= this.OnEventEnable;
        }

        public void UnsubscribeDisable(ref EventHandler ev)
        {
            ev -= this.OnEventDisable;
        }

        public void UnsubscribeDisplay(ref EventHandler ev)
        {
            ev -= this.OnEventDisplay;
        }

        public void UnsubscribeHide(ref EventHandler ev)
        {
            ev -= this.OnEventHide;
        }

        private void OnEventEnable(object sender, EventArgs args)
        {
            this.Enable();
        }

        private void OnEventDisable(object sender, EventArgs args)
        {
            this.Disable();
        }

        private void OnEventDisplay(object sender, EventArgs args)
        {
            this.Display();
        }

        private void OnEventHide(object sender, EventArgs args)
        {
            this.Hide();
        }

        private void OnEventToggleVisibily(object sender, EventArgs args)
        {
            if (this.buttons[0].Visibility == Visibility.Visible)
            {
                foreach (var button in this.buttons)
                {
                    button.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                foreach (var button in this.buttons)
                {
                    button.Visibility = Visibility.Visible;
                }
            }
        }

        private void OnEventToggleEnabled(object sender, EventArgs args)
        {
            foreach (var button in this.buttons)
            {
                button.IsEnabled = !button.IsEnabled;
            }
        }

        private void SubscribeToEvents(params EventHandler[] events)
        {
            for (int i = 0; i < events.Length; i++)
            {
                events[i] += this.OnEventToggleEnabled;
            }
        }
    }
}