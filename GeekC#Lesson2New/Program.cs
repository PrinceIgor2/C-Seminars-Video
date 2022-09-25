// // int Max (int arg1, int arg2, int arg3);
// // {
// //     int result = arg1;
// //     if(arg2 > result) result = arg2;
// //     if(arg3 > result) result = arg3;
// //     return result;
// // }

// // int a = 67;
// // int b = 17;
// // int c = 8989;
// // int d = 67;
// // int e = 47;
// // int f = 167;
// // int g = 687;
// // int h = 34;
// // int i = 459;

// // int max1 = Max(a,b,c);
// // Console.WriteLine(max1);
// // int max2 = Max(d,e,f);
// // Console.WriteLine(max2);
// // int max3 = Max(g,h,i);
// // Console.WriteLine(max3);
// // int MaxTotal = Max(max1, max2, max3);

// // // if(b > max) max = b;
// // // if(c > max) max = c;

// // // if(d > max) max = d;
// // // if(e > max) max = e;
// // // if(f > max) max = f;

// // // if(g > max) max = g;
// // // if(h > max) max = h;
// // // if(i > max) max = i;

// // Console.WriteLine(MaxTotal);




// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //              0  1  2  3  4 5  6  8  9
// int[] array = {11,22,33,34,35,6,97,18,49};


// int max = Max();


// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);

// // int max = Max(
// //     Max(a1, b1, c1), 
// //     Max(a2, b2, c2),
// //     Max(a3, b3, c3));

// Console.WriteLine(max);


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
//  //              0    1   2   3   4   5   6   7   8
// int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(result);

// int[] array = {1,6,8,7,9,4,7,9,4};
// int n = array.Length;
// int find = 7;
// int index = 0;
// while(index < n){
// if(array[index] == find){
//     Console.WriteLine(index);
//     break;
// }
//     index++;
// }
 
void FillArray(int[] collection){

int length = collection.Length;
int index = 0;
while(index < length){
    
    collection[index] = new Random().Next(1, 10);
    index++;
}
}

void PrintArray(int[]col){
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOF(int[] collection, int find);
{
int count = collection.Length;
int index = 0;
int position = -1;
while(index < count){
if(collection[index] == find)
{
 position = index;
}
    index++;
}
return position;
}

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
