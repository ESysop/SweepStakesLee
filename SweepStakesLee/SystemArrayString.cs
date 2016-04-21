using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesLee
	{
	public class SystemArrayString : ICustomString
		{

		char[] manipulatedCharArray;

		public SystemArrayString (string manipulatedString)
			{
			manipulatedCharArray = manipulatedString.ToCharArray();
			}
		public override string ToString ()
			{
			string finalString = null;
			foreach (char character in manipulatedCharArray)
				{
				finalString += character;
				
				}
			return finalString;
			}



		public void Insert (int startIndex, string stringToInsert)
			{
			
			char[] insertedCharsArray = stringToInsert.ToCharArray();
			
			}

		public int Length ()
			{
			return manipulatedCharArray.Length;
			}

		public void Remove (int startIndex, int numCharsToRemove)
			{
			throw new NotImplementedException();
			}
		}
	}
