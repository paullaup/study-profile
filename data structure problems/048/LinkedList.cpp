#include "ListNode.cpp"

class LinkedList {
    public:
        ListNode* first;
        ListNode* last;
        LinkedList() {
            first = nullptr;
            last = nullptr;
        }

        void append(int num) {
            if(first == nullptr) {
                first = new ListNode(num, nullptr);
                last = first;
                return;
            }
            if(first == last) {
                ListNode* temp = new ListNode(num, nullptr);
                first->next = temp;
                last = temp;
                return;
            }
            ListNode* temp = new ListNode(num, nullptr);
            last->next = temp;
            last = temp;
            
        }

        bool search(int num) {
            ListNode* current = first;
            while(current != nullptr) {
                if(current->data == num) {
                    return true;
                }
                current = current->next;
            }
            return false;
        }
};