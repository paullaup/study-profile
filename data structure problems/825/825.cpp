#include <iostream>
#include <unordered_map>
#include <deque>

using namespace std;

int main() {
    int number;
    cin >> number;
    unordered_map<int, int> globalChecked;
    deque<deque<int>> records;
    deque<int> time;
    int count = 0;
    while(number--) {
        int t, k;
        cin >> t >> k;
        time.push_back(t);
        int x;
        deque<int> record;
        unordered_map<int, int> localChecked; 
        for(int i = 0; i < k; i++) {
            cin >> x;
            if(!localChecked[x]) {
                record.push_back(x);
                localChecked[x]++;
                if(!globalChecked[x]) {
                    count++;
                }
                globalChecked[x]++;
            }
        }
        records.push_back(record);
        //cout << globalChecked[2] << endl;

        while(t - time.front() >= 86400 && time.size() > 1) {
            while(!records.front().empty()) {
                x = records.front().front();
                records.front().pop_front();
                globalChecked[x]--;
                if(!globalChecked[x]) {
                    //cout << x << " ";
                    count--;
                }
            }
            time.pop_front();
            records.pop_front();
            //cout << endl;
        }

        cout << count << endl;


    }
    
}