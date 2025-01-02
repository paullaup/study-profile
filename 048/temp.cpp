#include <iostream>
#include <vector>
#include <limits.h>

using namespace std;

int main() {
    bool* temp = new bool[10];
    for(int i = 0; i < 10; i++) {
        cout << temp[i] << endl;
    }
    return 0;
}
