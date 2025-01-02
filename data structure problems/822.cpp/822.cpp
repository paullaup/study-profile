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
        TreeNode* parent;
        TreeNode* left;
        TreeNode* right;
        TreeNode() {
            left = nullptr;
            right = nullptr;
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

            int cost;
            if(concert->id == current->id)
                continue;
            // else if(concert->costPlusOne[current->id])
            //     cost = concert->costPlusOne[current->id] - 1;
            // else if(current->costPlusOne[concert->id])
            //     cost = current->costPlusOne[concert->id] - 1;
            else {
                TreeNode* temp1 = concert;
                TreeNode* temp2 = current;
                while(temp1->depth > 0 && temp2->depth > 0) {
                    if(temp1 == temp2) {
                        break;
                    }
                    else if(temp1->depth == temp2->depth) {
                        temp1 = temp1->parent;
                        temp2 = temp2->parent;
                    }
                    else if(temp1->depth < temp2->depth)
                        temp2 = temp2->parent;
                    else
                        temp1 = temp1->parent;
                }
                TreeNode* cca = (temp1->depth <= temp2->depth)? temp1 : temp2;
                
                if(cca == concert) {
                    cost = current->depth - cca->depth;
                }
                else {
                    cost = current->depth - cca->depth + concert->depth - cca->depth;
                }
                // if(!concert->costPlusOne[current->id] && !current->costPlusOne[concert->id])
                //     current->costPlusOne[concert->id] = cost + 1;
            }
           
            sum += current->num * cost;
        }
        if(sum < min) {
            min = sum;
        }
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