#include <iostream>

using namespace std;

class Stack755 {
    public:
        int* heights;
        int* indces;
        int capacity;
        int top;
        long long int maxArea;
        int width;

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
            if (isFull()) {
                return;
            }
            heights[++top] = val;
            indces[top] = index;
        }

        void process(int height) {
            int index = width;

            while (!isEmpty() && heights[top] > height) {
                int h = heights[top];
                index = indces[top--];
                long long area = (long long)h * (width - index);
                if (area > maxArea) {
                    maxArea = area;
                }
            }
            push(index, height);
            width++;
        }

        long long findMaxArea() {
            while (!isEmpty()) {
                int h = heights[top];
                int index = indces[top--];
                long long area = (long long)h * (width - index);
                if (area > maxArea) {
                    maxArea = area;
                }
            }
            return maxArea;
        }
};

int main() {
    int testCaseCount;
    cin >> testCaseCount;
    for (int i = 0; i < testCaseCount; i++) {
        Stack755* stack = new Stack755(100000);

        int n;
        cin >> n;

        for (int j = 0; j < n; j++) {
            int height;
            cin >> height;
            stack->process(height);
        }

        cout << stack->findMaxArea() << endl;
        delete stack;
    }

    return 0;
}
