﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CTC
{
    public class TopTaskbar : UIView
    {
        public TopTaskbar()
        {
            Bounds = new Rectangle(0, 0, 20, 20);

            UIButton StartButton = new UIButton();
            StartButton.Bounds = new Rectangle(0, 0, 20, 20);
            AddSubview(StartButton);
        }

        public override void Draw(SpriteBatch CurrentBatch)
        {
            DrawChildren(CurrentBatch);
        }
    }
}
