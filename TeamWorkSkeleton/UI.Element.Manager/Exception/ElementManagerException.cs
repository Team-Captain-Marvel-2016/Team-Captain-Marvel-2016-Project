namespace UI.Element.Manager.Exception
{
    using System;

    public class ElementManagerException : ApplicationException
    {
        public ElementManagerException(string message, Exception innerException) 
            : base(message)
        {
            
        }

        public override string Message
        {
            get
            {
                return base.Message; 
                
            }
        }
    }
}