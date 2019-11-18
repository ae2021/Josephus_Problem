using System;

namespace Josephus_problem {
	class Program {
		/*
			Der folgende Algorithmus realisiert das Problem rekursiv nach der obigen Rekursionsformel für den Fall k=2 und besitzt eine Laufzeit von O(log(n)).

			int josephus(int n)
			{
				if(n == 1)
					return 1;

				if((n%2) == 0)
					return 2 * josephus(n / 2) - 1;

				if((n%2) == 1)
					return 2 * josephus((n - 1) / 2) + 1;
			}
		*/
		public static int Josephus_recursive(int n) {
			if (n == 1) { return 1; }
			if (n % 2 == 0) { return 2 * Josephus_recursive(n / 2) - 1; } else { return 2 * Josephus_recursive((n - 1) / 2) + 1; }
		}
		/*Gemäß der geschlossenen Formel f(n)=2*l + 1 lässt sich der folgende nicht-rekursive Algorithmus angeben. Seine Laufzeit liegt in O(1).
			int josephus(int n)
			{
				m = floor( log2(n) );
				l = n - 2^m;
				j = 2*l + 1;

				return j;
			}
 		*/
		public static int Josephus(int n) {
			int m = Convert.ToInt32(Math.Floor(Math.Log2(n)));
			int l = n - Convert.ToInt32(Math.Pow(2, m));
			return 2 * l + 1;
		}
		static void Main() {
			//k=2 n=5
			Console.WriteLine($" person at position {Josephus_recursive(5)} survives");
			Console.WriteLine($" person at position {Josephus(5)} survives");
		}
	}
}