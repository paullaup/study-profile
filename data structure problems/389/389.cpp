#include <iostream>

using namespace std;

int main() {
    int testCaseCount;
    int credit;
    cin >> testCaseCount;
    for(int current = 0; current < testCaseCount; current++){
        cin >> credit;
        int itemCount;
        cin >> itemCount;
        int* prices = new int[itemCount];
        for(int i = 0; i < itemCount; i++) {
            cin >> prices[i];
        }

        int* differences = new int[itemCount];
        for(int i = 0; i <= itemCount; i++){
            bool isFound = false;
            for(int j = 0; j < i; j++) {
                if(prices[i] == differences[j]) {
                    cout << "Case #" << current + 1 << ": " << j + 1 << " " <<  i + 1 << endl;
                    isFound = true;
                    break;
                }
            }
            if(isFound) {
                break;  
            }
            differences[i] = credit - prices[i];
        }
        delete prices, differences;

    }
    return 0;
}