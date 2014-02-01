using System;
using System.Threading;
using NUnit.Framework;


namespace UnitTest
{
	internal class CellTest
	{
		[Test]
		public void Damage()
		{
			Cell cell = new Cell(10);
			cell.Damage(5);
			Assert.AreEqual(10-5, cell.lifeLeft, "Life left other than expected");
		}


		[Test]
		public void Kill()
		{
			Cell cell = new Cell(10);
			cell.Damage(10);
			if (cell.lifeLeft > 0)
			{
				Assert.Fail("Cell not killed");
			} else Assert.Pass();
		}


	}

}