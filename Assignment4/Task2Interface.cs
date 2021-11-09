using System;

// Make sure to uncomment the ToString methods when you are ready!

namespace Assignment4.Task2Interface
{
	interface ICarryPassengers
	{
		// TODO: IMPLEMENT THIS
	}
	class Ship
	{
		// TODO: IMPLEMENT THIS CLASS

		//public override string ToString() => $"A ship that displaces {Displacement} tons of water"; 
	}

	class CruiseShip : ICarryPassengers
	{
		// TODO: IMPLEMENT THIS CLASS (it should inherit from Ship as well as extend ICarryPassenger)

		public CruiseShip(double displacement, int numPassengers) { }

		//public override string ToString() => CarryPassengers();
	}

	class BigRig
	{
		// TODO: IMPLEMENT THIS CLASS

		//public override string ToString() => $"A vehicle with {NumTires} tires"; 
	}

	class TourBus : ICarryPassengers
	{
		// TODO: IMPLEMENT THIS CLASS (it should inherit from BigRig as well as extend ICarryPassenger)

		public TourBus(int numTires, int numPassengers) { }

		//public override string ToString() => CarryPassengers();
	}
}
