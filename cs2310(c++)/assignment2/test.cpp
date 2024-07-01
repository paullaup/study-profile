#include <iostream>
#include <fstream>
#include <string>
#include <cstring>

using namespace std;

bool isCharSame(char c1, char c2) {
    if(c1<97) {
        c1 += 32;
    }
    if(c2<97) {
        c2 += 32;
    }
    return c1 == c2;
}

bool isDuplicated(string s1, string s2) {
    if(s1.compare(s2) == 0) {
        return true;
    }
    else {
        if(s1.length() != s2.length() ) {
            return false;
        }
        for(int i = 0; i<int(s1.length()); i++) {
            if(!isCharSame(s1[i], s2[i])) {
                return false;
            }
        }
    }
    return true;
}

bool isNumberingFormat(string s) {
    if(s.length()>2 && s[0]>=48 && s[0]<=57 && s[1]=='.' && s[2] == ' ' ) {
        return true;
    }
    else if(s.length()==2 && s[0]>=48 && s[0]<=57 && s[1]=='.') {
        return true;
    }
    return false;
}

bool isEmpty(const string s) {
    for(int i = 0; i<s.length(); i++) {
        if(s[i] != ' ') {
            return false;
        }
    }
    return true;
}


// use stream readline to collect the manually new row from the orginal text  
int main() {
    cout << isEmpty("                  ");
    return 0;
}