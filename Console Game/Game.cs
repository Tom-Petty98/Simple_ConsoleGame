﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Game
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string key, out int xChange, out int yChange)
        {
            switch (key)
            {
                case "LeftArrow":
                    xChange = -1;
                    yChange = 0;
                    break;
                case "RightArrow":
                    xChange = 1;
                    yChange = 0;
                    break;
                case "UpArrow":
                    xChange = 0;
                    yChange = -1;
                    break;
                case "DownArrow":
                    xChange = 0;
                    yChange = 1;
                    break;
                default:
                    xChange = 0;
                    yChange = 0;
                    break;
            }
        }

        public new static char UpdateCursor(string key)
        {
            switch (key)
            {
                case "LeftArrow":
                    return '<';
                case "RightArrow":
                    return '>';
                case "UpArrow":
                    return '^';
                case "DownArrow":
                    return 'v';
                default:
                    return '<';
            }
        }

        public new static int KeepInBounds(int dimension, int max)
        {
            if (dimension < 0)
            {
                return 0;
            }
            else if (dimension >= max)
            {
                return max - 1;
            }
            else
            {
                return dimension;
            }
        }

        public new static bool DidScore(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
