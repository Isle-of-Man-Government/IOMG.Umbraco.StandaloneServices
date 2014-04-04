using System;

namespace UmbracoServicesStandalone
{
    public class MissingConfigurationException : ApplicationException
    {
        public MissingConfigurationException(string KeyIn)
        {
            Key = KeyIn;
        }

        public string Key { get; private set; }

        public override string Message
        {
            get { return String.Format("Required configuration entry '{0}' not found", Key); }
        }
    }
}
