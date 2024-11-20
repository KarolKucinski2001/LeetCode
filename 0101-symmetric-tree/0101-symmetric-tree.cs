public class Solution {
    public bool IsSymmetric(TreeNode root) {
        return findSymetric(root.left, root.right);
    }

    public bool findSymetric(TreeNode left, TreeNode right){
        if(left == null || right == null) return left == right;

        return (left.val == right.val) && findSymetric(left.left, right.right) && findSymetric(right.left, left.right);
    }
}