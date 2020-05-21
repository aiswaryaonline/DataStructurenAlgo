/* 
 Problem: Given array of disrinct integers. Need to find out two intergers whose sum is given output.
 If not found then return null;
 Example: given array = [3,5,2,6,-5,3,7,8,9]
		  Target Sum = 3
		  Output = [-5,8]
 */

using System.Collections.Generic;

public class SumofTwoIntegerEasy
{
	/// <summary>
	/// Find sum of two integers using two loops
	/// Time of complexity: O(n*n) = o(n2)
	/// </summary>
	/// <param name="array"></param>
	/// <param name="targetSum"></param>
	/// <returns></returns>
	//public int[] FindSumOfTwoInteger(int[] array, int targetSum)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		var firstNumber = array[i];
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			int secondNumber = array[j];
	//			if (firstNumber + secondNumber == targetSum)
	//				return new int[] { firstNumber, secondNumber };
	//		}
	//	}
	//	return new int[] { };
	//}

	/// <summary>
	/// Find sum of two integers using HashSet
	/// Read each number, add unique number in HashSet. check if secondNumber = outsum-firstnumber exists in hashset
	/// TimeComplexity = 0(n);
	/// </summary>
	/// <param name="array"></param>
	/// <param name="targetSum"></param>
	/// <returns></returns>
	public int[] FindSumOfTwoInteger(int[] array, int targetSum)
	{
		HashSet<int> distinctNumbers = new HashSet<int>();
		for (int i = 0; i < array.Length; i++)
		{
			var firstNumber = array[i];
			var secondNumber = targetSum - array[i];
			if (distinctNumbers.Contains(secondNumber))
				return new int[] { firstNumber, secondNumber };
			else
				distinctNumbers.Add(firstNumber);
		}
		return new int[] { };
	}
}
