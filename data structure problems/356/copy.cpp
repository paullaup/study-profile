#include <iostream>
#include <vector>
#include <bitset>
#include <queue>
#include <climits>

using namespace std;

const int MAX_CITIES = 500;

struct Road {
    int u;
    int v;
    int p;
};

int main(){
    
    while(true){
        int n, m;
        cin >> n >> m;
        
        if(n == 0 && m == 0){
            break;
        }
        
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
        
        vector<vector<int>> adj(n + 1, vector<int>());
        
        for(const auto &road : roads){
            if(road.p == P){
                adj[road.u].push_back(road.v);
                adj[road.v].push_back(road.u);
            }
        }
        
        vector<bool> visited(n + 1, false);
        int max_cities = 0;
        
        for(int u = 1; u <= n; ++u){
            if(!visited[u] && !adj[u].empty()){
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
        
        if(max_cities == 0){
            max_cities = 1;
        }
        
        cout << max_cities << "\n";
    }
    
    return 0;
}
