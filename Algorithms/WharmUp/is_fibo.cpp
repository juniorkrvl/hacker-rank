#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int t,v;
    scanf("%d",&t);
    for(int i=0;i<t;i++){
    	scanf("%d",&v);
    	
    	int f = 5*(v*v) + 4;
    	int sqf = sqrt(f);
    	int s = 5*(v*v) - 4;
    	int sqs = sqrt(s);
    	
    	if(sqf*sqf == f || sqs*sqs == s)
    		printf("IsFibo\n");
    	else
    		printf("IsNotFibo\n");
    	
	}
    return 0;
}

