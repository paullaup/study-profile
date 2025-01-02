#include <iostream>
#include <vector>
#include <stack>
#include <tuple>
#include <algorithm>

using namespace std;

void compute_subtree_and_sum(
    int root,
    const vector<vector<int>> &adj,
    const vector<int> &audiences,
    vector<int> &subtree_audience,
    vector<int> &sum_distance
) {
    stack<tuple<int, int, int>> stk;
    stk.emplace(root, -1, 0);

    while (!stk.empty()) {
        tuple<int, int, int> top = stk.top();
        stk.pop();

        int node = get<0>(top);
        int parent = get<1>(top);
        int state = get<2>(top);

        if (state == 0) {
            stk.emplace(node, parent, 1);
            for (const auto &child : adj[node]) {
                if (child != parent) {
                    stk.emplace(child, node, 0);
                }
            }
        }
        else {
            int total_audience = audiences[node];
            int total_sum = 0;
            for (const auto &child : adj[node]) {
                if (child != parent) {
                    total_audience += subtree_audience[child];
                    total_sum += sum_distance[child] + subtree_audience[child];
                }
            }
            subtree_audience[node] = total_audience;
            sum_distance[node] = total_sum;
        }
    }
}

int find_min_sum(
    int root,
    const vector<vector<int>> &adj,
    const vector<int> &subtree_audience,
    vector<int> &sum_distance,
    int total_audience
) {
    int min_sum = sum_distance[root];
    stack<tuple<int, int>> stk;
    stk.emplace(root, -1);

    while (!stk.empty()) {
        tuple<int, int> top = stk.top();
        stk.pop();

        int node = get<0>(top);
        int parent = get<1>(top);

        for (const auto &child : adj[node]) {
            if (child != parent) {
                sum_distance[child] = sum_distance[node] - subtree_audience[child] + (total_audience - subtree_audience[child]);
                if (sum_distance[child] < min_sum) {
                    min_sum = sum_distance[child];
                }
                stk.emplace(child, node);
            }
        }
    }

    return min_sum;
}
int main(){

    int n;
    cin >> n;

    vector<vector<int>> adj(n + 1, vector<int>());
    vector<int> audiences(n + 1, 0);

    for(int i = 1; i <= n; ++i){
        int w, l, r;
        cin >> w >> l >> r;
        audiences[i] = w;
        if(l != 0){
            adj[i].push_back(l);
            adj[l].push_back(i);
        }
        if(r != 0){
            adj[i].push_back(r);
            adj[r].push_back(i);
        }
    }

    vector<int> subtree_audience(n + 1, 0);
    vector<int> sum_distance(n + 1, 0);

    compute_subtree_and_sum(1, adj, audiences, subtree_audience, sum_distance);

    int total_audience = subtree_audience[1];

    int min_sum = find_min_sum(1, adj, subtree_audience, sum_distance, total_audience);

    cout << min_sum << endl;

    return 0;
}
