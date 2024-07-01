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
    for(int i = 0; i<int(s.length()); i++) {
        if(s[i] != ' ') {
            return false;
        }
    }
    return true;
}


// use stream readline to collect the manually new row from the orginal text  
int main() {
    int fileNumber;
    string fileName = "input";
    cout << "Please input file number (1-10):" << endl;
    cin >> fileNumber;
    fileName += to_string(fileNumber) + ".txt";
    ifstream fin;
    fin.open(fileName);
    string words[1000];
    int top = 0;




    
    char ch;
    string temp = "";
    string previousWord = "";

    while(fin.get(ch)) {

        if(temp == "\n ") {
            words[top++] = "\n";
            temp = "";
        }
        else if(ch == ' ' && !isEmpty(temp)) {
            if(!isDuplicated(temp, previousWord)) {
                previousWord = temp;
                //cout << '|' << temp << '|' << endl;
                words[top++] = temp;
            }
            temp = "";
        }
        else if(ch != ' ') {
            temp += ch;
        }
    }
    if(!isDuplicated(temp, previousWord)) {
                previousWord = temp;
                words[top++] = temp;
    }


    int current = 0;
    while(current < top) {


        int rowWordsCount = 0; 
        int rowSize = 0;
        bool isLastLine = false;

        while(rowSize + words[current + rowWordsCount].length() <= 70) {
            if(words[current + rowWordsCount] == "\n") {
                isLastLine = true;
                words[current + rowWordsCount] = "";
                break;
            }
            rowSize += words[current + rowWordsCount++].length() + 1;
            //check if the program print all the text and check if require to move to a new line
            if(isNumberingFormat(words[current + rowWordsCount])) {
                isLastLine = true;
                break;
            }
            if(current + rowWordsCount >= top) {
                isLastLine = true;
                break;
            }
        }
        rowSize--;          //remove the space after the last word

        int remainSpace = (isLastLine)? 0 : 70 - rowSize;
        //cout << "size " << rowSize << " space " << remainSpace << endl;
        for(int i = 0; i<rowWordsCount - 1; i++) {
            words[current + i].append(" ");
        }
        //add the space
        while(remainSpace>0) {
            for(int i = 0; i<rowWordsCount - 1; i++) {
                if(!isNumberingFormat(words[current + i])) {
                    words[current + i].append(" ");
                    remainSpace--;
                }
                if(remainSpace<=0) {
                    break;
                }
            }
        }
        for(int i = 0; i<rowWordsCount; i++) {
            cout << words[current + i];
        }
        cout << endl;
        current += rowWordsCount;

    }
    
    
    return 0;
}