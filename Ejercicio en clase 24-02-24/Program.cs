/*int si;


for (int i =1; i<=20; i++)
{
    si=i%2;
    if (si == 0)
    {
        Console.WriteLine(i);
    }

}
*/
/*
Console.WriteLine();
int s; int no = 0;
for (int x=1; x<=10; x++)
{
   
    no = no+x;
    Console.WriteLine("El resultado es: "+no);
} */

/*
int nn;
int c = 0;
do
{
    Console.WriteLine("Ingrse numeros enteros positivos para sumarlos, para salir ingrese un numero negativo");
    nn=int.Parse(Console.ReadLine());
   
    if (nn >0)
    {
        c = c+nn;
    }
}while(nn >0);
Console.WriteLine("La suma de los numeros ingresaados es " + c); */

int w = 0;
int pipo, pipo2;


do
{
    w++;
    pipo = 7%w;
    pipo2 =  11%w;


} while (pipo != 0 && pipo2 != 0);

Console.WriteLine("El numero divisible entre 7 y 11 es: " + w);




