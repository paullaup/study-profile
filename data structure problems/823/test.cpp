#include <iostream>
#include <unordered_map>
#include <vector>
#include <set>

using namespace std;

int main() {
    int m;
    int n;
    string word;
    while(cin >> n) {

        unordered_map<string, int> academicDict;
        set<string> academicWordsSet;
        for(int i = 0; i < n; i++) {
            cin >> word;
            academicDict[word] = 0; // Initialize count to 0
            academicWordsSet.insert(word);
        }

        cin >> m;
        vector<string> essay(m);
        for(int i = 0; i < m; i++) {
            cin >> essay[i];
        }

        int totalUniqueAcademicWords = academicWordsSet.size();
        if (totalUniqueAcademicWords == 0) {
            cout << "0\n0\n";
            continue;
        }

        int start = 0;
        int minLength = m + 1;
        int maxUniqueCount = 0;
        unordered_map<string, int> windowCounts;
        int currentUnique = 0;

        for (int end = 0; end < m; ++end) {
            word = essay[end];
            if (academicWordsSet.count(word)) {
                windowCounts[word]++;
                if (windowCounts[word] == 1) {
                    currentUnique++;
                }
            }

            while (start <= end) {
                string startWord = essay[start];
                if (!academicWordsSet.count(startWord)) {
                    start++;
                } else if (windowCounts[startWord] > 1) {
                    windowCounts[startWord]--;
                    start++;
                } else {
                    break;
                }
            }

            if (currentUnique > maxUniqueCount) {
                maxUniqueCount = currentUnique;
                minLength = end - start + 1;
            } else if (currentUnique == maxUniqueCount && end - start + 1 < minLength) {
                minLength = end - start + 1;
            }
        }

        cout << maxUniqueCount << endl;
        cout << minLength << endl;
    }
    return 0;
}
