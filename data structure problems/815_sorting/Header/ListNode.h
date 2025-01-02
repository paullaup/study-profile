class ListNode {
    private:
        int data;
        ListNode* next;
    public:
        ListNode(int val);
        ListNode(int, ListNode*);
        ListNode* getNext();
        void setNext(ListNode*);
        int getData();
};