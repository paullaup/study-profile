#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

class node {
    public:
        int num;
        bool cut;
        bool isLeaf;
        unordered_map<int, node*> childs;
        unordered_map<int, bool> exsits;
        node() {
            num = -1;
            cut = true;
            isLeaf = true;
        }
        node(int num) {
            this->num = num;
            cut = true;
            isLeaf = true;
        }
        int getMinCut() {
            if(cut) {
                return 1;
            }
            int sum = 0;
            for(auto child : childs) {
                sum += child.second->getMinCut();
            }
            return sum;
        }
};

int main() {
    int T;
    cin >> T;
    while(T--) {
        int n, m;
        cin >> n >> m;
        unordered_map<int, int> leafCount;
        node* truck = new node();
        int temp = n;
        while(temp--) {
            int num;
            node* current = truck;
            cin >> num;
            while(num != -1){
                current->isLeaf = false;
                if(!current->exsits[num]) {
                    current->childs.insert({num, new node(num)});
                    current->exsits[num] = true;
                }
                current = current->childs[num];
                cin >> num;
            }
        }

        temp = m;
        int updatedCut;
        truck->cut = false;
        while(temp--) {
            int num;
            node* current = truck;
            cin >> num;
            do {
                if(!current->exsits[num]) {
                    current->childs.insert({num, new node(num)});
                    current->exsits[num] = true;
                }
                current = current->childs[num];
                current->cut = false;
                cin >> num;
            }while(num != -1);
        }

        if(m == 0) {
            cout << truck->childs.size() << endl;
        }
        else {
            cout << truck->getMinCut() << endl;
        }
        
        
    }
    return 0;
}