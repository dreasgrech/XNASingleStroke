using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace XNASingleStroke
{
    public class SingleKeyStroke : GameComponent
    {
        public event EventHandler<KeyDownEventArgs> KeyDown = delegate { };

        private int pressedKeys;
        public SingleKeyStroke(Game game) : base(game) { }

        public override void Update(GameTime gameTime)
        {
            var pressed = Keyboard.GetState().GetPressedKeys();
            var keys = 0;
            foreach (var key in pressed)
            {
                var num = 1 << (int)key;
                keys |= num;
                if ((pressedKeys & num) != num)
                {
                    KeyDown(this, new KeyDownEventArgs(key));
                }
            }
            pressedKeys = keys;
            base.Update(gameTime);
        }
    }
}