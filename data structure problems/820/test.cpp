#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

class node {
    public:
        int num;
        unordered_map<int, int> index;
        vector<node> childs;

        node() {
            num = -1;
        }

        void addChild(int num) {
            node n;
            n.num = num;
            childs.push_back(n);
            index[num] = childs.size();
        }
};  

int main() {
    unordered_map<int, node> map;
    map[0].num = 1;
    if(map[0].childs[0] != NULL);
    cout << map[0].childs[0].num << endl;
    return 0;
}