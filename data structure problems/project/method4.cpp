#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;

void printMostDuplicate(vector<string> list) {

    

    for(int i = 0; i)

    for(int i = 0; i < list.size(); i++) {

    }
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

