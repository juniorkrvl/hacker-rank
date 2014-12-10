#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int t;
    scanf("%d",&t);
    for(int i=0;i<t;i++){
        char digits[12];
        scanf("%s",digits);
        
        int index=0;
        int count=0;
        
        while(digits[index] != '\0'){
        	if((digits[index]-'0')>0 && atoi(digits)%(digits[index]-'0') == 0)
				 count++;
			index++;
		}
		
		printf("%d\n",count);
    }
    
    return 0;
}
