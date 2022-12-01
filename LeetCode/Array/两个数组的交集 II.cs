namespace LeetCode
{
    internal class 两个数组的交集_II
    {
        public static void Main()
        {
            var nums1 = new int[] { 4, 9, 5 };
            var nums2 = new int[] { 9, 4, 9, 8, 4 };
            Intersect(nums1, nums2);
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            var i = 0;
            var j = 0;
            var list = new List<int>();
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    list.Add(nums1[i]);
                    j++;
                    i++;
                }
            }
            return list.ToArray();
        }
    }
}
