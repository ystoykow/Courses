﻿namespace SoftUniParking
{
    using System;

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string make,string model,int horsePower, string registrationNumber)
        {
            Make = make;
            HorsePower = horsePower;
            Model = model;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return $"Make: {Make} " + Environment.NewLine +
                   $"Model: {Model}" + Environment.NewLine +
                   $"HorsePower: {HorsePower} " + Environment.NewLine +
                   $"RegistrationNumber: {RegistrationNumber}";
        }
    }
}