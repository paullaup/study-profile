#include <iostream>
#include <vector>
#include <queue>
#include <utility>
#include <algorithm>
#include <climits>

using namespace std;

struct Edge {
    int to;
    int rev;
    int capacity;
    int cost;
};

class MinCostMaxFlow {
public:
    int n;
    vector<vector<Edge>> graph;

    MinCostMaxFlow(int nodes) : n(nodes), graph(nodes, vector<Edge>()) {}

    void add_edge(int from, int to, int capacity, int cost){
        Edge forward = {to, static_cast<int>(graph[to].size()), capacity, cost};
        Edge backward = {from, static_cast<int>(graph[from].size()), 0, -cost};
        graph[from].push_back(forward);
        graph[to].push_back(backward);
    }

    // Returns pair of (flow, cost)
    pair<int, int> flow(int s, int t, int maxf){
        int flow = 0;
        int flow_cost = 0;
        vector<int> prevv(n, -1);
        vector<int> preve(n, -1);

        while(flow < maxf){
            // Dijkstra's algorithm
            vector<int> dist(n, INT32_MAX);
            dist[s] = 0;
            // Priority queue: (distance, node)
            priority_queue<pair<int, int>, vector<pair<int, int>>, std::greater<pair<int, int>>> pq;
            pq.emplace(0, s);

            while(!pq.empty()){
                pair<int, int> current = pq.top();
                pq.pop();
                int d = current.first;
                int u = current.second;

                if(d > dist[u]) continue;

                for(int i = 0; i < graph[u].size(); ++i){
                    Edge &e = graph[u][i];
                    if(e.capacity > 0 && dist[e.to] > dist[u] + e.cost){
                        dist[e.to] = dist[u] + e.cost;
                        prevv[e.to] = u;
                        preve[e.to] = i;
                        pq.emplace(dist[e.to], e.to);
                    }
                }
            }

            if(dist[t] == INT32_MAX){
                break; // No more augmenting paths
            }

            // Determine the amount of flow to add
            int addf = maxf - flow;
            int v = t;
            while(v != s){
                int u = prevv[v];
                int idx = preve[v];
                addf = min(addf, graph[u][idx].capacity);
                v = u;
            }

            flow += addf;
            flow_cost += addf * dist[t];

            // Update residual capacities
            v = t;
            while(v != s){
                int u = prevv[v];
                int idx = preve[v];
                graph[u][idx].capacity -= addf;
                graph[v][graph[u][idx].rev].capacity += addf;
                v = u;
            }
        }

        return {flow, flow_cost};
    }
};

int main(){
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    while(true){
        int n;
        cin >> n;
        if(n == 0){
            break;
        }
        int m;
        cin >> m;

        // Nodes are 1-based in input, convert to 0-based
        MinCostMaxFlow mcmf(n);
        for(int i = 0; i < m; ++i){
            int u, v, t;
            cin >> u >> v >> t;
            --u; // Convert to 0-based
            --v;
            mcmf.add_edge(u, v, 1, t);
            mcmf.add_edge(v, u, 1, t);
        }

        // Source is node 0 (1 in input), sink is node n-1
        pair<int, int> result = mcmf.flow(0, n-1, 2);

        if(result.first < 2){
            cout << "Back to jail\n";
        }
        else{
            cout << result.second << "\n";
        }
    }

    return 0;
}
