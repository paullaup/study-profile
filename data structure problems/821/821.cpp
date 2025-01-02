#include <iostream>
#include <vector>

using namespace std;

pair<int, long long> findFarthest(const vector<vector<pair<int, int>>>& adjEdge, int startNode, int parent, long long costSum) {
    pair<int, long long> farthest = {startNode, costSum};
    for(const auto& edge : adjEdge[startNode]) {
        int neighbor = edge.first;
        int cost = edge.second;
        if(neighbor != parent) {
            pair<int, long long> temp = findFarthest(adjEdge, neighbor, startNode, costSum + cost);
            if(temp.second > farthest.second)
                farthest = temp;
        }
    }
    return farthest;
}

int main() {
    int n;
    cin >> n;

    if(n == 1) {
        cout << 0;
    }

    vector<vector<pair<int, int>>> adjEdge(n);

    for(int i = 0; i < n; i++) {
        int u, v, w;
        cin >> u >> v >> w;

        adjEdge[u].emplace_back(v, w);
        adjEdge[v].emplace_back(u, w);
    }

    pair<int, long long> farthest = findFarthest(adjEdge, 1, -1, 0);

    pair<int, long long> farthestFarthest = findFarthest(adjEdge, farthest.first, -1, 0);

    cout << farthestFarthest.second << endl;



    return 0;
}