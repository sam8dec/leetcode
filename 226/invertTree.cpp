#include <iostream>
using namespace std;

/**
 * Definition for a binary tree node.
 **/
struct TreeNode {
     int val;
     TreeNode *left;
     TreeNode *right;
     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
};

class Solution {
public:
    TreeNode* invertTree(TreeNode* root) {
        if (root) {
            TreeNode* newLeft = invertTree(root->left);
            TreeNode* newRight = invertTree(root->right);
            root->left = newRight;
            root->right = newLeft;
        }
        return root;
    }
};

int main() {
    return 0;
}
