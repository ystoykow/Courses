﻿namespace Cars
{
    interface ICar
    {
        string Model { get; }

        string Color { get; }

        string Start();

        string Stop();
    }
}
