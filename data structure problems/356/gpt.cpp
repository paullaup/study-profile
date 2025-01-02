#include <iostream>
#include <vector>
#include <bitset>
#include <queue>
#include <climits>

using namespace std;

// Define the maximum number of cities based on constraints
const int MAX_CITIES = 500;

struct Road {
    int u;
    int v;
    int p;
};

int main(){
    ios::sync_with_stdio(false);
    cin.tie(0);
    
    while(true){
        int n, m;
        cin >> n >> m;
        
        if(n == 0 && m == 0){
            break;
        }
        
        // Read all roads and determine the maximum PPA
        int P = INT32_MIN;
        vector<Road> roads;
        roads.reserve(m);
        
        for(int i = 0; i < m; ++i){
            Road road;
            cin >> road.u >> road.v >> road.p;
            roads.push_back(road);
            if(road.p > P){
                P = road.p;
            }
        }
        
        // Build adjacency list for roads with PPA == P
        // Using vector< vector<int> > for adjacency list
        vector<vector<int>> adj(n + 1, vector<int>());
        
        for(const auto &road : roads){
            if(road.p == P){
                adj[road.u].push_back(road.v);
                adj[road.v].push_back(road.u);
            }
        }
        
        // BFS to find connected components
        vector<bool> visited(n + 1, false);
        int max_cities = 0;
        
        for(int u = 1; u <= n; ++u){
            if(!visited[u] && !adj[u].empty()){
                // BFS initialization
                queue<int> q;
                q.push(u);
                visited[u] = true;
                int count = 1;
                
                while(!q.empty()){
                    int current = q.front();
                    q.pop();
                    
                    for(auto &neighbor : adj[current]){
                        if(!visited[neighbor]){
                            visited[neighbor] = true;
                            count++;
                            q.push(neighbor);
                        }
                    }
                }
                
                if(count > max_cities){
                    max_cities = count;
                }
            }
        }
        
        // Handle the case where no roads have PPA == P
        // According to the problem constraints, there is at least one road
        // So max_cities should be at least 2 if there's any road with PPA == P
        // If no roads have PPA == P (which is impossible since P is the max PPA),
        // but to be safe, set max_cities to 1
        if(max_cities == 0){
            max_cities = 1;
        }
        
        cout << max_cities << "\n";
    }
    
    return 0;
}
