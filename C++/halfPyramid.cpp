//https://github.com/hajarrashidi/GoldBank
#include <iostream>
#include <cstdio>

using namespace std;

int main()
{

    for(int row = 0; row < 10; row++){
        for(int col = 0; col < row; col++){
            cout << "*";
        }
        cout << "\n";
    }


    getchar();
    return 0;
}


