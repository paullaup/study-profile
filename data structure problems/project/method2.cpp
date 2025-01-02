#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;

class ListNode {
    public:
        string num;
        ListNode* next;
        ListNode(string num, ListNode* next) {
            this->num = num;
            this->next = next;
        }
};

void printMostDuplicate(vector<string> list) {
    ListNode* root = new ListNode(list[0], NULL);
    for(int i = 1; i < list.size(); i++) {
        ListNode* current = root;
        ListNode* prev = NULL;
        while(current) {
            prev = current;
            if(current->num == list[i]) {
                break;
            }
            current = current->next;
        }
        if(!prev) {
            current->next = new ListNode(list[i], NULL);
        }
        else {
            prev->next = new ListNode(list[i], prev->next);
        }
    }

    ListNode* current = root;
    string max = root->num;
    string num = root->num;
    int maxCount = 0;
    int count = 0;

    while(current) {
        if(current->num != num) {
            if(count > maxCount) {
                max = num;
                maxCount = count;
            }
            count = 0;
            num = current->num;
        }
        count++;
        current = current->next;
    }
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

