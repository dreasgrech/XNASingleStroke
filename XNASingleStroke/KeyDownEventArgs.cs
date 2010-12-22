using System;
using Microsoft.Xna.Framework.Input;

namespace XNASingleStroke
{
    public class KeyDownEventArgs:EventArgs
    {
        public Keys Key { get; set; }
        public KeyDownEventArgs(Keys key)
        {
            Key = key;
        }
    }
}
