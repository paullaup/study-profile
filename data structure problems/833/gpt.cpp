#include <iostream>
#include <vector>
#include <algorithm>
#include <unordered_map>
using namespace std;

// Union-Find (Disjoint Set) Class
class UnionFind {
private:
    vector<int> parent, size;
public:
    UnionFind(int n) {
        parent.resize(n);
        size.resize(n, 1);
        for (int i = 0; i < n; ++i) {
            parent[i] = i;
        }
    }

    int find(int x) {
        if (parent[x] != x)
            parent[x] = find(parent[x]);
        return parent[x];
    }

    void unite(int x, int y) {
        int rootX = find(x), rootY = find(y);
        if (rootX != rootY) {
            if (size[rootX] < size[rootY]) {
                swap(rootX, rootY);
            }
            parent[rootY] = rootX;
            size[rootX] += size[rootY];
        }
    }

    int getComponentCount() {
        unordered_map<int, bool> components;
        for (int i = 0; i < parent.size(); ++i) {
            components[find(i)] = true;
        }
        return components.size();
    }
};

int main() {
    int n, m;
    cin >> n >> m;
    vector<vector<int>> grid(n, vector<int>(m));
    vector<pair<int, pair<int, int>>> heights; // To store coordinates with their height
    
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < m; ++j) {
            cin >> grid[i][j];
            heights.push_back({grid[i][j], {i, j}});
        }
    }

    int q;
    cin >> q;
    vector<int> years(q);
    for (int i = 0; i < q; ++i) {
        cin >> years[i];
    }

    // Sort the heights in descending order
    sort(heights.rbegin(), heights.rend());

    UnionFind uf(n * m);
    vector<int> results(q);
    vector<vector<bool>> isActive(n, vector<bool>(m, false));
    int currentIndex = 0;

    // Map the year queries to their indices
    unordered_map<int, int> yearToIndex;
    for (int i = 0; i < q; ++i) {
        yearToIndex[years[i]] = i;
    }

    // Process the grid cells in reverse order (decreasing water level)
    for (int year = years[q - 1]; year >= 1; --year) {
        // Activate all cells with height <= year
        while (currentIndex < heights.size() && heights[currentIndex].first <= year) {
            int i = heights[currentIndex].second.first;
            int j = heights[currentIndex].second.second;
            isActive[i][j] = true;

            // Try to union with neighboring cells (up, down, left, right)
            int idx = i * m + j;

            // Up
            if (i > 0 && isActive[i - 1][j]) uf.unite(idx, (i - 1) * m + j); 
            // Down
            if (i < n - 1 && isActive[i + 1][j]) uf.unite(idx, (i + 1) * m + j); 
            // Left
            if (j > 0 && isActive[i][j - 1]) uf.unite(idx, i * m + (j - 1)); 
            // Right
            if (j < m - 1 && isActive[i][j + 1]) uf.unite(idx, i * m + (j + 1)); 

            currentIndex++;
        }

        // After updating for this year, store the number of islands for this year
        if (yearToIndex.count(year)) {
            results[yearToIndex[year]] = uf.getComponentCount();
        }
    }

    // Output the results for all years in the order they were requested
    for (int i = 0; i < q; ++i) {
        cout << results[i] << " ";
    }
    cout << endl;

    return 0;
}
