public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Back(nums, 0, new List<int>(), result);
        return result;
    }

    public void Back(int[] nums, int pos, List<int> current, List<List<int>> result) {
        result.Add(new List<int>(current)); 

        for (int i = pos; i < nums.Length; i++) {
            current.Add(nums[i]);          
            Back(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1); 
        }
    }
}