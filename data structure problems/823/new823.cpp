#include <iostream>
#include <unordered_map>
#include <vector>

using namespace std;

int main() {
    int m;
    int n;
    string word;
    int uniqueCount;
    while(cin >> n) {

        unordered_map<string, int> academicDict;
        for(int i = 0; i < n; i++) {
            cin >> word;
            academicDict.insert({word, 1});
        }

        cin >> m;
        vector<int> academicPosition;
        string* essay = new string[m];
        uniqueCount = 0;
        for(int i = 0; i < m; i++) {
            cin >> essay[i];
            if(academicDict[essay[i]]) {
                academicPosition.push_back(i);
                if(academicDict[essay[i]] == 1) {
                    uniqueCount++;
                } 
                academicDict[essay[i]] = 2;
            }
        }

        if(!uniqueCount) {
            cout << 0 << endl;
            cout << 0 << endl;
            continue;
        }

        int currentUnique = 0;
        int minLength = m + 1;
        int size = academicPosition.size();
        int start;
        int indexStart = 0;
        int end;
        unordered_map<string, int> counted;
        for(int indexEnd = 0; indexEnd < size ; indexEnd++) {
            end = academicPosition[indexEnd];
            counted[essay[end]]++;
            if(counted[essay[end]] == 1) {
                currentUnique++;
            }
            while(currentUnique == uniqueCount) {
                start = academicPosition[indexStart];
                if (end - start + 1 < minLength) {
                    minLength = end - start + 1;
                }
                counted[essay[start]]--;
                if(counted[essay[start]] == 0) {
                    currentUnique--;
                }
                indexStart++;
            }
        }
        cout << uniqueCount << endl;
        cout << minLength << endl;
        delete essay;

    }
    return 0;
}