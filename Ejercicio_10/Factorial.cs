class Factorial{
    public int num;
    public int cont;
    public int fact;
    public void OPfactorial(){
        Console.WriteLine("Ingrese el número");
        num=Convert.ToInt32(Console.ReadLine());
        if (num==0){
            Console.WriteLine("El factorial de "+num+" es 1");
        }else{
            fact=num;
            for(cont=num; cont>1;cont--){
                fact=fact*(cont-1);
            }
            Console.WriteLine("El factorial de "+num+" es "+fact);
        }
    }
}