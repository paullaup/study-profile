#include <iostream>
using namespace std;

#define size 10

int main() {
    char stations[10];
    int distance[10];
    int min = 6;
    cout << "Input the gas station data:" << endl;
    for(int i = 0 ; i < size; i++) {
        cin >> stations[i] >> distance[i];
        min = (distance[i] < min)? distance[i] : min;
    }
    cout << "The nearby gas stations map is:" << endl;
    int count = 0;
    for(int i = 0 ; i < size; i++) {
        if(distance[i] <= 5) {
            cout << stations[i] << '(' << distance[i] << ')';
            if(distance[i] == min) {
                cout.put('*');
            }
            count++;
            cout.put((count%3==0)? '\n' : ' ');
        }
    }
    return 0;
}