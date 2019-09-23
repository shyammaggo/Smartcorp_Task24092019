using System;
using System.Collections.Generic;
using System.Text;
using IWidelyUserLibrary;
namespace WidelyUsedLibrary
{
	class Program
	{

		static void Main(string[] args)
		{
			 
			var gc = new GreenClass();
			gc.ProcessColourImplentation();

			var rc = new RedClass();
			rc.ProcessColourImplentation();

			var wc = new WhiteClass();
			wc.ProcessColourImplentation();

			var bc = new BlackClass();
			bc.ProcessColourImplentation();


		}
	}
}
