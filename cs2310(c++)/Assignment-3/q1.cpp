#include <iostream>

using namespace std;

struct MyComplex {
    double real;
    double imaginary;
    MyComplex(){};
    MyComplex(double real, double imaginary) : real(real), imaginary(imaginary){}; 
    friend ostream &operator<< (ostream &cout , MyComplex complex) {
        if(complex.real!=0) {
            cout << complex.real;
        }
        if(complex.imaginary==0 && complex.real==0) {
            cout << 0;
        }
        else if(complex.imaginary>0 && complex.real!=0) {
            cout << "+" << complex.imaginary << 'i';
        }
        else if(complex.real == 0 || complex.imaginary<0){
            cout << complex.imaginary << 'i';
        }
        return cout;
    }
};

class Calculator {
    protected:
        MyComplex num1;
        MyComplex num2;
    public:
        void set(MyComplex n1, MyComplex n2) {
            this->num1 = n1;
            this->num2 = n2;
        }
        virtual MyComplex getResult() = 0;
        virtual void print() = 0;
        
        
};

class AdditionCal : public Calculator {
    public:
        MyComplex getResult() {
            MyComplex result(num1.real + num2.real, num1.imaginary + num2.imaginary); 
            return result;
        }
        void print() {
           cout << "The result of (" << num1 << ")+(" << num2 << ") is " << getResult() << endl;
        }

};

class SubtractionCal : public Calculator {
    public:
        MyComplex getResult() {
            MyComplex result(num1.real - num2.real, num1.imaginary - num2.imaginary); 
            return result;
        }
        void print() {
           cout << "The result of (" << num1 << ")-(" << num2 << ") is " << getResult() << endl;
        }
};

class MultiplyCal : public Calculator {
    public:
        MyComplex getResult() {
            MyComplex result(num1.real*num2.real - num1.imaginary*num2.imaginary, num1.real*num2.imaginary + num1.imaginary*num2.real);
            return result;
        }
        void print() {
           cout << "The result of (" << num1 << ")*(" << num2 << ") is " << getResult() << endl;
        }
};

int main() {
    int real, imaginary;
    Calculator *add;
    Calculator *subtract;
    Calculator *multiply;
    MyComplex num1, num2;
    cout << "Input the first operand:" << endl;
    cin >> real >> imaginary;
    num1.real = real;
    num1.imaginary = imaginary;
    cout << "Input the second operand:" << endl;
    cin >> real >> imaginary;
    num2.real = real;
    num2.imaginary = imaginary;
    add = new AdditionCal;
    add->set(num1, num2);
    subtract = new SubtractionCal;
    subtract->set(num1, num2);
    multiply = new MultiplyCal;
    multiply->set(num1, num2);
    add->print();
    subtract->print();
    multiply->print();
    return 0;
}