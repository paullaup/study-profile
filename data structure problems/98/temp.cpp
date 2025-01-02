#include <iostream>
#include <vector>
#include <unordered_map>
#include <stack>

using namespace std;

void dfs(const vector<vector<int>>& graph, unordered_map<int, bool>& visited, int node, int& nodeCount, int& edgeCount) {
    stack<int> s;
    s.push(node);
    visited[node] = true;
    while(s.size()) {
        nodeCount++;
        int u = s.top();
        s.pop();
        for (int i = 0; i < graph[u].size(); i++) {
            vector<int> v = graph[u];
            edgeCount++; 
            if (!visited[v[i]]) {
                s.push(v[i]);
                visited[v[i]] = true;
            }
        }
    }
    edgeCount /= 2; 
}

void solve(int n, int m,  vector<vector<int>> graph, const vector<pair<int, int>>& edges) {
    vector<vector<int>> graph(n + 1);
    for (int i = 0; i < edges.size(); i++) {
        int u = edges[i].first;
        int v = edges[i].second;
        graph[u].push_back(v);
        graph[v].push_back(u);
    }

    unordered_map<int, bool> visited;
    int treeCount = 0;

    for (int i = 1; i <= n; ++i) {
        if (!visited[i]) {
            int nodeCount = 0; 
            int edgeCount = 0;

            dfs(graph, visited, i, nodeCount, edgeCount);

            if (edgeCount == nodeCount - 1)
                treeCount++;
        }
    }

    switch (treeCount){
        case 0:
            cout << "No trees." << endl;
            break;
        case 1:
            cout << "There is one tree." << endl;
            break;
        default:
            cout << "A forest of " << treeCount << " trees." << endl;
    }
}

int main() {
    int T = 1;
    while (true) {
        int n, m;
        cin >> n >> m;
        if (n == 0 && m == 0) 
            break;

        vector<pair<int, int>> edges(m);
        for (int i = 0; i < m; ++i) {
            cin >> edges[i].first >> edges[i].second;
        }

        cout << "Case " << T++ << ": ";
        solve(n, m, edges);
    }
    return 0;
}
