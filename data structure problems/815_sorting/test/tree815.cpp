#include <iostream>
#include <vector>

using namespace std;


class treeNode {

    public:
        int data;
        treeNode* left;
        treeNode* right;

        treeNode() {
            this->data = 0;
            left = NULL;
            right = NULL;
        }
        treeNode(int data) {
            this->data = data;
            left = NULL;
            right = NULL;
        }
        treeNode(int data, treeNode* left, treeNode* right) {
            this->data = data;
            this->left = left;
            this->right = right;
        }

};

class solution {
    public:
        treeNode* root;
        int size;
        int lower;
        int upper;
        


        solution(int size) {
            this->size = size;
            root = NULL;
        }

        void sorting(int data) {
                lower = 0;
                upper = size + 1;
                insert(root, data);
                cout << lower << " " << upper << endl;
        }

        void insert(treeNode*& r, int data) {
            if(r == NULL) {
                r = new treeNode(data);
                return;
            }

            lower = (r->data > lower && r->data <= data)? r->data : lower;
            upper = (r->data < upper && r->data >= data)? r->data : upper;

            if(data <= r->data) {
                insert(r->left, data);
            }
            else {
                insert(r->right, data);
            }
        }
};

int main() {

    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int testCaseCount;
    int data;
    cin >> testCaseCount;
    while(testCaseCount--) {
        int size;
        cin >> size;
        solution s(size);
        while(size--) {
            cin >> data;
            s.sorting(data);
        }
    }
    return 0;
}