#include <iostream>
#include <stack>
#include <unordered_map>
using namespace std;

stack<int> findAnsector(unordered_map<int, int> parentOfChild, int data) {
    int current = data;
    stack<int> ans;
    while(current) {
        ans.push(current);
        current = parentOfChild[current];
    }
    return ans;
}

int main() {

    int T;
    cin >> T;
    while(T--) {

        int N;
        int parent, data;
        unordered_map<int, int> parentOfChild;
        cin >> parent >> N;

        for(int i = 0; i < N - 1; i++) {
            cin >> data >> parent;
            parentOfChild[data] = parent;
        }

        int data1, data2;
        cin >> data1 >> data2;

        stack<int> ansector1 = findAnsector(parentOfChild, data1);
        stack<int> ansector2 = findAnsector(parentOfChild, data2);

        int prev = -1;
        while(!ansector1.empty() && !ansector2.empty()) {
            if(ansector1.top() != ansector2.top()) {
                break;
            }
            prev = ansector1.top();
            ansector1.pop();
            ansector2.pop();
        }
        cout << prev << endl;

    }

    return 0;


}
