#include <iostream>
#include <string>
#include <unordered_map>
#include <vector>
using namespace std;

string solve(int* preorder, int* inorder, int root, int inLeft, int inRight, unordered_map<int, int> preMap, unordered_map<int, int> inMap, vector<int>& v) {
    if(inLeft > inRight) {
        return "";
    }
    string s = to_string(root);
    string left = solve(preorder, inorder,preorder[ preMap[root] + 1 ], inLeft, inMap[root] - 1, preMap, inMap, v);
    string right = solve(preorder, inorder, preorder[ preMap[root] + 1 + (inMap[root] - inLeft) ], inMap[root] + 1, inRight, preMap, inMap, v);
    v.push_back(root);
    return left + " " + right + " " + s;
}

int main() {
    int T;
    cin >> T;
    while(T--) {
        int size;
        cin >> size;
        if(size == 0) {
            continue;
        }
        int* preorder = new int[size];
        int* inorder = new int[size];
        int x;
        int leftleft = 0;
        int rightright = size - 1;
        unordered_map<int, int> preMap;
        unordered_map<int, int> inMap;
        for(int i = 0; i < size; i++) {
            cin >> x;
            preorder[i] = x;
            preMap[x] = i;
        }
        int root = preorder[0];
        for(int i = 0; i < size; i++) {
            cin >> x;
            inorder[i] = x;
            inMap[x] = i;
        }
        vector<int> post;
        string s = solve(preorder, inorder, root, leftleft, rightright, preMap, inMap, post);
        for(int i = 0; i < post.size() - 1; i++) {
            cout << post[i] << " ";
        }
        cout << post[post.size() - 1] << endl;
    }
    return 0;
}