using UnityEngine;
using System;
using System.Threading;
using NUnit.Framework;


namespace UnitTest
{
	internal class MatrixTest
	{
		[Test]
		public void SizeTest()
		{
			Matrix matrix = new Matrix(new Vector2(2,3));
			Assert.AreEqual(matrix.size, new Vector2(2,3)); 
		}


		[Test]
		public void SizeSqareTest()
		{
			Matrix matrix = new Matrix(new Vector2(3,3));
			Assert.IsTrue(matrix.isSquare());
		}


		[Test]
		public void SizeNotSqareTest()
		{
			Matrix matrix = new Matrix(new Vector2(2,3));
			Assert.IsFalse(matrix.isSquare());
		}
	}

}