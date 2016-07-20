﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace EngineTest.Recources
{
    public class PointLight
    {
        public Vector3 Position;
        public float Radius;
        public Color Color;
        public float Intensity;

        public PointLight(Vector3 position, float radius, Color color, float intensity)
        {
            Position = position;
            Radius = radius;
            Color = color;
            Intensity = intensity;
        }
    }
}
