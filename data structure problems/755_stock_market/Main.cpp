#include <iostream>

using namespace std;

//using stack, store maximum area, store previous height 

class Stack755 {
    public:
        int* heights;
        int* indces;
        int width;
        int capacity;
        int top;
        long long int maxArea;
        Stack755(int capacity) {
            this->capacity = capacity;
            this->top = -1;
            this->heights = new int[this->capacity];
            this->indces = new int[this->capacity];
            this->width = 0;
            maxArea = 0;
        }
        bool isEmpty() {
            return top == -1;
        }
        bool isFull() {
            return top == capacity - 1;
        }
        void push(int index, int val) {
            if(isFull()) {
                return;
            }
            heights[++top] = val;
            indces[top] = index;
            width++;
        }

        void process(int height) {

            if(isEmpty()) {
                push(0, height);
                return;
            }

            if(heights[top] <= height) {
                push(width, height);
                return;
            }

            int index;
            while(!isEmpty() && heights[top] > height) {
                int height = heights[top];
                index = indces[top--];
                maxArea = (height * (width - index) > maxArea)? height * (width - index) : maxArea;
            }
            push(index, height);
        }

        int findMaxArea() {
            while(!isEmpty()) {
                int height = heights[top];
                int index = indces[top--];
                maxArea = (height * (width - index) > maxArea)? height * (width - index) : maxArea;
            }
            return maxArea;
        }
};

int main() {
    int testCaseCount;
    cin >> testCaseCount;
    for(int i = 0; i < testCaseCount; i++) {

        Stack755* stack = new Stack755(100000);

        int n;
        cin >> n;
        for(int j = 0; j < n; j++) {
            int height;

            cin >> height;

            stack->process(height);
        }
        cout << stack->findMaxArea() << endl;
        delete stack;
    }
    return 0;
}