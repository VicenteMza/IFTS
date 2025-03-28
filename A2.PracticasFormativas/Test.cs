using Semana2;

public class Test
{
    public static void Main()
    {
        /*
            Todos los atributos numéricos deberán aceptar valores entre 0 y 100; en caso que el setter correspondiente 
        reciba un valor fuera de rango deberá setear el valor límite  correspondiente (si recibe un valor negativo 
        asignar cero, si recibe uno superior a cien, asignar cien).

            Se deberá crear un método competir() el cual recibirá otro superhéroe como parámetro y, comparando los  
        poderes de él mismo contra el otro recibido por  parámetro, devolverá TRIUNFO, EMPATE o  DERROTA, dependiendo 
        del resultado.
            Para triunfar un superhéroe debe superar al otro en al menos 2 de los 3 ítems.

        */
        SuperHeroe superman = new SuperHeroe("Superman", 90, 85, 95);
        SuperHeroe batman = new SuperHeroe("Batman", 80, 80, 85);

        Console.WriteLine($"Resultado de la lucha 1 entre {superman.Name} y {batman.Name}: {superman.Compete(batman)} de {superman.Name}");
        Console.WriteLine($"Resultado de la lucha 3 entre {batman.Name} y {superman.Name}: {batman.Compete(superman)} contra {superman.Name}");

        superman.Strength = 75;
        superman.Resistance = 70;
        superman.SuperPower = 80;
        batman.Strength = 95;
        batman.Resistance = 90;
        batman.SuperPower = 100;

        Console.WriteLine($"Resultado de la lucha 4 entre {batman.Name} y {superman.Name}: {batman.Compete(superman)} contra {superman.Name}");

        superman.Strength = 85;
        superman.Resistance = 80;
        superman.SuperPower = 90;
        batman.Strength = 85;
        batman.Resistance = 80;
        batman.SuperPower = 90;

        Console.WriteLine($"Resultado de la lucha 5 entre {superman.Name} y {batman.Name}: {superman.Compete(batman)}");

        superman.Strength = 90;
        superman.Resistance = 85;
        superman.SuperPower = 70;
        batman.Strength = 95;
        batman.Resistance = 80;
        batman.SuperPower = 75;

        Console.WriteLine($"Resultado de la lucha 6 entre {superman.Name} y {batman.Name}: {superman.Compete(batman)} de {superman.Name}");

        batman.Strength = -1;
        batman.Resistance = 120;
        batman.SuperPower = -1;

        Console.WriteLine($"Resultado de la lucha 7 entre {superman.Name} y {batman.Name}: {superman.Compete(batman)} de {superman.Name}");
    }
}