﻿using System;
namespace BazingaMotors.Models
{
    public interface IEngine
    {
        int Size
        {
            get;
        }

        bool Turbo
        {
            get;
        }

    }
}
