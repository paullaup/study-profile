#include <iostream>
#include <algorithm>
#include <limits.h>
#include <deque>

using namespace std;

void printq(deque<int> q) {
    int size = q.size();
    for(int i = 0; i < size; i++) {
        if(i == size - 1) {
            cout << q.back() << endl;
            break;
        }
        cout << q.back() << " ";
        q.pop_back();
    }
}


int main() {
    int num;
    int size;
    int data;
    int min = INT_MAX;
    int max = INT_MIN;
    int front;
    deque<int> qmin;
    deque<int> qmax;
    deque<int> q;
    cin >> num >> size;
    for(int i = 0; i < size; i++) {
        cin >> data;
        min = (data < min)? data : min;
        max = (data > max)? data : max;
        q.push_front(data);

    }
    qmin.push_front(min);
    qmax.push_front(max);

    num -= size;
    while(num--) {
        cin >> data;
        front = q.back();
        q.pop_back();
        q.push_front(data);
        if(data <= min) {
            min = data;
        }
        else if(front == min) {
            min = *min_element(q.begin(), q.end());
        }
        if(data >= max) {
            max = data;
        }
        else if(front == max) {
            max = *max_element(q.begin(), q.end());
        }
        qmin.push_front(min);
        qmax.push_front(max);
    }
    printq(qmin);
    printq(qmax);
    return 0;
}