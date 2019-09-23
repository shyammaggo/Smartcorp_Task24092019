using System;

namespace WidelyUsedLibrary
{


	public class WidelyUsedLibrary
	{
		public enum Colour
		{
			White,
			Black,
			Red,
			Green
		}
		public static void ProcessColour(Colour colour)
		{
			switch (colour)
			{
				case Colour.White:
					//white specific code
					break;
				case Colour.Black:
					//Black specific code
					break;

				case Colour.Red:
					//Red specific code
					break;
				case Colour.Green:
					//Green specific code
					break;

			}
		}
	}

	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		Console.WriteLine("Hello World!");
	//		WidelyUsedLibrary.ProcessColour(WidelyUsedLibrary.Colour.Red);
	//		//Some code....
	//		WidelyUsedLibrary.ProcessColour(WidelyUsedLibrary.Colour.Green);
	//		//Some code...
	//	}
	//}
}
