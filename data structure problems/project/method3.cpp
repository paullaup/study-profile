#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;

class treeNode {
    public:
        string num;
        treeNode* left;
        treeNode* right;
        treeNode(string num) {
            this->num = num;
            left = NULL;
            right = NULL;
        }
};

bool checkPosition(vector<string> list, string num1, string num2) {
    for(int i = 0; i < list.size(); i++) {
        if(list[i] == num1) {
            return true;
        }
        if(list[i] == num2) {
            return false;
        }
    }
    return true;
}

void InOrder(treeNode* current, string& num, string& max, int& count, int& maxCount, vector<string> list) {
    if(!current) {
        return;
    }
    InOrder(current->left, num, max, count, maxCount, list);
    
    if(current->num != num) {
            if(count > maxCount || (count == maxCount && checkPosition(list, num, max))) {
                max = num;
                maxCount = count;
            }
            count = 0;
            num = current->num;
        }
        count++;


    InOrder(current->right, num, max, count, maxCount, list);

}

void insert(treeNode* root, string num) {
    if(num <= root->num) {
        if(!root->left) {
            root->left = new treeNode(num);
        }
        else {
            insert(root->left, num);
        }
    }
    else {
        if(!root->right) {
            root->right = new treeNode(num);
        }
        else {
            insert(root->right, num);
        }
    }
}

void printMostDuplicate(vector<string> list) {
    treeNode* root = new treeNode(list[0]);
    for(int i = 1; i < list.size(); i++) {
        insert(root, list[i]);
    }

    string max = root->num;
    string num = root->num;
    int maxCount = 0;
    int count = 0;

    InOrder(root, num, max, count, maxCount, list);
    cout << max << endl;
    


}

int main() {
    string input;
    while(getline(cin, input)) {
        vector<string> tokens;
        istringstream stream(input);
        string token;
        while(stream >> token) {
            tokens.push_back(token);
        }
        if(tokens.size()) {
            printMostDuplicate(tokens);
        }
    
    }
    return 0;
}

