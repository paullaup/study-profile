#include <iostream>
#include <string>
#include <sstream>
#include <unordered_map>
#include <vector>

using namespace std;

void printMostDuplicate(vector<string> list) {
    unordered_map<string, int> map;
    for(int i = 0; i < list.size(); i++) {
        map[list[i]]++;
    }
    string max = list[0];
    for(auto it : map) {
        if(it.second >= map[max]) {
            max = it.first;
        }
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

