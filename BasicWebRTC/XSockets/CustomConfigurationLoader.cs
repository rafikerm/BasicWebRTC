using System;
using System.Collections.Generic;
using XSockets.Core.Common.Configuration;
using XSockets.Core.Configuration;
using XSockets.Plugin.Framework.Core.Attributes;

namespace BasicWebRTC.XSockets
{
    /// <summary>
    /// Custom config...
    /// Make changes to this class or remove and create your own for the configuration.
    /// Just make sure to implement IConfigurationLoader and Export the interface
    /// </summary>
    /*[Export(typeof(IConfigurationLoader))]
    public class CustomConfigurationLoader : IConfigurationLoader
    {
        public CustomConfigurationLoader()
        {
        }

        public IConfigurationSettings _settings = null;

        public Uri GetUri(string location)
        {
            try
            {
                return new Uri(location);
            }
            catch (Exception)
            {

                return new Uri(string.Format("ws://{0}", location));
            }

        }

        /// <summary>
        /// Get server settings from config file.
        /// </summary>
        public IConfigurationSettings ConfigurationSettings
        {
            get
            {
                if (this._settings == null)
                {
                    var uri = GetUri("ws://127.0.0.1:4502");

                    this._settings = new ConfigurationSettings
                        {
                            Port = uri.Port,
                            Origin = new List<string>() { "http://*" },
                            Location = uri.Host,
                            Scheme = uri.Scheme,
                            Uri = uri,
                            BufferSize = 8192,
                            RemoveInactiveStorageAfterXDays = 7,
                            RemoveInactiveChannelsAfterXMinutes = 30,
                            NumberOfAllowedConections = -1
                        };
                }
                //else
                //{
                //    this._settings.Port++;
                //}
                return this._settings;
            }
        }
    }*/
}