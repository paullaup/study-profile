#include <iostream>
#include <set>
#include <iterator>

using namespace std;

int main() {

    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);
    
    int testCaseCount;
    cin >> testCaseCount;

    while (testCaseCount--) {
        int size;
        std::set<int> s;

        cin >> size;

        s.insert(0);
        s.insert(size + 1);

        int number;
        for (int i = 0; i < size; i++) {
            cin >> number;
            set<int>::iterator it = s.lower_bound(number);

            int upper = *it;
            int lower;
            if (it == s.begin()) {
                upper = 0;
            } else {
                lower = *prev(it);
            }

            s.insert(number);

            std::cout << lower << ' ' << upper << '\n';
        }
    }

    return 0;
}
