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
			Matrix matrix = new Matrix(new Vector2(2,3), "");
			Assert.AreEqual(matrix.size, new Vector2(2,3)); 
		}


		[Test]
		public void SizeSqareTest()
		{
			Matrix matrix = new Matrix(new Vector2(3,3), "");
			Assert.IsTrue(matrix.isSquare());
		}


		[Test]
		public void SizeNotSqareTest()
		{
			Matrix matrix = new Matrix(new Vector2(2,3), "");
			Assert.IsFalse(matrix.isSquare());
		}


		[Test]
		public void TotalCountTest()
		{
			Matrix matrix = new Matrix(new Vector2(2,3), "");
			Assert.AreEqual(matrix.TotalCount(), 6);
		}


		[Test]
		public void InsertTest()
		{
			Matrix matrix = new Matrix(new Vector2(3, 4), "");
			string testString = "test";
			Vector2 cordinates = new Vector2(2,3);
			matrix.Insert(testString, cordinates);
			Assert.AreSame(matrix.Get(cordinates), (string)testString);
		}

		[Test]
		public void NumberFilledTest()
		{
			Matrix matrix = new Matrix(new Vector2(3, 4), "");
			string testString = "test";
			Vector2 cordinates = new Vector2(2,3);
			matrix.Insert(testString, cordinates);

			int result = 0;

			//collumns
			for (int y=0; y<=matrix.size.y; y++)
			{
				//rows
				for (int x=0; x<=matrix.size.x; x++)
				{
					if (matrix.Get(new Vector2(x, y)) != "") result++;
				}

			}

			Assert.AreEqual(1, result);


		}




	}






}