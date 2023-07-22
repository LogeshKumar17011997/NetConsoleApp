// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Console.WriteLine("Total Elements\n");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] a = new int[n];



//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Enter Element - {0}", i);
//	a[i] = Convert.ToInt32(Console.ReadLine());

//}

//for (int i = 0; i < n; i++)
//{
//	bool flag = true;
//	for (int j = 0; j < n; j++)
//	{
//		if (i != j && a[i] == a[j])
//		{
//			flag = false;
//			break;
//		}

//	}
//	if (flag == true)
//	{
//		Console.WriteLine("The Unique Element is - {0}", a[i]);
//	}
//}


Console.WriteLine("Total Elements of First array is\n");
int n1 = Convert.ToInt32(Console.ReadLine());
int[] first = new int[n1];	

Console.WriteLine("The Input Elements are\n");
for(int i=0;i<n1;i++)
{
	Console.WriteLine("The Input Elements {0} - ",i);
	first[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Total Elements of Second array is\n");
int n2 = Convert.ToInt32(Console.ReadLine());
int[] second = new int[n2];

for (int i = 0; i < n2; i++)
{
	Console.WriteLine("The Input Elements {0} - ", i);
	second[i] = Convert.ToInt32(Console.ReadLine());

}


int s3 = n1 + n2;
int[] third = new int[s3];
int k;
for( k=0;k<n1;k++)
{
	third[k] = first[k];
}
for (int j = 0; j < n2; j++)
{
	third[k] = second[j];
	k++;
}


Console.WriteLine("The Merger Array is\n");


for(int l=0;l<s3;l++)
{
	Console.Write(third[l]);
}

Console.WriteLine("The Sorted Array is\n");

Array.Sort(third);
for (int l = 0; l < s3; l++)
{
	Console.Write("final {0}",third[l]);
}
//for (int i = 0; i < s3; i++)
//{
//	for (int j = 0; j < s3; j++)
//	{
//		if(i !=j && third[i] < third[j])
//		{
//			Console.WriteLine("The Sorted Array is - {0}", third[i]);
//		}
//	}
//}
