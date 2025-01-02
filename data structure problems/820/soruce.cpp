#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

int main() {
    int T;
    cin >> T;
    vector<int> v;
    while(T--) {
        int n, m;
        cin >> n >> m;
        unordered_map<int, int> branchCount;

        int temp = n;
        while(temp--) {
            int node;
            int k = 0;
            do{ 
                cin >> node;
                if(k == 0) {
                    branchCount[node]++;
                }
                k++;
            }while(node != -1);
        }

        temp = m;
        while(temp--) {
            int k = 0;
            int a;
            do {
                cin >> a;
                if(k == 0) {
                    v.push_back(a);
                }
                k++;
            }while(a != -1);
        }
        if(m == 0) {
            cout << branchCount.size() << endl;
        } else {
            int cut = 0;
            for(int i = 0; i < v.size(); i++) {
                auto it = branchCount.find(v[i]);
                if(it == branchCount.end()) {
                    continue;
                }
                else {
                    while(branchCount[v[i]] != 0) {
                        cut++;
                        branchCount[v[i]]--;
                    }
                }
            }
            for(auto i : branchCount ) {
                if(i.second != 0) {
                    cut++;
                } else {
                    continue;
                }
            }
            cout << cut << endl;
        }
    }
}