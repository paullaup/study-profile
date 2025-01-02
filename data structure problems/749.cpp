#include<iostream>
using namespace std;

class Node{
    public:
    Node* right;
    Node* left;
    int data;
    Node(int n){data = n;}
};

// class Tree{
//     public:
//         Node* root;
//         Tree(Tree* r, Tree* l, int n){
//             root = new Node(n);
//             root->left=l;
//             root->right=r;
//         }
//         void getPost(){
//             cout<<"pose";
//         }
// };

int* subArray(int* arr,int start, int end){
    cout<<"sub1\n";
    int* ans = new int;
    for(int i=0;i<start-end;i++){
        ans[i]=arr[start+i];
    }
    return ans;
};

Node* buildTree(int pre[],int in[]){
    // Node* root = new Node(pre[0]);
    // int size = *(&pre+1)-pre;
    // if(size==1){
    //     root->left = NULL;
    //     root->right=NULL;
    //     return root;
    // }

    for(int i=0;i<5;i++) cout<<*(pre+i)<<" ";
    cout<<"\n";
    for(int i=0;i<5;i++) cout<<*(in+i)<<" ";
    cout<<"\n";

    // find index of root in the inorder
    int ind = 0;
    cout<<pre<<" "<<in+ind<<"\n";
    while(pre!=in+ind) ind++;
    cout<<"ind: "<<ind;
    // cout<<"left "<<ind<<"\n";

    // root->left = buildTree(subArray(pre,1,ind+1),subArray(in,0,ind));
    // cout<<"right\n";
    // root->right = buildTree(subArray(pre,ind+1,size-1),subArray(in,ind+1,size-1));
};

void getPost(Node* root){
    if(root->left!=NULL) getPost(root->left);
    else cout<<root->data<<" ";
    if(root->right!=NULL) getPost(root->right);
    else cout<<root->data<<" ";
    cout<<root->data;
}

int main(){
    int t,num;
    int node;
    cin>>t;
    for(int i=0;i<t;i++){
        cin>>node;
        int* pre = new int[node];
        int* in = new int[node];
        for(int j=0;j<node;j++){
            cin>>num;
            pre[i]=num;
        }
        for(int j=0;j<node;j++){
            cin>>num;
            in[i]=num;
        }
        Node* root = buildTree(pre,*in);
        // cout<<"Yay";
        // getPost(root);
    }
    return 0;
}