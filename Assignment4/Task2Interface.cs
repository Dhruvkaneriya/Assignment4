using System;

// Make sure to uncomment the ToString methods when you are ready!

namespace Assignment4.Task2Interface
{
	interface ICarryPassengers
	{
		// Here I am making CarryPassengers() method to use in different class.
		public string CarryPassengers();
	}
	class Ship
	{
		public double Displacement { get; }

		// Ship Constructor.
		public Ship(double displacement)
		{
			Displacement = displacement;
		}

		public override string ToString() => $"A ship that displaces {Displacement} tons of water"; 
	}

	class CruiseShip : Ship, ICarryPassengers
	{
		private int numPassengers;
		
		// CruiseShip Constructor inherits from Ship class.
		public CruiseShip(double displacement, int numPassengers) : base(displacement)
		{
			this.numPassengers = numPassengers;
		}

        public string CarryPassengers()
        {
			return $"{base.ToString()} and is carrying {numPassengers} passengers on a Caribbean Cruise";

			//throw new NotImplementedException();
        }

		public override string ToString() => CarryPassengers();
	}

	class BigRig
	{
		public int NumTires;

		// BigRig Constructor.
		public BigRig(int numTires)
		{
			NumTires = numTires;
		}

		public override string ToString() => $"A vehicle with {NumTires} tires"; 
	}

	class TourBus : BigRig, ICarryPassengers
	{
		private int numPassengers;

		// TourBus Constructor inherits from BigRig class.
		public TourBus(int numTires, int numPassengers) : base(numTires)
		{
			this.numPassengers = numPassengers;
		}

        public string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {numPassengers} passengers on a cross country tour.";
		}

		public override string ToString() => CarryPassengers();
	}
}
