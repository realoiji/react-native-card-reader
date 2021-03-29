using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Card.Reader.RNCardReader
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCardReaderModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCardReaderModule"/>.
        /// </summary>
        internal RNCardReaderModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCardReader";
            }
        }
    }
}
