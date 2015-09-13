#include<iostream>
using namespace std;
/**
 * Definition for a binary tree node.
**/
struct TreeNode {
     int val;
     struct TreeNode *left;
     struct TreeNode *right;
};

int maxDepth(struct TreeNode* root) {
    int dl, dr;
    if (root) {
        dl = maxDepth(root->left);
        dr = maxDepth(root->right);
        if (dl>dr) return dl+1; else return dr+1;
    }
    return 0;
}

int main() {
    TreeNode* r = new TreeNode();
    r->left = new TreeNode();
    r->right = new TreeNode();
    r->left->left = new TreeNode();
    cout<<maxDepth(r);
    return 0;
}
