class calculator
{
static void main(string[]args)
{
	int a = 10;
	int b = 6;
	
	console.Writelineriteline("hasil penambahan: {0}+{1} = {2}",a,b, penambahan(a,b));
	console.Writelineriteline("hasil pengurangan: {0}-{1} = {2}",a,b,pengurangan(a,b));
}
static int penambahan(int a, int b){
	return a + b;
}
static int pengurangan(int a, int b){
	return a - b;
}