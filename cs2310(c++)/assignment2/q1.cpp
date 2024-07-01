#include <iostream>
#include <string>

using namespace std;

int main() {
    char input[51];
    cout << "Please input a string:" << endl;
    cin.getline(input, 51);
    string str = input;
    cout << "Please input the length of subsequence:" << endl;
    int K;
    cin >> K;
    string max;
    for(int i = 0; i + K - 1<int(str.length()); i++) {
        max = (max.compare(str.substr(i, K))>0)? max : str.substr(i, K);
    }
    cout << "The maximum subsequence is:" << max;
    return 0;
}