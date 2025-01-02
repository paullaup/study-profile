#include <iostream>
#include <vector>
#include <stack>

using namespace std;

void dfs(const vector<vector<int>>& graph, vector<bool>& visited, int node, int& vertices_count, int& edges_count) {
    stack<int> s;
    s.push(node);
    visited[node] = true;
    while (!s.empty()) {
        int u = s.top();
        s.pop();
        vertices_count++;
        for (int v : graph[u]) {
            edges_count++; // count each edge (undirected graph)
            if (!visited[v]) {
                visited[v] = true;
                s.push(v);
            }
        }
    }
    edges_count /= 2; // Since the graph is undirected, we count each edge twice
}

void solve_case(int n, int m, const vector<pair<int, int>>& edges) {
    vector<vector<int>> graph(n + 1);
    for (const auto& edge : edges) {
        int u = edge.first, v = edge.second;
        graph[u].push_back(v);
        graph[v].push_back(u);
    }

    vector<bool> visited(n + 1, false);
    int tree_count = 0;

    for (int i = 1; i <= n; ++i) {
        if (!visited[i]) {
            int vertices_count = 0, edges_count = 0;
            dfs(graph, visited, i, vertices_count, edges_count);
            // A component is a tree if it has exactly `vertices_count - 1` edges
            if (edges_count == vertices_count - 1) {
                tree_count++;
            }
        }
    }

    if (tree_count == 0) {
        cout << "No trees.\n";
    } else if (tree_count == 1) {
        cout << "There is one tree.\n";
    } else {
        cout << "A forest of " << tree_count << " trees.\n";
    }
}

int main() {
    int case_num = 1;
    while (true) {
        int n, m;
        cin >> n >> m;
        if (n == 0 && m == 0) break;

        vector<pair<int, int>> edges(m);
        for (int i = 0; i < m; ++i) {
            cin >> edges[i].first >> edges[i].second;
        }

        cout << "Case " << case_num << ": ";
        solve_case(n, m, edges);
        case_num++;
    }
    return 0;
}
