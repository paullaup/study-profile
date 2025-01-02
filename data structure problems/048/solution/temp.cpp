int removeMax() {
    if(isEmpty()) {
        return -1;
    }
    ListNode* current = head;
    ListNode* max = head;
    ListNode* maxprev = nullptr;
    ListNode* prev = nullptr
    while(current != nullptr) {
        if(current->data > max->data) {
              max = current;
               
        }
        prev = current;
        current = current->next;
    }
    if(maxprev == nullptr) {
        head = head->next;
    }
    
}