#include <iostream>
#include <map>
#include <set>
#include <string>
#include <unordered_map>
#include <vector>
using namespace std;

int main() {
    int n;
    while (cin >> n) {
        set<string> academicSet;
        string word;
        for (int i = 0; i < n; ++i) {
            cin >> word;
            academicSet.insert(word);
        }

        int m;
        cin >> m;
        vector<string> essay(m);
        for (int i = 0; i < m; ++i) {
            cin >> essay[i];
        }

        set<string> academicWordsInEssay;
        for (const auto& w : essay) {
            if (academicSet.count(w)) {
                academicWordsInEssay.insert(w);
            }
        }

        int K = academicWordsInEssay.size();
        if (K == 0) {
            cout << "0\n0\n";
            continue;
        }

        unordered_map<string, int> wordCounts;
        int currentAcademicWordCount = 0;
        int maxAcademicWords = 0;
        int minLength = m + 1;
        int start = 0;

        for (int end = 0; end < m; ++end) {
            word = essay[end];
            if (academicSet.count(word)) {
                wordCounts[word]++;
                if (wordCounts[word] == 1) {
                    currentAcademicWordCount++;
                }
            }

            while (currentAcademicWordCount == K) {
                if (end - start + 1 < minLength) {
                    minLength = end - start + 1;
                    maxAcademicWords = currentAcademicWordCount;
                }
                string startWord = essay[start];
                if (academicSet.count(startWord)) {
                    wordCounts[startWord]--;
                    if (wordCounts[startWord] == 0) {
                        currentAcademicWordCount--;
                    }
                }
                start++;
            }
        }

        cout << maxAcademicWords << endl;
        cout << minLength << endl;
    }
    return 0;
}
