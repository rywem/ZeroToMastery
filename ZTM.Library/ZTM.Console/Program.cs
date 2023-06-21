// See https://aka.ms/new-console-template for more information
using ZTM.Library.Google;
using ZTM.Library.Exercises;
using ZTM.Library.Arrays;

Console.WriteLine("Hello, World!");

//List<int> ints1 = new List<int>() { 1, 2, 3, 9 };
//List<int> ints2 = new List<int>() { 1, 2, 4, 4 };

//CollectionSum collectionSum = new CollectionSum();
//Console.WriteLine(collectionSum.HasPairWithSum(ints1, 8));

//List<string> col1 = new List<string>() { "A", "B", "C", "D"};
//List<string> col2 = new List<string>() { "T", "R", "M"};
//List<string> col3 = new List<string>() { "T", "R", "D" };

//CollectionCommonElement collectionCommonElement = new CollectionCommonElement();
//Console.WriteLine(collectionCommonElement.DoCollectionsContainCommon(col1, col3));

//ReverseArray reverseArray = new ReverseArray();
//Console.WriteLine(reverseArray.ReverseString("Hello"));
//MergeSorted mergeSorted = new MergeSorted();
//int[] first = new int[] { 0, 3, 4, 31 };
//int[] second = new int[] { 4, 6, 30 };
//var result = mergeSorted.MergeSortedArrays(first, second);

PracticeArrayQuestions practice = new PracticeArrayQuestions();
//var result = practice.TwoSum(new int[]{1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1}, 11);

//int[] nums = new int[]{ -1, 2, -5, 3, 4, -4, 6, 1, -1, -8};
//Console.WriteLine(practice.MaxSubArray(nums));
int[] nums = new int[] { 73348, 66106, -85359, 53996, 18849, -6590, -53381, -86613, -41065, 83457, 0 };
var result = practice.MoveZeroes(nums);
foreach (int i in result)
{
    Console.WriteLine(i);
}