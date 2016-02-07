#include <iostream>

class Solution {
    public:
        bool canWinNim(int n) {
            return n%4;
        }
};

int main()
{
    Solution nim;
    for (int j=1;j<100;j++) std::cout<<nim.canWinNim(j)<<std::endl;
    return 0;
}
