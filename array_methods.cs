int[] nums = new int[] { 2, 3, 4, 5, 6, 7 };

// ------------------------------------------------------------------------------------------------------------

// Array.IndexOf
// If nums has the value 2, it returns index of 2 (0 in this case), it's the first instance of an element.
// If nums doesn't have the value 2, it returns -1
int doesItContain = Array.IndexOf(nums, 2);

// Looks for 3 starting from index 2
doesItContain = Array.IndexOf(nums, 3, 2);

// Looks for 3 starting from the last index, still returns the first instance of an element
doesItContain = Array.LastIndexOf(nums, 3);

// ------------------------------------------------------------------------------------------------------------

// Array.Clear
// Gives everything in the array a value of 0, is a void method
// Previous array   [ 2, 3, 4, 5, 6, 7 ]
// Current array    [ 0, 0, 0, 0, 0, 0 ]
Array.Clear(nums);

// Starting from index 2, clears all 5 values
Array.Clear(nums, 2, 5);

// ------------------------------------------------------------------------------------------------------------

// Array.Copy
int[] copy = new int[6];

// Copies the nums array inside of copy array
Array.Copy(nums, copy, 6);

// Starting from index 1 in nums and starting from index 3 in copy, get 4 elements from nums
Array.Copy(nums, 1, copy, 3, 4);

// ------------------------------------------------------------------------------------------------------------

// Array.Reverse
// Self explanatory
Array.Reverse(nums);

// ------------------------------------------------------------------------------------------------------------

// Array.Sort
Array.Sort(nums);

