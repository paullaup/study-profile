#include <iostream>
#include <vector>
#include <stack>
#include <unordered_map>
#include <climits>

using namespace std;

class TreeNode {
    public:
        int depth;
        int num;
        int id;
        int previousCost;
        TreeNode* parent;
        TreeNode* left;
        TreeNode* right;
        TreeNode() {
            left = nullptr;
            right = nullptr;
            previousCost = -1;
        }

};

void insertTree(TreeNode* root, int i, const vector<int>& w, const vector<int>& l, const vector<int>&r, int depth, TreeNode* parent) {
    root->num = w[i];
    root->depth = depth;
    root->parent = parent;
    root->id = i;
    if(l[i]) {
        root->left = new TreeNode();
        insertTree(root->left, l[i] - 1, w, l, r, depth + 1, root);
    }
    if(r[i]) {
        root->right = new TreeNode();
        insertTree(root->right, r[i] - 1, w, l, r, depth + 1, root);
    }
}





void dfsConcertCity(TreeNode* root) {
    stack<TreeNode*> stackConcert;
    stackConcert.push(root);
    int min = INT_MAX;
    TreeNode* prev = nullptr;
    while(stackConcert.size()) {
        TreeNode* concert = stackConcert.top();
        stackConcert.pop();
        if(concert->right)
            stackConcert.push(concert->right);
        if(concert->left)
            stackConcert.push(concert->left);

        stack<TreeNode*> city;
        city.push(root);
        int sum = 0;

        while(city.size()) {
            TreeNode* current = city.top();
            city.pop();
            if(current->right)
                city.push(current->right);
            if(current->left)
                city.push(current->left);
            

            
        }

        if(sum < min) {
            min = sum;
        }
        prev = concert;
    }
    cout << min << endl;
}

int main() {
    int n;
    cin >> n;
    vector<int> w;
    vector<int> l;
    vector<int> r;
    for(int i = 0; i < n; i++) {
        int wi, li, ri;
        cin >> wi >> li >> ri;
        w.push_back(wi);
        l.push_back(li);
        r.push_back(ri);
    }
    TreeNode* root = new TreeNode();
    root->num = w[0];
    root->depth = 0;
    root->id = 0;
    if(l[0]) {
        root->left = new TreeNode();
        insertTree(root->left, l[0] - 1, w, l, r, 0 + 1, root);
    }
    if(r[0]) {
        root->right = new TreeNode();
        insertTree(root->right, r[0] - 1, w, l, r, 0 + 1, root);
    }
    dfsConcertCity(root);
    return 0;
}