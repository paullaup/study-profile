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

        int currentUnique;
        int minLength = m + 1;
        int size = academicPosition.size();
        for(int i = 0; i < size - uniqueCount + 1; i++) {
            unordered_map<string, int> counted;
            counted.insert({essay[academicPosition[i]], 1});
            currentUnique = 1;
            int j = 0;
            while(currentUnique < uniqueCount && i + j < size) {
                j++;
                if(!counted[essay[academicPosition[i + j]]]) {
                    counted.insert({essay[academicPosition[i + j]], 1});
                    currentUnique++;
                }
            }
            if(currentUnique == uniqueCount) {
                int length = academicPosition[i + j] - academicPosition[i] + 1;
                minLength = (length < minLength)? length : minLength;
            }
        }
        cout << uniqueCount << endl;
        cout << minLength << endl;


    }
    return 0;
}