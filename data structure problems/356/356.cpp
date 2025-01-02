#include <iostream>
#include <vector>
#include <unordered_map>
#include <stack>
#include <climits>

using namespace std;

int main() {

    int n, m;
    do {
        cin >> n >> m;
        if(n == 0 && m == 0) 
            break;

        vector<int> us;
        vector<int> vs;
        vector<int> ws;
        int maxPPA = INT_MIN;
        for(int i = 0; i < m; i++) {
            int u, v, w;
            cin >> u >> v >> w;
            us.push_back(u);
            vs.push_back(v);
            ws.push_back(w);
            if(w > maxPPA) 
                maxPPA = w;
        }

        vector<vector<int>> adjList(n + 1);
        for(int i = 0; i < m; i++) {
            if(ws[i] == maxPPA) {
                adjList[us[i]].push_back(vs[i]);
                adjList[vs[i]].push_back(us[i]);
            }
        }

        int max = -1;
        unordered_map<int, bool> visited;
        for(int i = 1; i <= n; i++) {
            int count = 1;
            if(visited[i] || adjList[i].empty()) {
                continue;
            }
            stack<int> stk;
            stk.push(i);
            visited[i] = true;
            while(stk.size()) {
                int u = stk.top();
                stk.pop();
                for(int v : adjList[u]){
                    if(!visited[v]){
                        count++;
                        stk.push(v);
                        visited[v] = true;
                    }
                }
            }
            if(count > max)
                max = count;
        }
        cout << max << endl;

    } while(n != 0 && m != 0);
}