#include <iostream>
#include <vector>
#include <unordered_map>
#include <stack>

using namespace std;

void dfsCount(const vector<vector<int>>& graph, unordered_map<int, bool>& visited, const int& node, int& nodeCount, int& edgeCount) {
    stack<int> s;
    s.push(node);
    visited[node] = true;
    while(s.size()) {
        nodeCount++;
        int u = s.top();
        s.pop();
        for (int i = 0; i < graph[u].size(); i++) {
            edgeCount++; 
            vector<int> v = graph[u];
            if (!visited[v[i]]) {
                s.push(v[i]);
                visited[v[i]] = true;
            }
        }
    }
    edgeCount /= 2; 
}

int solve(const int& n, const int& m, const vector<vector<int>>& graph) {
    unordered_map<int, bool> visited;
    int treeCount = 0;

    for (int i = 1; i <= n; ++i) {
        if (!visited[i]) {
            int nodeCount = 0; 
            int edgeCount = 0;

            dfsCount(graph, visited, i, nodeCount, edgeCount);

            if (edgeCount == nodeCount - 1)
                treeCount++;
        }
    }

    return treeCount;
}

int main() {
    int T = 1;
    while (true) {
        int n, m;
        cin >> n >> m;
        if (n == 0 && m == 0) 
            break;

        vector<vector<int>> graph(n + 1);
        int node1, node2;
        for (int i = 0; i < m; ++i) {
            cin >> node1 >> node2;
            graph[node1].push_back(node2);
            graph[node2].push_back(node1);
        }

        int treeCount = solve(n, m, graph);
        cout << "Case " << T++ << ": ";
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
    return 0;
}
