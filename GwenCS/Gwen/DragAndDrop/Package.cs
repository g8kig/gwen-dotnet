﻿using System;
using System.Drawing;
using Gwen.Controls;

namespace Gwen.DragDrop
{
    public class Package
    {
        public String Name;
        public object UserData;
        public bool IsDraggable;
        public Base DrawControl;
        public Point HoldOffset;
    }
}