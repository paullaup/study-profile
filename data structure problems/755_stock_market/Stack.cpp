class Stack {
    private:
        int* data;
        int top;
        int size;
    public:
        Stack(int size) {
            this->size = size;
            data = new int[this->size];
            top = -1;
        }
        bool isEmpty() {
            return (top == -1);
        }
        bool isFull() {
            return (top == size-1);
        }
        void push(int val) {
            if(!isFull()) {
                data[++top] = val;
            }
        }
        int pop() {
            if(!isEmpty()) {
                return data[top--];
            }
            return -1;
        }
        
};