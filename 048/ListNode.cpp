class ListNode {
    public:
        int data;
        ListNode* next;
        ListNode() {
            data = 0;
            next = nullptr;
        }
        ListNode(int d, ListNode* n) {
            this->data = d;
            this->next = n;
        }
};